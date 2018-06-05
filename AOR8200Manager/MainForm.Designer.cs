namespace AOR8200Manager
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSPPort = new System.Windows.Forms.Label();
            this.lblSPBaud = new System.Windows.Forms.Label();
            this.gboxSerialPort = new System.Windows.Forms.GroupBox();
            this.btnSPCheckPort = new System.Windows.Forms.Button();
            this.cmbSPFlowControl = new System.Windows.Forms.ComboBox();
            this.lblSPFlowControl = new System.Windows.Forms.Label();
            this.cmbSPStopBits = new System.Windows.Forms.ComboBox();
            this.lblSPStopBits = new System.Windows.Forms.Label();
            this.cmbSPParity = new System.Windows.Forms.ComboBox();
            this.lblSPParity = new System.Windows.Forms.Label();
            this.cmbSPDataBits = new System.Windows.Forms.ComboBox();
            this.lblSPDataBits = new System.Windows.Forms.Label();
            this.cmbSPBaud = new System.Windows.Forms.ComboBox();
            this.cmbSPPort = new System.Windows.Forms.ComboBox();
            this.xlFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.gboxXLFile = new System.Windows.Forms.GroupBox();
            this.txtXLConsole = new System.Windows.Forms.TextBox();
            this.btnXLFilePicker = new System.Windows.Forms.Button();
            this.gboxSerialPort.SuspendLayout();
            this.gboxXLFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSPPort
            // 
            this.lblSPPort.AutoSize = true;
            this.lblSPPort.Location = new System.Drawing.Point(60, 27);
            this.lblSPPort.Name = "lblSPPort";
            this.lblSPPort.Size = new System.Drawing.Size(29, 13);
            this.lblSPPort.TabIndex = 0;
            this.lblSPPort.Text = "Port:";
            // 
            // lblSPBaud
            // 
            this.lblSPBaud.AutoSize = true;
            this.lblSPBaud.Location = new System.Drawing.Point(53, 52);
            this.lblSPBaud.Name = "lblSPBaud";
            this.lblSPBaud.Size = new System.Drawing.Size(35, 13);
            this.lblSPBaud.TabIndex = 1;
            this.lblSPBaud.Text = "Baud:";
            // 
            // gboxSerialPort
            // 
            this.gboxSerialPort.Controls.Add(this.btnSPCheckPort);
            this.gboxSerialPort.Controls.Add(this.cmbSPFlowControl);
            this.gboxSerialPort.Controls.Add(this.lblSPFlowControl);
            this.gboxSerialPort.Controls.Add(this.cmbSPStopBits);
            this.gboxSerialPort.Controls.Add(this.lblSPStopBits);
            this.gboxSerialPort.Controls.Add(this.cmbSPParity);
            this.gboxSerialPort.Controls.Add(this.lblSPParity);
            this.gboxSerialPort.Controls.Add(this.cmbSPDataBits);
            this.gboxSerialPort.Controls.Add(this.lblSPDataBits);
            this.gboxSerialPort.Controls.Add(this.cmbSPBaud);
            this.gboxSerialPort.Controls.Add(this.cmbSPPort);
            this.gboxSerialPort.Controls.Add(this.lblSPBaud);
            this.gboxSerialPort.Controls.Add(this.lblSPPort);
            this.gboxSerialPort.Location = new System.Drawing.Point(12, 12);
            this.gboxSerialPort.Name = "gboxSerialPort";
            this.gboxSerialPort.Size = new System.Drawing.Size(231, 231);
            this.gboxSerialPort.TabIndex = 1;
            this.gboxSerialPort.TabStop = false;
            this.gboxSerialPort.Text = "Serial Comms";
            // 
            // btnSPCheckPort
            // 
            this.btnSPCheckPort.Location = new System.Drawing.Point(94, 190);
            this.btnSPCheckPort.Name = "btnSPCheckPort";
            this.btnSPCheckPort.Size = new System.Drawing.Size(75, 23);
            this.btnSPCheckPort.TabIndex = 12;
            this.btnSPCheckPort.Text = "Connect";
            this.btnSPCheckPort.UseVisualStyleBackColor = true;
            this.btnSPCheckPort.Click += new System.EventHandler(this.btnSPCheckPort_Click);
            // 
            // cmbSPFlowControl
            // 
            this.cmbSPFlowControl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSPFlowControl.FormattingEnabled = true;
            this.cmbSPFlowControl.Location = new System.Drawing.Point(94, 153);
            this.cmbSPFlowControl.Name = "cmbSPFlowControl";
            this.cmbSPFlowControl.Size = new System.Drawing.Size(121, 21);
            this.cmbSPFlowControl.TabIndex = 11;
            // 
            // lblSPFlowControl
            // 
            this.lblSPFlowControl.AutoSize = true;
            this.lblSPFlowControl.Location = new System.Drawing.Point(22, 156);
            this.lblSPFlowControl.Name = "lblSPFlowControl";
            this.lblSPFlowControl.Size = new System.Drawing.Size(67, 13);
            this.lblSPFlowControl.TabIndex = 10;
            this.lblSPFlowControl.Text = "Flow control:";
            // 
            // cmbSPStopBits
            // 
            this.cmbSPStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSPStopBits.FormattingEnabled = true;
            this.cmbSPStopBits.Location = new System.Drawing.Point(95, 126);
            this.cmbSPStopBits.Name = "cmbSPStopBits";
            this.cmbSPStopBits.Size = new System.Drawing.Size(121, 21);
            this.cmbSPStopBits.TabIndex = 9;
            // 
            // lblSPStopBits
            // 
            this.lblSPStopBits.AutoSize = true;
            this.lblSPStopBits.Location = new System.Drawing.Point(37, 129);
            this.lblSPStopBits.Name = "lblSPStopBits";
            this.lblSPStopBits.Size = new System.Drawing.Size(51, 13);
            this.lblSPStopBits.TabIndex = 8;
            this.lblSPStopBits.Text = "Stop bits:";
            // 
            // cmbSPParity
            // 
            this.cmbSPParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSPParity.FormattingEnabled = true;
            this.cmbSPParity.Location = new System.Drawing.Point(95, 100);
            this.cmbSPParity.Name = "cmbSPParity";
            this.cmbSPParity.Size = new System.Drawing.Size(121, 21);
            this.cmbSPParity.TabIndex = 7;
            // 
            // lblSPParity
            // 
            this.lblSPParity.AutoSize = true;
            this.lblSPParity.Location = new System.Drawing.Point(53, 103);
            this.lblSPParity.Name = "lblSPParity";
            this.lblSPParity.Size = new System.Drawing.Size(36, 13);
            this.lblSPParity.TabIndex = 6;
            this.lblSPParity.Text = "Parity:";
            // 
            // cmbSPDataBits
            // 
            this.cmbSPDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSPDataBits.FormattingEnabled = true;
            this.cmbSPDataBits.Location = new System.Drawing.Point(95, 74);
            this.cmbSPDataBits.Name = "cmbSPDataBits";
            this.cmbSPDataBits.Size = new System.Drawing.Size(121, 21);
            this.cmbSPDataBits.TabIndex = 5;
            // 
            // lblSPDataBits
            // 
            this.lblSPDataBits.AutoSize = true;
            this.lblSPDataBits.Location = new System.Drawing.Point(37, 77);
            this.lblSPDataBits.Name = "lblSPDataBits";
            this.lblSPDataBits.Size = new System.Drawing.Size(52, 13);
            this.lblSPDataBits.TabIndex = 4;
            this.lblSPDataBits.Text = "Data bits:";
            // 
            // cmbSPBaud
            // 
            this.cmbSPBaud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSPBaud.FormattingEnabled = true;
            this.cmbSPBaud.Location = new System.Drawing.Point(95, 49);
            this.cmbSPBaud.Name = "cmbSPBaud";
            this.cmbSPBaud.Size = new System.Drawing.Size(121, 21);
            this.cmbSPBaud.TabIndex = 3;
            // 
            // cmbSPPort
            // 
            this.cmbSPPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSPPort.FormattingEnabled = true;
            this.cmbSPPort.Location = new System.Drawing.Point(95, 24);
            this.cmbSPPort.Name = "cmbSPPort";
            this.cmbSPPort.Size = new System.Drawing.Size(121, 21);
            this.cmbSPPort.TabIndex = 2;
            // 
            // xlFileDialog
            // 
            this.xlFileDialog.Filter = "Excel Files|*.xlsx|All files|*.*";
            // 
            // gboxXLFile
            // 
            this.gboxXLFile.Controls.Add(this.txtXLConsole);
            this.gboxXLFile.Controls.Add(this.btnXLFilePicker);
            this.gboxXLFile.Location = new System.Drawing.Point(249, 12);
            this.gboxXLFile.Name = "gboxXLFile";
            this.gboxXLFile.Size = new System.Drawing.Size(421, 231);
            this.gboxXLFile.TabIndex = 2;
            this.gboxXLFile.TabStop = false;
            this.gboxXLFile.Text = "Excel File";
            // 
            // txtXLConsole
            // 
            this.txtXLConsole.Location = new System.Drawing.Point(6, 52);
            this.txtXLConsole.Multiline = true;
            this.txtXLConsole.Name = "txtXLConsole";
            this.txtXLConsole.ReadOnly = true;
            this.txtXLConsole.Size = new System.Drawing.Size(409, 173);
            this.txtXLConsole.TabIndex = 1;
            // 
            // btnXLFilePicker
            // 
            this.btnXLFilePicker.Location = new System.Drawing.Point(6, 22);
            this.btnXLFilePicker.Name = "btnXLFilePicker";
            this.btnXLFilePicker.Size = new System.Drawing.Size(75, 23);
            this.btnXLFilePicker.TabIndex = 0;
            this.btnXLFilePicker.Text = "Choose...";
            this.btnXLFilePicker.UseVisualStyleBackColor = true;
            this.btnXLFilePicker.Click += new System.EventHandler(this.btnXLFilePicker_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 463);
            this.Controls.Add(this.gboxXLFile);
            this.Controls.Add(this.gboxSerialPort);
            this.Name = "MainForm";
            this.Text = "AOR 8200 Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gboxSerialPort.ResumeLayout(false);
            this.gboxSerialPort.PerformLayout();
            this.gboxXLFile.ResumeLayout(false);
            this.gboxXLFile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSPBaud;
        private System.Windows.Forms.Label lblSPPort;
        private System.Windows.Forms.GroupBox gboxSerialPort;
        private System.Windows.Forms.ComboBox cmbSPBaud;
        private System.Windows.Forms.ComboBox cmbSPPort;
        private System.Windows.Forms.Label lblSPDataBits;
        private System.Windows.Forms.ComboBox cmbSPFlowControl;
        private System.Windows.Forms.Label lblSPFlowControl;
        private System.Windows.Forms.ComboBox cmbSPStopBits;
        private System.Windows.Forms.Label lblSPStopBits;
        private System.Windows.Forms.ComboBox cmbSPParity;
        private System.Windows.Forms.Label lblSPParity;
        private System.Windows.Forms.ComboBox cmbSPDataBits;
        private System.Windows.Forms.Button btnSPCheckPort;
        private System.Windows.Forms.OpenFileDialog xlFileDialog;
        private System.Windows.Forms.GroupBox gboxXLFile;
        private System.Windows.Forms.Button btnXLFilePicker;
        private System.Windows.Forms.TextBox txtXLConsole;
    }
}

