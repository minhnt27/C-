namespace ZKtecoControl
{
    partial class AttLogsMain
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
            this.components = new System.ComponentModel.Container();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblState = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lvLogs = new System.Windows.Forms.ListView();
            this.lvLogsch1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvLogsch2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvLogsch3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvLogsch4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvLogsch5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvLogsch6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvLogsch7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnGetGeneralLogData = new System.Windows.Forms.Button();
            this.lvCard = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnGetStrCardNumber = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.btnSetStrCardNumber = new System.Windows.Forms.Button();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.chbEnabled = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label89 = new System.Windows.Forms.Label();
            this.cbPrivilege = new System.Windows.Forms.ComboBox();
            this.txtCardnumber = new System.Windows.Forms.TextBox();
            this.Privilege = new System.Windows.Forms.Label();
            this.label90 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbdbver = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(73, 23);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(127, 20);
            this.txtIP.TabIndex = 0;
            this.txtIP.Text = "192.168.0.120";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(9, 57);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(90, 23);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(6, 94);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(138, 13);
            this.lblState.TabIndex = 2;
            this.lblState.Text = "Current State:Disconnected";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(317, 23);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(68, 20);
            this.txtPort.TabIndex = 3;
            this.txtPort.Text = "4370";
            // 
            // lvLogs
            // 
            this.lvLogs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvLogsch1,
            this.lvLogsch2,
            this.lvLogsch3,
            this.lvLogsch4,
            this.lvLogsch5,
            this.lvLogsch6,
            this.lvLogsch7});
            this.lvLogs.GridLines = true;
            this.lvLogs.Location = new System.Drawing.Point(14, 23);
            this.lvLogs.Name = "lvLogs";
            this.lvLogs.Size = new System.Drawing.Size(574, 172);
            this.lvLogs.TabIndex = 4;
            this.lvLogs.UseCompatibleStateImageBehavior = false;
            this.lvLogs.View = System.Windows.Forms.View.Details;
            // 
            // lvLogsch1
            // 
            this.lvLogsch1.Text = "Count";
            // 
            // lvLogsch2
            // 
            this.lvLogsch2.Text = "EnrollNumber";
            // 
            // lvLogsch3
            // 
            this.lvLogsch3.Text = "VerifyMode";
            this.lvLogsch3.Width = 106;
            // 
            // lvLogsch4
            // 
            this.lvLogsch4.Text = "InOutMode";
            this.lvLogsch4.Width = 80;
            // 
            // lvLogsch5
            // 
            this.lvLogsch5.Text = "Date";
            this.lvLogsch5.Width = 72;
            // 
            // lvLogsch6
            // 
            this.lvLogsch6.Text = "WorkCode";
            this.lvLogsch6.Width = 87;
            // 
            // lvLogsch7
            // 
            this.lvLogsch7.Text = "Reserved";
            this.lvLogsch7.Width = 158;
            // 
            // btnGetGeneralLogData
            // 
            this.btnGetGeneralLogData.Location = new System.Drawing.Point(14, 201);
            this.btnGetGeneralLogData.Name = "btnGetGeneralLogData";
            this.btnGetGeneralLogData.Size = new System.Drawing.Size(112, 23);
            this.btnGetGeneralLogData.TabIndex = 5;
            this.btnGetGeneralLogData.Text = "DownloadAttLogs";
            this.btnGetGeneralLogData.UseVisualStyleBackColor = true;
            this.btnGetGeneralLogData.Click += new System.EventHandler(this.btnGetGeneralLogData_Click);
            // 
            // lvCard
            // 
            this.lvCard.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvCard.GridLines = true;
            this.lvCard.Location = new System.Drawing.Point(10, 19);
            this.lvCard.Name = "lvCard";
            this.lvCard.Size = new System.Drawing.Size(453, 136);
            this.lvCard.TabIndex = 46;
            this.lvCard.UseCompatibleStateImageBehavior = false;
            this.lvCard.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "UserID";
            this.columnHeader1.Width = 54;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 41;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Cardnumber";
            this.columnHeader3.Width = 78;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Privilege";
            this.columnHeader4.Width = 92;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Password";
            this.columnHeader5.Width = 76;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Enabled";
            this.columnHeader6.Width = 84;
            // 
            // btnGetStrCardNumber
            // 
            this.btnGetStrCardNumber.Location = new System.Drawing.Point(10, 161);
            this.btnGetStrCardNumber.Name = "btnGetStrCardNumber";
            this.btnGetStrCardNumber.Size = new System.Drawing.Size(117, 23);
            this.btnGetStrCardNumber.TabIndex = 47;
            this.btnGetStrCardNumber.Text = "GetStrCardNumber";
            this.btnGetStrCardNumber.UseVisualStyleBackColor = true;
            this.btnGetStrCardNumber.Click += new System.EventHandler(this.btnGetStrCardNumber_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.label55);
            this.groupBox5.Controls.Add(this.btnSetStrCardNumber);
            this.groupBox5.Location = new System.Drawing.Point(15, 349);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(479, 111);
            this.groupBox5.TabIndex = 48;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Upload the Card Number(part of users information)";
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(196, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(36, 17);
            this.label15.TabIndex = 64;
            this.label15.Text = "Name";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(166, 56);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(66, 13);
            this.label55.TabIndex = 66;
            this.label55.Text = "CardNumber";
            // 
            // btnSetStrCardNumber
            // 
            this.btnSetStrCardNumber.Location = new System.Drawing.Point(12, 78);
            this.btnSetStrCardNumber.Name = "btnSetStrCardNumber";
            this.btnSetStrCardNumber.Size = new System.Drawing.Size(117, 23);
            this.btnSetStrCardNumber.TabIndex = 0;
            this.btnSetStrCardNumber.Text = "SetStrCardNumber";
            this.btnSetStrCardNumber.UseVisualStyleBackColor = true;
            this.btnSetStrCardNumber.Click += new System.EventHandler(this.btnSetStrCardNumber_Click);
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(105, 369);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(69, 20);
            this.txtUserID.TabIndex = 56;
            this.txtUserID.TextChanged += new System.EventHandler(this.txtUserID_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(253, 369);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(76, 20);
            this.txtName.TabIndex = 57;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(55, 373);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 18);
            this.label16.TabIndex = 63;
            this.label16.Text = "User ID";
            // 
            // chbEnabled
            // 
            this.chbEnabled.AutoSize = true;
            this.chbEnabled.Location = new System.Drawing.Point(398, 404);
            this.chbEnabled.Name = "chbEnabled";
            this.chbEnabled.Size = new System.Drawing.Size(15, 14);
            this.chbEnabled.TabIndex = 69;
            this.chbEnabled.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(398, 369);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(67, 20);
            this.txtPassword.TabIndex = 58;
            // 
            // label89
            // 
            this.label89.AutoSize = true;
            this.label89.Location = new System.Drawing.Point(347, 405);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(52, 13);
            this.label89.TabIndex = 67;
            this.label89.Text = "Enabled  ";
            // 
            // cbPrivilege
            // 
            this.cbPrivilege.FormattingEnabled = true;
            this.cbPrivilege.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.cbPrivilege.Location = new System.Drawing.Point(105, 400);
            this.cbPrivilege.Name = "cbPrivilege";
            this.cbPrivilege.Size = new System.Drawing.Size(69, 21);
            this.cbPrivilege.TabIndex = 59;
            // 
            // txtCardnumber
            // 
            this.txtCardnumber.Location = new System.Drawing.Point(253, 401);
            this.txtCardnumber.Name = "txtCardnumber";
            this.txtCardnumber.Size = new System.Drawing.Size(76, 20);
            this.txtCardnumber.TabIndex = 61;
            // 
            // Privilege
            // 
            this.Privilege.Location = new System.Drawing.Point(45, 404);
            this.Privilege.Name = "Privilege";
            this.Privilege.Size = new System.Drawing.Size(61, 19);
            this.Privilege.TabIndex = 65;
            this.Privilege.Text = "Privilege";
            // 
            // label90
            // 
            this.label90.AutoSize = true;
            this.label90.Location = new System.Drawing.Point(342, 374);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(53, 13);
            this.label90.TabIndex = 68;
            this.label90.Text = "Password";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPort);
            this.groupBox1.Controls.Add(this.lblState);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.txtIP);
            this.groupBox1.Location = new System.Drawing.Point(18, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 110);
            this.groupBox1.TabIndex = 70;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Port";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "IP Address";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvCard);
            this.groupBox2.Controls.Add(this.btnGetStrCardNumber);
            this.groupBox2.Location = new System.Drawing.Point(17, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(475, 198);
            this.groupBox2.TabIndex = 71;
            this.groupBox2.TabStop = false;
            this.groupBox2.Tag = "";
            this.groupBox2.Text = "Download the Card Number";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnGetGeneralLogData);
            this.groupBox3.Controls.Add(this.lvLogs);
            this.groupBox3.Location = new System.Drawing.Point(509, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(599, 235);
            this.groupBox3.TabIndex = 72;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Log checkin";
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(523, 334);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(574, 116);
            this.txtLog.TabIndex = 73;
            this.txtLog.Text = "the App have not yet connected to the Acs";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbdbver
            // 
            this.lbdbver.AutoSize = true;
            this.lbdbver.Location = new System.Drawing.Point(11, 16);
            this.lbdbver.Name = "lbdbver";
            this.lbdbver.Size = new System.Drawing.Size(78, 13);
            this.lbdbver.TabIndex = 74;
            this.lbdbver.Text = "Not connected";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbdbver);
            this.groupBox4.Location = new System.Drawing.Point(509, 249);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(599, 211);
            this.groupBox4.TabIndex = 75;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Automation Log";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // AttLogsMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 471);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.chbEnabled);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label89);
            this.Controls.Add(this.cbPrivilege);
            this.Controls.Add(this.txtCardnumber);
            this.Controls.Add(this.Privilege);
            this.Controls.Add(this.label90);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Name = "AttLogsMain";
            this.Text = "Tool to ZKTeco Access";
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.ListView lvLogs;
        private System.Windows.Forms.ColumnHeader lvLogsch1;
        private System.Windows.Forms.ColumnHeader lvLogsch2;
        private System.Windows.Forms.ColumnHeader lvLogsch3;
        private System.Windows.Forms.ColumnHeader lvLogsch4;
        private System.Windows.Forms.ColumnHeader lvLogsch5;
        private System.Windows.Forms.ColumnHeader lvLogsch6;
        private System.Windows.Forms.ColumnHeader lvLogsch7;
        private System.Windows.Forms.Button btnGetGeneralLogData;
        private System.Windows.Forms.ListView lvCard;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnGetStrCardNumber;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox chbEnabled;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnSetStrCardNumber;
        private System.Windows.Forms.Label label89;
        private System.Windows.Forms.ComboBox cbPrivilege;
        private System.Windows.Forms.TextBox txtCardnumber;
        private System.Windows.Forms.Label Privilege;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label90;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbdbver;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

