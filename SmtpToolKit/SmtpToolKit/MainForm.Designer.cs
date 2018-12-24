namespace SmtpToolKit
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvCC = new System.Windows.Forms.DataGridView();
            this.nudPort = new System.Windows.Forms.NumericUpDown();
            this.lblErrEmailBody = new System.Windows.Forms.Label();
            this.lblErrEmailTo = new System.Windows.Forms.Label();
            this.lblErrEmailFrom = new System.Windows.Forms.Label();
            this.lblErrPort = new System.Windows.Forms.Label();
            this.lblErrSMTP = new System.Windows.Forms.Label();
            this.txtEmailBody = new System.Windows.Forms.RichTextBox();
            this.gbxCredentials = new System.Windows.Forms.GroupBox();
            this.lblErrPassword = new System.Windows.Forms.Label();
            this.lblErrUsername = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmailTo = new System.Windows.Forms.TextBox();
            this.txtEmailFrom = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkAuthentication = new System.Windows.Forms.CheckBox();
            this.chkSSL = new System.Windows.Forms.CheckBox();
            this.txtSmtpServer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvBCC = new System.Windows.Forms.DataGridView();
            this.btnAddBCC = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.colBccEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBccRemove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colCcEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCcRemove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAddCC = new System.Windows.Forms.Button();
            this.btnSendEmail = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPort)).BeginInit();
            this.gbxCredentials.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBCC)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.dgvBCC);
            this.panel1.Controls.Add(this.btnAddBCC);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.dgvCC);
            this.panel1.Controls.Add(this.nudPort);
            this.panel1.Controls.Add(this.lblErrEmailBody);
            this.panel1.Controls.Add(this.lblErrEmailTo);
            this.panel1.Controls.Add(this.lblErrEmailFrom);
            this.panel1.Controls.Add(this.lblErrPort);
            this.panel1.Controls.Add(this.lblErrSMTP);
            this.panel1.Controls.Add(this.btnAddCC);
            this.panel1.Controls.Add(this.btnSendEmail);
            this.panel1.Controls.Add(this.txtEmailBody);
            this.panel1.Controls.Add(this.gbxCredentials);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtEmailTo);
            this.panel1.Controls.Add(this.txtEmailFrom);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.chkAuthentication);
            this.panel1.Controls.Add(this.chkSSL);
            this.panel1.Controls.Add(this.txtSmtpServer);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(16, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 642);
            this.panel1.TabIndex = 0;
            // 
            // dgvCC
            // 
            this.dgvCC.AllowUserToAddRows = false;
            this.dgvCC.AllowUserToDeleteRows = false;
            this.dgvCC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCC.BackgroundColor = System.Drawing.Color.White;
            this.dgvCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCC.ColumnHeadersVisible = false;
            this.dgvCC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCcEmail,
            this.colCcRemove});
            this.dgvCC.Location = new System.Drawing.Point(3, 265);
            this.dgvCC.Name = "dgvCC";
            this.dgvCC.ReadOnly = true;
            this.dgvCC.RowHeadersVisible = false;
            this.dgvCC.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.dgvCC.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvCC.Size = new System.Drawing.Size(218, 88);
            this.dgvCC.TabIndex = 36;
            this.dgvCC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCC_CellContentClick);
            // 
            // nudPort
            // 
            this.nudPort.Location = new System.Drawing.Point(425, 24);
            this.nudPort.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudPort.Name = "nudPort";
            this.nudPort.Size = new System.Drawing.Size(78, 23);
            this.nudPort.TabIndex = 17;
            this.nudPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudPort.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // lblErrEmailBody
            // 
            this.lblErrEmailBody.AutoSize = true;
            this.lblErrEmailBody.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrEmailBody.ForeColor = System.Drawing.Color.Red;
            this.lblErrEmailBody.Location = new System.Drawing.Point(6, 599);
            this.lblErrEmailBody.Name = "lblErrEmailBody";
            this.lblErrEmailBody.Size = new System.Drawing.Size(44, 12);
            this.lblErrEmailBody.TabIndex = 34;
            this.lblErrEmailBody.Text = "Required";
            this.lblErrEmailBody.Visible = false;
            // 
            // lblErrEmailTo
            // 
            this.lblErrEmailTo.AutoSize = true;
            this.lblErrEmailTo.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrEmailTo.ForeColor = System.Drawing.Color.Red;
            this.lblErrEmailTo.Location = new System.Drawing.Point(291, 215);
            this.lblErrEmailTo.Name = "lblErrEmailTo";
            this.lblErrEmailTo.Size = new System.Drawing.Size(44, 12);
            this.lblErrEmailTo.TabIndex = 33;
            this.lblErrEmailTo.Text = "Required";
            this.lblErrEmailTo.Visible = false;
            // 
            // lblErrEmailFrom
            // 
            this.lblErrEmailFrom.AutoSize = true;
            this.lblErrEmailFrom.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrEmailFrom.ForeColor = System.Drawing.Color.Red;
            this.lblErrEmailFrom.Location = new System.Drawing.Point(7, 215);
            this.lblErrEmailFrom.Name = "lblErrEmailFrom";
            this.lblErrEmailFrom.Size = new System.Drawing.Size(44, 12);
            this.lblErrEmailFrom.TabIndex = 32;
            this.lblErrEmailFrom.Text = "Required";
            this.lblErrEmailFrom.Visible = false;
            // 
            // lblErrPort
            // 
            this.lblErrPort.AutoSize = true;
            this.lblErrPort.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrPort.ForeColor = System.Drawing.Color.Red;
            this.lblErrPort.Location = new System.Drawing.Point(444, 50);
            this.lblErrPort.Name = "lblErrPort";
            this.lblErrPort.Size = new System.Drawing.Size(44, 12);
            this.lblErrPort.TabIndex = 31;
            this.lblErrPort.Text = "Required";
            this.lblErrPort.Visible = false;
            // 
            // lblErrSMTP
            // 
            this.lblErrSMTP.AutoSize = true;
            this.lblErrSMTP.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrSMTP.ForeColor = System.Drawing.Color.Red;
            this.lblErrSMTP.Location = new System.Drawing.Point(7, 50);
            this.lblErrSMTP.Name = "lblErrSMTP";
            this.lblErrSMTP.Size = new System.Drawing.Size(44, 12);
            this.lblErrSMTP.TabIndex = 35;
            this.lblErrSMTP.Text = "Required";
            this.lblErrSMTP.Visible = false;
            // 
            // txtEmailBody
            // 
            this.txtEmailBody.Location = new System.Drawing.Point(3, 395);
            this.txtEmailBody.Name = "txtEmailBody";
            this.txtEmailBody.Size = new System.Drawing.Size(502, 204);
            this.txtEmailBody.TabIndex = 27;
            this.txtEmailBody.Text = "";
            // 
            // gbxCredentials
            // 
            this.gbxCredentials.Controls.Add(this.lblErrPassword);
            this.gbxCredentials.Controls.Add(this.lblErrUsername);
            this.gbxCredentials.Controls.Add(this.label6);
            this.gbxCredentials.Controls.Add(this.txtPassword);
            this.gbxCredentials.Controls.Add(this.label5);
            this.gbxCredentials.Controls.Add(this.txtUsername);
            this.gbxCredentials.Location = new System.Drawing.Point(155, 68);
            this.gbxCredentials.Name = "gbxCredentials";
            this.gbxCredentials.Size = new System.Drawing.Size(344, 82);
            this.gbxCredentials.TabIndex = 30;
            this.gbxCredentials.TabStop = false;
            this.gbxCredentials.Text = "Credentails";
            this.gbxCredentials.Visible = false;
            // 
            // lblErrPassword
            // 
            this.lblErrPassword.AutoSize = true;
            this.lblErrPassword.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrPassword.ForeColor = System.Drawing.Color.Red;
            this.lblErrPassword.Location = new System.Drawing.Point(184, 63);
            this.lblErrPassword.Name = "lblErrPassword";
            this.lblErrPassword.Size = new System.Drawing.Size(44, 12);
            this.lblErrPassword.TabIndex = 13;
            this.lblErrPassword.Text = "Required";
            this.lblErrPassword.Visible = false;
            // 
            // lblErrUsername
            // 
            this.lblErrUsername.AutoSize = true;
            this.lblErrUsername.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrUsername.ForeColor = System.Drawing.Color.Red;
            this.lblErrUsername.Location = new System.Drawing.Point(25, 63);
            this.lblErrUsername.Name = "lblErrUsername";
            this.lblErrUsername.Size = new System.Drawing.Size(44, 12);
            this.lblErrUsername.TabIndex = 13;
            this.lblErrUsername.Text = "Required";
            this.lblErrUsername.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(270, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(183, 38);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(146, 23);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 19);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Email / Username";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(24, 38);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(146, 23);
            this.txtUsername.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(453, 171);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "Email To";
            // 
            // txtEmailTo
            // 
            this.txtEmailTo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailTo.Location = new System.Drawing.Point(286, 190);
            this.txtEmailTo.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmailTo.Name = "txtEmailTo";
            this.txtEmailTo.Size = new System.Drawing.Size(217, 23);
            this.txtEmailTo.TabIndex = 25;
            // 
            // txtEmailFrom
            // 
            this.txtEmailFrom.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailFrom.Location = new System.Drawing.Point(4, 190);
            this.txtEmailFrom.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmailFrom.Name = "txtEmailFrom";
            this.txtEmailFrom.Size = new System.Drawing.Size(217, 23);
            this.txtEmailFrom.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 375);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 26;
            this.label7.Text = "Email Body";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1, 244);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 15);
            this.label8.TabIndex = 23;
            this.label8.Text = "CC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 171);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "Email From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(474, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Port";
            // 
            // chkAuthentication
            // 
            this.chkAuthentication.AutoSize = true;
            this.chkAuthentication.Location = new System.Drawing.Point(4, 77);
            this.chkAuthentication.Margin = new System.Windows.Forms.Padding(4);
            this.chkAuthentication.Name = "chkAuthentication";
            this.chkAuthentication.Size = new System.Drawing.Size(105, 19);
            this.chkAuthentication.TabIndex = 18;
            this.chkAuthentication.Text = "Authentication";
            this.chkAuthentication.UseVisualStyleBackColor = true;
            this.chkAuthentication.Click += new System.EventHandler(this.chkAuthentication_CheckedChanged);
            // 
            // chkSSL
            // 
            this.chkSSL.AutoSize = true;
            this.chkSSL.Location = new System.Drawing.Point(4, 127);
            this.chkSSL.Margin = new System.Windows.Forms.Padding(4);
            this.chkSSL.Name = "chkSSL";
            this.chkSSL.Size = new System.Drawing.Size(66, 19);
            this.chkSSL.TabIndex = 19;
            this.chkSSL.Text = "Use SSL";
            this.chkSSL.UseVisualStyleBackColor = true;
            // 
            // txtSmtpServer
            // 
            this.txtSmtpServer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSmtpServer.Location = new System.Drawing.Point(4, 25);
            this.txtSmtpServer.Margin = new System.Windows.Forms.Padding(4);
            this.txtSmtpServer.Name = "txtSmtpServer";
            this.txtSmtpServer.Size = new System.Drawing.Size(329, 23);
            this.txtSmtpServer.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "SMTP Sever";
            // 
            // dgvBCC
            // 
            this.dgvBCC.AllowUserToAddRows = false;
            this.dgvBCC.AllowUserToDeleteRows = false;
            this.dgvBCC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBCC.BackgroundColor = System.Drawing.Color.White;
            this.dgvBCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBCC.ColumnHeadersVisible = false;
            this.dgvBCC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBccEmail,
            this.colBccRemove});
            this.dgvBCC.Location = new System.Drawing.Point(285, 265);
            this.dgvBCC.Name = "dgvBCC";
            this.dgvBCC.ReadOnly = true;
            this.dgvBCC.RowHeadersVisible = false;
            this.dgvBCC.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.dgvBCC.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvBCC.Size = new System.Drawing.Size(218, 88);
            this.dgvBCC.TabIndex = 39;
            this.dgvBCC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBCC_CellContentClick);
            // 
            // btnAddBCC
            // 
            this.btnAddBCC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddBCC.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBCC.Image = global::SmtpToolKit.Properties.Resources.add;
            this.btnAddBCC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddBCC.Location = new System.Drawing.Point(448, 236);
            this.btnAddBCC.Name = "btnAddBCC";
            this.btnAddBCC.Size = new System.Drawing.Size(55, 26);
            this.btnAddBCC.TabIndex = 38;
            this.btnAddBCC.Text = "Add";
            this.btnAddBCC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddBCC.UseVisualStyleBackColor = true;
            this.btnAddBCC.Click += new System.EventHandler(this.btnAddBCC_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(283, 244);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 15);
            this.label9.TabIndex = 37;
            this.label9.Text = "BCC";
            // 
            // colBccEmail
            // 
            this.colBccEmail.HeaderText = "Email";
            this.colBccEmail.Name = "colBccEmail";
            this.colBccEmail.ReadOnly = true;
            // 
            // colBccRemove
            // 
            this.colBccRemove.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colBccRemove.FillWeight = 80F;
            this.colBccRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colBccRemove.HeaderText = "X";
            this.colBccRemove.Name = "colBccRemove";
            this.colBccRemove.ReadOnly = true;
            this.colBccRemove.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colBccRemove.Text = "X";
            this.colBccRemove.UseColumnTextForButtonValue = true;
            this.colBccRemove.Width = 15;
            // 
            // colCcEmail
            // 
            this.colCcEmail.HeaderText = "Email";
            this.colCcEmail.Name = "colCcEmail";
            this.colCcEmail.ReadOnly = true;
            // 
            // colCcRemove
            // 
            this.colCcRemove.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colCcRemove.FillWeight = 80F;
            this.colCcRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colCcRemove.HeaderText = "X";
            this.colCcRemove.Name = "colCcRemove";
            this.colCcRemove.ReadOnly = true;
            this.colCcRemove.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colCcRemove.Text = "X";
            this.colCcRemove.UseColumnTextForButtonValue = true;
            this.colCcRemove.Width = 15;
            // 
            // btnAddCC
            // 
            this.btnAddCC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCC.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCC.Image = global::SmtpToolKit.Properties.Resources.add;
            this.btnAddCC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCC.Location = new System.Drawing.Point(166, 236);
            this.btnAddCC.Name = "btnAddCC";
            this.btnAddCC.Size = new System.Drawing.Size(55, 26);
            this.btnAddCC.TabIndex = 28;
            this.btnAddCC.Text = "Add";
            this.btnAddCC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddCC.UseVisualStyleBackColor = true;
            this.btnAddCC.Click += new System.EventHandler(this.btnAddCC_Click);
            // 
            // btnSendEmail
            // 
            this.btnSendEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSendEmail.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendEmail.Image = global::SmtpToolKit.Properties.Resources.send;
            this.btnSendEmail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSendEmail.Location = new System.Drawing.Point(434, 605);
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.Size = new System.Drawing.Size(65, 30);
            this.btnSendEmail.TabIndex = 29;
            this.btnSendEmail.Text = "Send";
            this.btnSendEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSendEmail.UseVisualStyleBackColor = true;
            this.btnSendEmail.Click += new System.EventHandler(this.btnSendEmail_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 661);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(500, 700);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SMTP Toolkit";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPort)).EndInit();
            this.gbxCredentials.ResumeLayout(false);
            this.gbxCredentials.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBCC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvCC;
        private System.Windows.Forms.NumericUpDown nudPort;
        private System.Windows.Forms.Label lblErrEmailBody;
        private System.Windows.Forms.Label lblErrEmailTo;
        private System.Windows.Forms.Label lblErrEmailFrom;
        private System.Windows.Forms.Label lblErrPort;
        private System.Windows.Forms.Label lblErrSMTP;
        private System.Windows.Forms.Button btnAddCC;
        private System.Windows.Forms.Button btnSendEmail;
        private System.Windows.Forms.RichTextBox txtEmailBody;
        private System.Windows.Forms.GroupBox gbxCredentials;
        private System.Windows.Forms.Label lblErrPassword;
        private System.Windows.Forms.Label lblErrUsername;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmailTo;
        private System.Windows.Forms.TextBox txtEmailFrom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkAuthentication;
        private System.Windows.Forms.CheckBox chkSSL;
        private System.Windows.Forms.TextBox txtSmtpServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvBCC;
        private System.Windows.Forms.Button btnAddBCC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBccEmail;
        private System.Windows.Forms.DataGridViewButtonColumn colBccRemove;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCcEmail;
        private System.Windows.Forms.DataGridViewButtonColumn colCcRemove;
    }
}

