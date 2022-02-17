namespace IBMMQ.Client
{
    partial class Home
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtGetMessage = new System.Windows.Forms.TextBox();
            this.txtPutMessage = new System.Windows.Forms.TextBox();
            this.btnPutMessage = new System.Windows.Forms.Button();
            this.btnGetMessage = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblConnectStstus = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.lblUserId = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtCName = new System.Windows.Forms.TextBox();
            this.txtQName = new System.Windows.Forms.TextBox();
            this.txtQMName = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtIpAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblIpAddress = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1020, 552);
            this.panel1.TabIndex = 27;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.txtGetMessage);
            this.groupBox2.Controls.Add(this.txtPutMessage);
            this.groupBox2.Controls.Add(this.btnPutMessage);
            this.groupBox2.Controls.Add(this.btnGetMessage);
            this.groupBox2.Location = new System.Drawing.Point(32, 240);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(957, 307);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Message details";
            // 
            // txtGetMessage
            // 
            this.txtGetMessage.Location = new System.Drawing.Point(146, 166);
            this.txtGetMessage.Multiline = true;
            this.txtGetMessage.Name = "txtGetMessage";
            this.txtGetMessage.ReadOnly = true;
            this.txtGetMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtGetMessage.Size = new System.Drawing.Size(633, 130);
            this.txtGetMessage.TabIndex = 28;
            // 
            // txtPutMessage
            // 
            this.txtPutMessage.Location = new System.Drawing.Point(146, 20);
            this.txtPutMessage.Multiline = true;
            this.txtPutMessage.Name = "txtPutMessage";
            this.txtPutMessage.ReadOnly = true;
            this.txtPutMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPutMessage.Size = new System.Drawing.Size(633, 130);
            this.txtPutMessage.TabIndex = 27;
            // 
            // btnPutMessage
            // 
            this.btnPutMessage.Enabled = false;
            this.btnPutMessage.Location = new System.Drawing.Point(9, 20);
            this.btnPutMessage.Name = "btnPutMessage";
            this.btnPutMessage.Size = new System.Drawing.Size(112, 23);
            this.btnPutMessage.TabIndex = 26;
            this.btnPutMessage.Text = "Put message";
            this.btnPutMessage.UseVisualStyleBackColor = true;
            this.btnPutMessage.MouseCaptureChanged += new System.EventHandler(this.PutMessage);
            // 
            // btnGetMessage
            // 
            this.btnGetMessage.Enabled = false;
            this.btnGetMessage.Location = new System.Drawing.Point(9, 166);
            this.btnGetMessage.Name = "btnGetMessage";
            this.btnGetMessage.Size = new System.Drawing.Size(112, 23);
            this.btnGetMessage.TabIndex = 25;
            this.btnGetMessage.Text = "Get message";
            this.btnGetMessage.UseVisualStyleBackColor = true;
            this.btnGetMessage.MouseCaptureChanged += new System.EventHandler(this.GetMessage);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.lblConnectStstus);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtUserID);
            this.groupBox1.Controls.Add(this.lblUserId);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.txtCName);
            this.groupBox1.Controls.Add(this.txtQName);
            this.groupBox1.Controls.Add(this.txtQMName);
            this.groupBox1.Controls.Add(this.txtPort);
            this.groupBox1.Controls.Add(this.txtIpAddress);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblPort);
            this.groupBox1.Controls.Add(this.lblIpAddress);
            this.groupBox1.Location = new System.Drawing.Point(32, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(957, 231);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection details";
            // 
            // lblConnectStstus
            // 
            this.lblConnectStstus.AutoSize = true;
            this.lblConnectStstus.ForeColor = System.Drawing.Color.Red;
            this.lblConnectStstus.Location = new System.Drawing.Point(339, 193);
            this.lblConnectStstus.Name = "lblConnectStstus";
            this.lblConnectStstus.Size = new System.Drawing.Size(78, 13);
            this.lblConnectStstus.TabIndex = 39;
            this.lblConnectStstus.Text = "Not connected";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(209, 162);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(281, 20);
            this.txtPassword.TabIndex = 38;
            this.txtPassword.Text = "12345678";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(124, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Password";
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(209, 136);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(281, 20);
            this.txtUserID.TabIndex = 36;
            this.txtUserID.Text = "SLTESTUSER";
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Location = new System.Drawing.Point(136, 140);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(41, 13);
            this.lblUserId.TabIndex = 35;
            this.lblUserId.Text = "User Id";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(209, 188);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(112, 23);
            this.btnConnect.TabIndex = 34;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.Connect);
            // 
            // txtCName
            // 
            this.txtCName.Location = new System.Drawing.Point(209, 111);
            this.txtCName.Name = "txtCName";
            this.txtCName.Size = new System.Drawing.Size(281, 20);
            this.txtCName.TabIndex = 33;
            this.txtCName.Text = "QM_TEST.SVRCONN";
            // 
            // txtQName
            // 
            this.txtQName.Location = new System.Drawing.Point(209, 86);
            this.txtQName.Name = "txtQName";
            this.txtQName.Size = new System.Drawing.Size(281, 20);
            this.txtQName.TabIndex = 32;
            this.txtQName.Text = "QM_TEST.LOCAL.ONE";
            // 
            // txtQMName
            // 
            this.txtQMName.Location = new System.Drawing.Point(209, 61);
            this.txtQMName.Name = "txtQMName";
            this.txtQMName.Size = new System.Drawing.Size(281, 20);
            this.txtQMName.TabIndex = 31;
            this.txtQMName.Text = "QM_TEST";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(209, 36);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(281, 20);
            this.txtPort.TabIndex = 30;
            this.txtPort.Text = "1421";
            // 
            // txtIpAddress
            // 
            this.txtIpAddress.Location = new System.Drawing.Point(209, 11);
            this.txtIpAddress.Name = "txtIpAddress";
            this.txtIpAddress.Size = new System.Drawing.Size(281, 20);
            this.txtIpAddress.TabIndex = 29;
            this.txtIpAddress.Text = "127.0.0.1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Channel name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Queue name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Queue manager name";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(151, 40);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(26, 13);
            this.lblPort.TabIndex = 25;
            this.lblPort.Text = "Port";
            // 
            // lblIpAddress
            // 
            this.lblIpAddress.AutoSize = true;
            this.lblIpAddress.Location = new System.Drawing.Point(92, 15);
            this.lblIpAddress.Name = "lblIpAddress";
            this.lblIpAddress.Size = new System.Drawing.Size(86, 13);
            this.lblIpAddress.TabIndex = 24;
            this.lblIpAddress.Text = "IP Address(Host)";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 576);
            this.Controls.Add(this.panel1);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IMB MQ Manager";
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtGetMessage;
        private System.Windows.Forms.TextBox txtPutMessage;
        private System.Windows.Forms.Button btnPutMessage;
        private System.Windows.Forms.Button btnGetMessage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblConnectStstus;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtCName;
        private System.Windows.Forms.TextBox txtQName;
        private System.Windows.Forms.TextBox txtQMName;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtIpAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label lblIpAddress;
    }
}

