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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblSPPort = new System.Windows.Forms.Label();
            this.lblSPBaud = new System.Windows.Forms.Label();
            this.gboxSerialPort = new System.Windows.Forms.GroupBox();
            this.btnSPCheckPort = new System.Windows.Forms.Button();
            this.cmbSPBaud = new System.Windows.Forms.ComboBox();
            this.cmbSPPort = new System.Windows.Forms.ComboBox();
            this.gboxXLFile = new System.Windows.Forms.GroupBox();
            this.lblFilename = new System.Windows.Forms.Label();
            this.btnXLFilePicker = new System.Windows.Forms.Button();
            this.btnCancelFreqs = new System.Windows.Forms.Button();
            this.btnLoadFreqs = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.gboxBanks = new System.Windows.Forms.GroupBox();
            this.dgvBanks = new System.Windows.Forms.DataGridView();
            this.btnCancelBanks = new System.Windows.Forms.Button();
            this.btnLoadBanks = new System.Windows.Forms.Button();
            this.gboxFreqs = new System.Windows.Forms.GroupBox();
            this.txtUpdateBox = new System.Windows.Forms.TextBox();
            this.cbSerialDebug = new System.Windows.Forms.CheckBox();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.gboxSerialPort.SuspendLayout();
            this.gboxXLFile.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.gboxBanks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanks)).BeginInit();
            this.gboxFreqs.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSPPort
            // 
            this.lblSPPort.AutoSize = true;
            this.lblSPPort.Location = new System.Drawing.Point(4, 34);
            this.lblSPPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSPPort.Name = "lblSPPort";
            this.lblSPPort.Size = new System.Drawing.Size(42, 20);
            this.lblSPPort.TabIndex = 0;
            this.lblSPPort.Text = "Port:";
            // 
            // lblSPBaud
            // 
            this.lblSPBaud.AutoSize = true;
            this.lblSPBaud.Location = new System.Drawing.Point(176, 34);
            this.lblSPBaud.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSPBaud.Name = "lblSPBaud";
            this.lblSPBaud.Size = new System.Drawing.Size(51, 20);
            this.lblSPBaud.TabIndex = 1;
            this.lblSPBaud.Text = "Baud:";
            // 
            // gboxSerialPort
            // 
            this.gboxSerialPort.Controls.Add(this.btnSPCheckPort);
            this.gboxSerialPort.Controls.Add(this.cmbSPBaud);
            this.gboxSerialPort.Controls.Add(this.cmbSPPort);
            this.gboxSerialPort.Controls.Add(this.lblSPBaud);
            this.gboxSerialPort.Controls.Add(this.lblSPPort);
            this.gboxSerialPort.Location = new System.Drawing.Point(18, 28);
            this.gboxSerialPort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gboxSerialPort.Name = "gboxSerialPort";
            this.gboxSerialPort.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gboxSerialPort.Size = new System.Drawing.Size(478, 77);
            this.gboxSerialPort.TabIndex = 1;
            this.gboxSerialPort.TabStop = false;
            this.gboxSerialPort.Text = "Serial Comms";
            // 
            // btnSPCheckPort
            // 
            this.btnSPCheckPort.Location = new System.Drawing.Point(357, 29);
            this.btnSPCheckPort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSPCheckPort.Name = "btnSPCheckPort";
            this.btnSPCheckPort.Size = new System.Drawing.Size(112, 32);
            this.btnSPCheckPort.TabIndex = 12;
            this.btnSPCheckPort.Text = "Connect";
            this.btnSPCheckPort.UseVisualStyleBackColor = true;
            this.btnSPCheckPort.Click += new System.EventHandler(this.btnSPCheckPort_Click);
            // 
            // cmbSPBaud
            // 
            this.cmbSPBaud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSPBaud.FormattingEnabled = true;
            this.cmbSPBaud.Location = new System.Drawing.Point(237, 29);
            this.cmbSPBaud.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbSPBaud.Name = "cmbSPBaud";
            this.cmbSPBaud.Size = new System.Drawing.Size(88, 28);
            this.cmbSPBaud.TabIndex = 3;
            // 
            // cmbSPPort
            // 
            this.cmbSPPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSPPort.FormattingEnabled = true;
            this.cmbSPPort.Location = new System.Drawing.Point(57, 29);
            this.cmbSPPort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbSPPort.Name = "cmbSPPort";
            this.cmbSPPort.Size = new System.Drawing.Size(88, 28);
            this.cmbSPPort.TabIndex = 2;
            // 
            // gboxXLFile
            // 
            this.gboxXLFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gboxXLFile.Controls.Add(this.lblFilename);
            this.gboxXLFile.Controls.Add(this.btnXLFilePicker);
            this.gboxXLFile.Location = new System.Drawing.Point(506, 28);
            this.gboxXLFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gboxXLFile.Name = "gboxXLFile";
            this.gboxXLFile.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gboxXLFile.Size = new System.Drawing.Size(551, 77);
            this.gboxXLFile.TabIndex = 2;
            this.gboxXLFile.TabStop = false;
            this.gboxXLFile.Text = "File Path";
            // 
            // lblFilename
            // 
            this.lblFilename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFilename.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFilename.Location = new System.Drawing.Point(130, 26);
            this.lblFilename.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFilename.Name = "lblFilename";
            this.lblFilename.Size = new System.Drawing.Size(399, 35);
            this.lblFilename.TabIndex = 2;
            this.lblFilename.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnXLFilePicker
            // 
            this.btnXLFilePicker.Location = new System.Drawing.Point(9, 26);
            this.btnXLFilePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXLFilePicker.Name = "btnXLFilePicker";
            this.btnXLFilePicker.Size = new System.Drawing.Size(112, 35);
            this.btnXLFilePicker.TabIndex = 0;
            this.btnXLFilePicker.Text = "Choose...";
            this.btnXLFilePicker.UseVisualStyleBackColor = true;
            this.btnXLFilePicker.Click += new System.EventHandler(this.btnXLFilePicker_Click);
            // 
            // btnCancelFreqs
            // 
            this.btnCancelFreqs.Enabled = false;
            this.btnCancelFreqs.Location = new System.Drawing.Point(136, 263);
            this.btnCancelFreqs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelFreqs.Name = "btnCancelFreqs";
            this.btnCancelFreqs.Size = new System.Drawing.Size(112, 35);
            this.btnCancelFreqs.TabIndex = 4;
            this.btnCancelFreqs.Text = "Cancel";
            this.btnCancelFreqs.UseVisualStyleBackColor = true;
            this.btnCancelFreqs.Click += new System.EventHandler(this.btnCancelFreqs_Click);
            // 
            // btnLoadFreqs
            // 
            this.btnLoadFreqs.Enabled = false;
            this.btnLoadFreqs.Location = new System.Drawing.Point(14, 263);
            this.btnLoadFreqs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLoadFreqs.Name = "btnLoadFreqs";
            this.btnLoadFreqs.Size = new System.Drawing.Size(114, 35);
            this.btnLoadFreqs.TabIndex = 3;
            this.btnLoadFreqs.Text = "Load";
            this.btnLoadFreqs.UseVisualStyleBackColor = true;
            this.btnLoadFreqs.Click += new System.EventHandler(this.btnLoadFreqs_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProgressBar,
            this.StatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 956);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1075, 30);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ProgressBar
            // 
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(150, 22);
            this.ProgressBar.Step = 1;
            this.ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(0, 23);
            // 
            // gboxBanks
            // 
            this.gboxBanks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gboxBanks.Controls.Add(this.dgvBanks);
            this.gboxBanks.Controls.Add(this.btnCancelBanks);
            this.gboxBanks.Controls.Add(this.btnLoadBanks);
            this.gboxBanks.Location = new System.Drawing.Point(18, 114);
            this.gboxBanks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gboxBanks.Name = "gboxBanks";
            this.gboxBanks.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gboxBanks.Size = new System.Drawing.Size(1039, 252);
            this.gboxBanks.TabIndex = 6;
            this.gboxBanks.TabStop = false;
            this.gboxBanks.Text = "Bank Sizes";
            // 
            // dgvBanks
            // 
            this.dgvBanks.AllowUserToAddRows = false;
            this.dgvBanks.AllowUserToDeleteRows = false;
            this.dgvBanks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBanks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBanks.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBanks.Location = new System.Drawing.Point(14, 29);
            this.dgvBanks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvBanks.Name = "dgvBanks";
            this.dgvBanks.ReadOnly = true;
            this.dgvBanks.RowHeadersWidth = 62;
            this.dgvBanks.Size = new System.Drawing.Size(1017, 169);
            this.dgvBanks.TabIndex = 6;
            // 
            // btnCancelBanks
            // 
            this.btnCancelBanks.Enabled = false;
            this.btnCancelBanks.Location = new System.Drawing.Point(136, 208);
            this.btnCancelBanks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelBanks.Name = "btnCancelBanks";
            this.btnCancelBanks.Size = new System.Drawing.Size(112, 35);
            this.btnCancelBanks.TabIndex = 5;
            this.btnCancelBanks.Text = "Cancel";
            this.btnCancelBanks.UseVisualStyleBackColor = true;
            this.btnCancelBanks.Click += new System.EventHandler(this.btnCancelBanks_Click);
            // 
            // btnLoadBanks
            // 
            this.btnLoadBanks.Enabled = false;
            this.btnLoadBanks.Location = new System.Drawing.Point(14, 208);
            this.btnLoadBanks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLoadBanks.Name = "btnLoadBanks";
            this.btnLoadBanks.Size = new System.Drawing.Size(114, 35);
            this.btnLoadBanks.TabIndex = 5;
            this.btnLoadBanks.Text = "Load";
            this.btnLoadBanks.UseVisualStyleBackColor = true;
            this.btnLoadBanks.Click += new System.EventHandler(this.btnLoadBanks_Click);
            // 
            // gboxFreqs
            // 
            this.gboxFreqs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gboxFreqs.Controls.Add(this.btnLoadFreqs);
            this.gboxFreqs.Controls.Add(this.btnCancelFreqs);
            this.gboxFreqs.Location = new System.Drawing.Point(18, 375);
            this.gboxFreqs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gboxFreqs.Name = "gboxFreqs";
            this.gboxFreqs.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gboxFreqs.Size = new System.Drawing.Size(1039, 308);
            this.gboxFreqs.TabIndex = 7;
            this.gboxFreqs.TabStop = false;
            this.gboxFreqs.Text = "Frequencies";
            // 
            // txtUpdateBox
            // 
            this.txtUpdateBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUpdateBox.Location = new System.Drawing.Point(18, 728);
            this.txtUpdateBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUpdateBox.Multiline = true;
            this.txtUpdateBox.Name = "txtUpdateBox";
            this.txtUpdateBox.ReadOnly = true;
            this.txtUpdateBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtUpdateBox.Size = new System.Drawing.Size(1037, 149);
            this.txtUpdateBox.TabIndex = 8;
            // 
            // cbSerialDebug
            // 
            this.cbSerialDebug.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSerialDebug.AutoSize = true;
            this.cbSerialDebug.Location = new System.Drawing.Point(905, 694);
            this.cbSerialDebug.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbSerialDebug.Name = "cbSerialDebug";
            this.cbSerialDebug.Size = new System.Drawing.Size(152, 24);
            this.cbSerialDebug.TabIndex = 9;
            this.cbSerialDebug.Text = "Show serial data";
            this.cbSerialDebug.UseVisualStyleBackColor = true;
            this.cbSerialDebug.CheckedChanged += new System.EventHandler(this.cbSerialDebug_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1075, 986);
            this.Controls.Add(this.cbSerialDebug);
            this.Controls.Add(this.txtUpdateBox);
            this.Controls.Add(this.gboxFreqs);
            this.Controls.Add(this.gboxBanks);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.gboxXLFile);
            this.Controls.Add(this.gboxSerialPort);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "AOR 8200 Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gboxSerialPort.ResumeLayout(false);
            this.gboxSerialPort.PerformLayout();
            this.gboxXLFile.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.gboxBanks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanks)).EndInit();
            this.gboxFreqs.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSPBaud;
        private System.Windows.Forms.Label lblSPPort;
        private System.Windows.Forms.GroupBox gboxSerialPort;
        private System.Windows.Forms.ComboBox cmbSPBaud;
        private System.Windows.Forms.ComboBox cmbSPPort;
        private System.Windows.Forms.Button btnSPCheckPort;
        private System.Windows.Forms.GroupBox gboxXLFile;
        private System.Windows.Forms.Button btnXLFilePicker;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar ProgressBar;
        private System.Windows.Forms.Label lblFilename;
        private System.Windows.Forms.Button btnLoadFreqs;
        private System.Windows.Forms.Button btnCancelFreqs;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.GroupBox gboxBanks;
        private System.Windows.Forms.GroupBox gboxFreqs;
        private System.Windows.Forms.Button btnLoadBanks;
        private System.Windows.Forms.Button btnCancelBanks;
        private System.Windows.Forms.TextBox txtUpdateBox;
        private System.Windows.Forms.CheckBox cbSerialDebug;
        private System.Windows.Forms.DataGridView dgvBanks;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
    }
}

