using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;

namespace AOR8200Manager
{
    public partial class MainForm : Form
    {
        SerialPort sp;
        Utils Utils;
        BackgroundWorker worker;
        bool responseRx;

        DataTable dtBanks;
        DataTable dtFreqs;
        public bool DebugSerial { get; set; }

        public MainForm()
        {
            InitializeComponent();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            cmbSPPort.DataSource = SerialPort.GetPortNames();
            cmbSPPort.SelectedItem = "COM8";
            cmbSPBaud.DataSource = new int[3] { 4800, 9600, 19200 };
            cmbSPBaud.SelectedItem = 19200;
            Utils = new Utils();
            sp = new SerialPort();
            sp.DataReceived += new SerialDataReceivedEventHandler(sp_DataReceived);
            DebugSerial = false;

        }


        private void btnXLFilePicker_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowser.ShowDialog();
            if (result == DialogResult.OK)
            {
                string filePath = folderBrowser.SelectedPath;
                lblFilename.Text = filePath;

                string bankFile = "AOR8200 Banks.csv";
                string freqFile = "AOR8200 Frequencies.csv";

                dtBanks = Utils.LoadTableFromCSV(filePath + @"\" + bankFile);
                SetupBanksGridView(dtBanks);

                dtFreqs = Utils.LoadTableFromCSV(filePath + @"\" + freqFile);

                btnLoadBanks.Enabled = true;
                btnLoadFreqs.Enabled = true;
            }
        }

        private void SetupBanksGridView(DataTable dt)
        {
            dgvBanks.AutoGenerateColumns = true;
            dgvBanks.DataSource = dt;
        }

        private void btnSPCheckPort_Click(object sender, EventArgs e)
        {
            string RxBuffer;

            if (!sp.IsOpen)
            {
                sp.PortName = (string)cmbSPPort.SelectedValue;
                sp.BaudRate = (int)cmbSPBaud.SelectedValue;
                sp.DataBits = 8;
                sp.Parity = Parity.None;
                sp.StopBits = StopBits.Two;
                sp.Open();
                sp.NewLine = "\r";
            }

            if (SendAndWait("VR", 5, out RxBuffer))
            {
                btnXLFilePicker.Enabled = true;
                StatusLabel.Text = "Connected to AR 8200";
            }
            else
            {
                MessageBox.Show(String.Format("Serial Port {0} timed out.", sp.PortName), "Error");
                sp.Close();
            }
        }


        void sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            responseRx = true;
        }

        private void btnLoadFreqs_Click(object sender, EventArgs e)
        {
            btnLoadFreqs.Enabled = false;
            worker = new BackgroundWorker();
            worker.DoWork += LoadFreqs_Thread;
            worker.ProgressChanged += new ProgressChangedEventHandler(Worker_ProgressChanged);
            worker.WorkerReportsProgress = true;
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(Worker_Completed);
            worker.WorkerSupportsCancellation = true;
            worker.RunWorkerAsync();
            btnCancelFreqs.Enabled = true;
            btnLoadBanks.Enabled = false;
            btnCancelBanks.Enabled = false;
            StatusLabel.Text = "Clearing and loading channels...";
        }

        private void LoadFreqs_Thread(object sender, DoWorkEventArgs e)
        {
            int rowIdx;
            int rowCount;
            int progress;
            bool status;
            string RxBuffer;


            BackgroundWorker w = (BackgroundWorker)sender;

            SetUpdateBox("Clearing banks...");
            // delete all channels in all banks
            List<string> deleteBanks = Utils.GenerateBankDeletes();
            rowIdx = 0;
            rowCount = deleteBanks.Count;
            foreach (string TxBuffer in deleteBanks)
            {
                SetUpdateBox(String.Format("Clearing Bank {0}", TxBuffer.Substring(2, 1)));

                status = SendAndWait(TxBuffer, 10, out RxBuffer);
                // check if we timed out, or if the user cancelled
                if (!status || w.CancellationPending == true)
                {
                    e.Cancel = true;
                    return;
                }

                rowIdx++;
                progress = (int)((float)rowIdx / (float)rowCount * 100);
                w.ReportProgress(progress);
            }


            // load channels into banks
            rowIdx = 0;
            rowCount = dtFreqs.Rows.Count;

            bool isFirst = true;

            foreach (DataRow row in dtFreqs.Rows)
            {
                if (isFirst)
                {
                    isFirst = false;
                    continue;
                }

                string bank = row[0].ToString();
                if (bank != String.Empty)
                {
                    string channel = Utils.FormatChannel(row[1].ToString());
                    string freq = row[2].ToString();
                    string freqFormatted = Utils.FormatFreq(freq);
                    string mode = row[3].ToString();
                    string modeFormatted = Utils.FormatMode(mode);
                    string tag = row[4].ToString();
                    string formattedTag = tag.Length > 12 ? tag.Substring(0, 12) : tag; // limit alpha tag to 12 chars max.
                    string TxBuffer = String.Format(
                        "MX{0}{1} RF{2} AU1 ST000.05 MD{3} AT0 TM{4}", bank, channel, freqFormatted, modeFormatted, tag);

                    SetUpdateBox(String.Format("{0}{1}  {2} {3}  {4}", bank, channel, freq, mode, tag));

                    status = SendAndWait(TxBuffer, 5, out RxBuffer);

                    // check if we timed out, or if the user cancelled
                    if (!status || w.CancellationPending == true)
                    {
                        e.Cancel = true;
                        return;
                    }

                }

                rowIdx++;
                progress = (int)((float)rowIdx / (float)rowCount * 100);
                w.ReportProgress(progress);
            }

        }


