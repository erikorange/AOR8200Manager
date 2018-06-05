using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Data.OleDb;

namespace AOR8200Manager
{
    public partial class MainForm : Form
    {
        SerialPort sp;

        int[] BaudRates;
        int[] DataBits;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
           
            sp = new SerialPort();

            BaudRates = new int[3] { 4800, 9600, 19200 };
            DataBits = new int[2] { 7, 8 };
            InitSerialControls(sp, BaudRates, DataBits);
        }


        private void InitSerialControls(SerialPort sp, int[] BaudRates, int[] DataBits)
        {
            cmbSPPort.DataSource = SerialPort.GetPortNames();
            cmbSPBaud.DataSource = BaudRates;
            cmbSPBaud.SelectedItem = 19200;
            cmbSPDataBits.DataSource = DataBits;
            cmbSPDataBits.SelectedItem = 8;
            cmbSPParity.DataSource = Enum.GetValues(typeof(Parity));
            cmbSPStopBits.DataSource = Enum.GetValues(typeof(StopBits));
            cmbSPStopBits.SelectedItem = StopBits.Two;
            cmbSPFlowControl.DataSource = Enum.GetValues(typeof(Handshake));
            cmbSPFlowControl.SelectedItem = Handshake.XOnXOff;
        }

        private void btnXLFilePicker_Click(object sender, EventArgs e)
        {
            DialogResult result = xlFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string xlFile = xlFileDialog.FileName;
                LoadXLFile(xlFile);

            }
        }


        private string FormatMode(string mode)
        {
            switch (mode)
            {
                case "WFM":
                    return "0";

                case "NFM":
                    return "1";

                case "AM":
                    return "2";

                case "USB":
                    return "3";

                case "LSB":
                    return "4";

                case "CW":
                    return "5";

                case "SFM":
                    return "6";

                case "WAM":
                    return "7";

                case "NAM":
                    return "8";

                default:
                    return "3";
            }
        }



        private string FormatFreq(string freq)
        {
            // if no decimal, then assume whole number and add the decimal
            if (freq.IndexOf('.') == -1)
            {
                freq = freq + ".0";
            }

            char[] delim = new char[] { '.' };
            string[] parts = freq.Split(delim, 2);

            string leftPart = parts[0].PadLeft(4, '0');
            string rightPart = parts[1].PadRight(5, '0');
            return (leftPart + "." + rightPart);
        }

        private string FormatChannel(string channel)
        {
            return (channel.PadLeft(2, '0'));
        }


        private void LoadXLFile(string filename)
        {
            string connectionString = string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0; data source={0}; Extended Properties=""Excel 12.0;HDR=YES;""", filename);

            string query = String.Format("select * from [{0}$]", "Frequencies");
            OleDbDataAdapter adapter = new OleDbDataAdapter(query, connectionString);
            DataTable dt = new DataTable();

            adapter.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                string bank = row[0].ToString();
                string channel = FormatChannel(row[1].ToString());
                string freq = FormatFreq(row[2].ToString());
                string mode = row[3].ToString();
                string tag = row[4].ToString();
                txtXLConsole.AppendText(String.Format("{0} {1} {2} {3} {4} {5}{6}",
                    bank, channel, freq, mode, FormatMode(mode), tag, Environment.NewLine));
            }
        }

        private void btnSPCheckPort_Click(object sender, EventArgs e)
        {
            const byte CR = 0x0D;
            const byte LF = 0x0A;

            //sp.BaudRate = (int)cmbSPBaud.SelectedValue;
            //sp.DataBits = (int)cmbSPDataBits.SelectedValue;
            //sp.Parity = (Parity)cmbSPParity.SelectedValue;
            //sp.StopBits = (StopBits)cmbSPStopBits.SelectedValue;
            //sp.Handshake = (Handshake)cmbSPFlowControl.SelectedValue;

            sp.BaudRate = 9600;
            sp.DataBits = 8;
            sp.Parity = Parity.None;
            sp.StopBits = StopBits.Two;
            sp.Handshake = Handshake.XOnXOff;


            txtXLConsole.AppendText("Opening Serial Port..." + Environment.NewLine);
            sp.Open();

            byte[] cmd = new byte[4] { 0x4D, 0x53, CR, LF};

            txtXLConsole.AppendText("Writing Command " + Environment.NewLine);
            sp.Write("M");


            
        }



    }
}
