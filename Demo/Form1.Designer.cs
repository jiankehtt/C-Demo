namespace Demo
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bRs232Discon = new System.Windows.Forms.Button();
            this.bRs232Con = new System.Windows.Forms.Button();
            this.cBaudrate = new System.Windows.Forms.ComboBox();
            this.cCommPort = new System.Windows.Forms.ComboBox();
            this.lInfo = new System.Windows.Forms.ListBox();
            this.bClear = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.btnDetail = new System.Windows.Forms.Button();
            this.chkFilter = new System.Windows.Forms.CheckBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.bEpcId = new System.Windows.Forms.Button();
            this.bEpcRead = new System.Windows.Forms.Button();
            this.bEpcWrite = new System.Windows.Forms.Button();
            this.bEpcKill = new System.Windows.Forms.Button();
            this.cEpcTimes = new System.Windows.Forms.ComboBox();
            this.tEpcSpeed = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cEpcMembank = new System.Windows.Forms.ComboBox();
            this.cEpcWordptr = new System.Windows.Forms.ComboBox();
            this.cEpcWordcnt = new System.Windows.Forms.ComboBox();
            this.tEpcData = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.bEpcInit = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tEpcSpeed)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.bRs232Discon);
            this.groupBox1.Controls.Add(this.bRs232Con);
            this.groupBox1.Controls.Add(this.cBaudrate);
            this.groupBox1.Controls.Add(this.cCommPort);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 146);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RS232";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 14);
            this.label2.TabIndex = 7;
            this.label2.Text = "BAUDRATE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "COMM PORT";
            // 
            // bRs232Discon
            // 
            this.bRs232Discon.BackColor = System.Drawing.Color.SlateGray;
            this.bRs232Discon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bRs232Discon.ForeColor = System.Drawing.Color.Gold;
            this.bRs232Discon.Location = new System.Drawing.Point(133, 100);
            this.bRs232Discon.Name = "bRs232Discon";
            this.bRs232Discon.Size = new System.Drawing.Size(77, 40);
            this.bRs232Discon.TabIndex = 5;
            this.bRs232Discon.Text = "Discon";
            this.bRs232Discon.UseVisualStyleBackColor = false;
            this.bRs232Discon.Click += new System.EventHandler(this.bRs232Discon_Click);
            // 
            // bRs232Con
            // 
            this.bRs232Con.BackColor = System.Drawing.Color.SlateGray;
            this.bRs232Con.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bRs232Con.ForeColor = System.Drawing.Color.Gold;
            this.bRs232Con.Location = new System.Drawing.Point(35, 100);
            this.bRs232Con.Name = "bRs232Con";
            this.bRs232Con.Size = new System.Drawing.Size(77, 40);
            this.bRs232Con.TabIndex = 4;
            this.bRs232Con.Text = "Connect";
            this.bRs232Con.UseVisualStyleBackColor = false;
            this.bRs232Con.Click += new System.EventHandler(this.bRs232Con_Click);
            // 
            // cBaudrate
            // 
            this.cBaudrate.FormattingEnabled = true;
            this.cBaudrate.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cBaudrate.Location = new System.Drawing.Point(123, 62);
            this.cBaudrate.Name = "cBaudrate";
            this.cBaudrate.Size = new System.Drawing.Size(87, 22);
            this.cBaudrate.TabIndex = 3;
            // 
            // cCommPort
            // 
            this.cCommPort.FormattingEnabled = true;
            this.cCommPort.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10",
            "COM11",
            "COM12",
            "COM13",
            "COM14",
            "COM15",
            "COM16",
            "COM17",
            "COM18",
            "COM19",
            "COM20"});
            this.cCommPort.Location = new System.Drawing.Point(123, 28);
            this.cCommPort.Name = "cCommPort";
            this.cCommPort.Size = new System.Drawing.Size(87, 22);
            this.cCommPort.TabIndex = 2;
            // 
            // lInfo
            // 
            this.lInfo.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lInfo.FormattingEnabled = true;
            this.lInfo.HorizontalScrollbar = true;
            this.lInfo.ItemHeight = 12;
            this.lInfo.Location = new System.Drawing.Point(6, 23);
            this.lInfo.Name = "lInfo";
            this.lInfo.ScrollAlwaysVisible = true;
            this.lInfo.Size = new System.Drawing.Size(367, 616);
            this.lInfo.TabIndex = 0;
            // 
            // bClear
            // 
            this.bClear.BackColor = System.Drawing.Color.SlateGray;
            this.bClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bClear.ForeColor = System.Drawing.Color.Gold;
            this.bClear.Location = new System.Drawing.Point(296, 657);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(77, 37);
            this.bClear.TabIndex = 11;
            this.bClear.Text = "Clear";
            this.bClear.UseVisualStyleBackColor = false;
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.Color.SlateGray;
            this.btnList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnList.ForeColor = System.Drawing.Color.Gold;
            this.btnList.Location = new System.Drawing.Point(134, 657);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(77, 37);
            this.btnList.TabIndex = 12;
            this.btnList.Text = "List";
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.Visible = false;
            // 
            // btnDetail
            // 
            this.btnDetail.BackColor = System.Drawing.Color.SlateGray;
            this.btnDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDetail.ForeColor = System.Drawing.Color.Gold;
            this.btnDetail.Location = new System.Drawing.Point(213, 657);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(77, 37);
            this.btnDetail.TabIndex = 13;
            this.btnDetail.Text = "Detail";
            this.btnDetail.UseVisualStyleBackColor = false;
            this.btnDetail.Visible = false;
            // 
            // chkFilter
            // 
            this.chkFilter.AutoSize = true;
            this.chkFilter.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkFilter.ForeColor = System.Drawing.Color.Yellow;
            this.chkFilter.Location = new System.Drawing.Point(9, 661);
            this.chkFilter.Name = "chkFilter";
            this.chkFilter.Size = new System.Drawing.Size(126, 20);
            this.chkFilter.TabIndex = 9;
            this.chkFilter.Text = "Filter Same";
            this.chkFilter.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.chkFilter);
            this.groupBox7.Controls.Add(this.btnDetail);
            this.groupBox7.Controls.Add(this.btnList);
            this.groupBox7.Controls.Add(this.bClear);
            this.groupBox7.Controls.Add(this.lInfo);
            this.groupBox7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox7.Location = new System.Drawing.Point(401, 12);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(380, 700);
            this.groupBox7.TabIndex = 7;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Opration Info.";
            // 
            // bEpcId
            // 
            this.bEpcId.BackColor = System.Drawing.Color.SlateGray;
            this.bEpcId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bEpcId.ForeColor = System.Drawing.Color.Gold;
            this.bEpcId.Location = new System.Drawing.Point(235, 25);
            this.bEpcId.Name = "bEpcId";
            this.bEpcId.Size = new System.Drawing.Size(90, 51);
            this.bEpcId.TabIndex = 5;
            this.bEpcId.Text = "Identify";
            this.bEpcId.UseVisualStyleBackColor = false;
            // 
            // bEpcRead
            // 
            this.bEpcRead.BackColor = System.Drawing.Color.SlateGray;
            this.bEpcRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bEpcRead.ForeColor = System.Drawing.Color.Gold;
            this.bEpcRead.Location = new System.Drawing.Point(235, 88);
            this.bEpcRead.Name = "bEpcRead";
            this.bEpcRead.Size = new System.Drawing.Size(90, 26);
            this.bEpcRead.TabIndex = 6;
            this.bEpcRead.Text = "Read";
            this.bEpcRead.UseVisualStyleBackColor = false;
            this.bEpcRead.Click += new System.EventHandler(this.bEpcRead_Click);
            // 
            // bEpcWrite
            // 
            this.bEpcWrite.BackColor = System.Drawing.Color.SlateGray;
            this.bEpcWrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bEpcWrite.ForeColor = System.Drawing.Color.Gold;
            this.bEpcWrite.Location = new System.Drawing.Point(235, 124);
            this.bEpcWrite.Name = "bEpcWrite";
            this.bEpcWrite.Size = new System.Drawing.Size(90, 26);
            this.bEpcWrite.TabIndex = 7;
            this.bEpcWrite.Text = "Write";
            this.bEpcWrite.UseVisualStyleBackColor = false;
            this.bEpcWrite.Click += new System.EventHandler(this.bEpcWrite_Click);
            // 
            // bEpcKill
            // 
            this.bEpcKill.BackColor = System.Drawing.Color.SlateGray;
            this.bEpcKill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bEpcKill.ForeColor = System.Drawing.Color.Gold;
            this.bEpcKill.Location = new System.Drawing.Point(235, 188);
            this.bEpcKill.Name = "bEpcKill";
            this.bEpcKill.Size = new System.Drawing.Size(90, 26);
            this.bEpcKill.TabIndex = 9;
            this.bEpcKill.Text = "Kill";
            this.bEpcKill.UseVisualStyleBackColor = false;
            // 
            // cEpcTimes
            // 
            this.cEpcTimes.FormattingEnabled = true;
            this.cEpcTimes.Items.AddRange(new object[] {
            "Continours",
            "1",
            "10",
            "100",
            "1000",
            "5000"});
            this.cEpcTimes.Location = new System.Drawing.Point(97, 86);
            this.cEpcTimes.Name = "cEpcTimes";
            this.cEpcTimes.Size = new System.Drawing.Size(87, 24);
            this.cEpcTimes.TabIndex = 14;
            // 
            // tEpcSpeed
            // 
            this.tEpcSpeed.Location = new System.Drawing.Point(71, 40);
            this.tEpcSpeed.Name = "tEpcSpeed";
            this.tEpcSpeed.Size = new System.Drawing.Size(155, 45);
            this.tEpcSpeed.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(16, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Speed";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(18, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "Times";
            // 
            // cEpcMembank
            // 
            this.cEpcMembank.FormattingEnabled = true;
            this.cEpcMembank.Items.AddRange(new object[] {
            "RESERVE",
            "EPC",
            "TID",
            "USER"});
            this.cEpcMembank.Location = new System.Drawing.Point(97, 125);
            this.cEpcMembank.Name = "cEpcMembank";
            this.cEpcMembank.Size = new System.Drawing.Size(87, 24);
            this.cEpcMembank.TabIndex = 18;
            // 
            // cEpcWordptr
            // 
            this.cEpcWordptr.FormattingEnabled = true;
            this.cEpcWordptr.Location = new System.Drawing.Point(97, 157);
            this.cEpcWordptr.Name = "cEpcWordptr";
            this.cEpcWordptr.Size = new System.Drawing.Size(87, 24);
            this.cEpcWordptr.TabIndex = 19;
            // 
            // cEpcWordcnt
            // 
            this.cEpcWordcnt.FormattingEnabled = true;
            this.cEpcWordcnt.Location = new System.Drawing.Point(97, 191);
            this.cEpcWordcnt.Name = "cEpcWordcnt";
            this.cEpcWordcnt.Size = new System.Drawing.Size(87, 24);
            this.cEpcWordcnt.TabIndex = 20;
            // 
            // tEpcData
            // 
            this.tEpcData.Location = new System.Drawing.Point(97, 221);
            this.tEpcData.Name = "tEpcData";
            this.tEpcData.Size = new System.Drawing.Size(125, 26);
            this.tEpcData.TabIndex = 21;
            this.tEpcData.TextChanged += new System.EventHandler(this.tEpcData_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(8, 160);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 16);
            this.label14.TabIndex = 22;
            this.label14.Text = "WordPtr";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(10, 195);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 16);
            this.label15.TabIndex = 24;
            this.label15.Text = "WordCnt";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(8, 125);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 16);
            this.label16.TabIndex = 25;
            this.label16.Text = "MemBank";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.Location = new System.Drawing.Point(10, 221);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(80, 16);
            this.label17.TabIndex = 26;
            this.label17.Text = "Data(Hex)";
            // 
            // bEpcInit
            // 
            this.bEpcInit.BackColor = System.Drawing.Color.SlateGray;
            this.bEpcInit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bEpcInit.ForeColor = System.Drawing.Color.Gold;
            this.bEpcInit.Location = new System.Drawing.Point(235, 156);
            this.bEpcInit.Name = "bEpcInit";
            this.bEpcInit.Size = new System.Drawing.Size(90, 26);
            this.bEpcInit.TabIndex = 29;
            this.bEpcInit.Text = "Init";
            this.bEpcInit.UseVisualStyleBackColor = false;
            this.bEpcInit.Click += new System.EventHandler(this.bEpcInit_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.bEpcInit);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.tEpcData);
            this.groupBox6.Controls.Add(this.cEpcWordcnt);
            this.groupBox6.Controls.Add(this.cEpcWordptr);
            this.groupBox6.Controls.Add(this.cEpcMembank);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.tEpcSpeed);
            this.groupBox6.Controls.Add(this.cEpcTimes);
            this.groupBox6.Controls.Add(this.bEpcKill);
            this.groupBox6.Controls.Add(this.bEpcWrite);
            this.groupBox6.Controls.Add(this.bEpcRead);
            this.groupBox6.Controls.Add(this.bEpcId);
            this.groupBox6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox6.Location = new System.Drawing.Point(12, 176);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(348, 260);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "ISO18000-6C(EPC G2)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(261, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1034, 733);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox7);
            this.Name = "Form1";
            this.Text = "UHF Reader Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tEpcSpeed)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bRs232Con;
        private System.Windows.Forms.ComboBox cBaudrate;
        private System.Windows.Forms.ComboBox cCommPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bRs232Discon;
        private System.Windows.Forms.ListBox lInfo;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.CheckBox chkFilter;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button bEpcId;
        private System.Windows.Forms.Button bEpcRead;
        private System.Windows.Forms.Button bEpcWrite;
        private System.Windows.Forms.Button bEpcKill;
        private System.Windows.Forms.ComboBox cEpcTimes;
        private System.Windows.Forms.TrackBar tEpcSpeed;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cEpcMembank;
        private System.Windows.Forms.ComboBox cEpcWordptr;
        private System.Windows.Forms.ComboBox cEpcWordcnt;
        private System.Windows.Forms.TextBox tEpcData;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button bEpcInit;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button button1;
    }
}