        void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //StatusLabel.Text = "Working: " + e.ProgressPercentage.ToString();
            ProgressBar.Value = e.ProgressPercentage;
        }


        void Worker_Completed(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!(e.Error == null))
            {
                StatusLabel.Text = e.Error.Message;
            }
            else if (e.Cancelled == true)
            {
                StatusLabel.Text = "Canceled";
            }
            else
            {
                StatusLabel.Text = "Complete";
            }
            btnLoadFreqs.Enabled = true;
            btnCancelFreqs.Enabled = false;
            btnLoadBanks.Enabled = true;
            btnCancelBanks.Enabled = false;
            ProgressBar.Value = 0;
        }

        private void SetUpdateBox(string message)
        {
            txtUpdateBox.Invoke((MethodInvoker)delegate
            {
                txtUpdateBox.AppendText(message + Environment.NewLine);
            });
        }

        

        private void btnCancelFreqs_Click(object sender, EventArgs e)
        {
            btnCancelFreqs.Enabled = false;
            worker.CancelAsync();
        }

        private void btnLoadBanks_Click(object sender, EventArgs e)
        {
            btnLoadBanks.Enabled = false;
            worker = new BackgroundWorker();
            worker.DoWork += LoadBanks_Thread;
            worker.ProgressChanged += new ProgressChangedEventHandler(Worker_ProgressChanged);
            worker.WorkerReportsProgress = true;
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(Worker_Completed);
            worker.WorkerSupportsCancellation = true;
            worker.RunWorkerAsync();
            btnCancelBanks.Enabled = true;
            btnLoadFreqs.Enabled = false;
            btnCancelFreqs.Enabled = false;
            StatusLabel.Text = "Loading Bank sizes...";
        }

        private void LoadBanks_Thread(object sender, DoWorkEventArgs e)
        {
            int rowIdx;
            int rowCount;
            int progress;
            bool status;
            string RxBuffer;

            BackgroundWorker w = (BackgroundWorker)sender;
            rowIdx = 0;
            rowCount = dtBanks.Rows.Count;

            bool isFirst = true;

            foreach (DataRow row in dtBanks.Rows)
            {
                if (isFirst)
                {
                    isFirst = false;
                    continue;
                }

                string bank = row[0].ToString();
                string size = Utils.FormatChannel(row[1].ToString());
                string tag = row[2].ToString();
                string tagFormatted = tag.Length > 8 ? tag.Substring(0, 8) : tag;
                SetUpdateBox(String.Format("Setting Bank:{0}  Size:{1}  Name:{2}", bank, size, tagFormatted));


                // set bank size
                status = SendAndWait("MW" + bank + size, 300, out RxBuffer);

                // check if we timed out, or if the user cancelled
                if (!status || w.CancellationPending == true)
                {
                    e.Cancel = true;
                    return;
                }

                // set bank name
                status = SendAndWait("TB" + bank + tagFormatted, 10, out RxBuffer);

                // check if we timed out, or if the user cancelled
                if (!status || w.CancellationPending == true)
                {
                    e.Cancel = true;
                    return;
                }

                rowIdx++;
                progress = (int)((float)rowIdx / (float)rowCount * 100);
                w.ReportProgress(progress);
            }

        }


        private bool SendAndWait(string TxBuffer, long timeoutSeconds, out string RxBuffer)
        {
            const char CR = '\r';
            string RxOutput;
            bool timeoutExpired;

            Stopwatch sw = new Stopwatch();
            long timeoutMS = timeoutSeconds * 1000;
            responseRx = false;
            timeoutExpired = false;

            sp.WriteLine(TxBuffer);
            sw.Start();

            while (!timeoutExpired && responseRx == false)
            {
                if (sw.ElapsedMilliseconds >= timeoutMS)
                {
                    timeoutExpired = true;
                }
            }
            sw.Stop();

            // if we timed out, then bail,
            if (timeoutExpired)
            {
                SetUpdateBox("Timeout");
                RxBuffer = string.Empty;
                return false;
            }

            // display and return the data
            Thread.Sleep(50);                   // Give the data a little time to be gathered after the Rx event
            RxBuffer = sp.ReadExisting();
            if (RxBuffer[0] == CR)
            {
                RxOutput = "<CR>";
            }
            else
            {
                RxOutput = Utils.ConvertToASCII(RxBuffer);
            }

            if (DebugSerial)
            {
                SetUpdateBox(String.Format("Tx:{0} Rx:{1}", TxBuffer, RxOutput));
            }

            return true;
        }

        private void btnCancelBanks_Click(object sender, EventArgs e)
        {
            btnCancelBanks.Enabled = false;
            worker.CancelAsync();
        }

        private void cbSerialDebug_CheckedChanged(object sender, EventArgs e)
        {
            CheckState cs = cbSerialDebug.CheckState;
            if (cs == CheckState.Checked)
            {
                DebugSerial = true;
            }
            else
            {
                DebugSerial = false;
            }
        }

    }
}
