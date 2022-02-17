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
            this.lblIpAddress = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIpAddress = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtQMName = new System.Windows.Forms.TextBox();
            this.txtQName = new System.Windows.Forms.TextBox();
            this.txtCName = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.lblUserId = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGetMessage = new System.Windows.Forms.Button();
            this.btnPutMessage = new System.Windows.Forms.Button();
            this.txtPutMessage = new System.Windows.Forms.TextBox();
            this.lblConnectStstus = new System.Windows.Forms.Label();
            this.txtGetMessage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblIpAddress
            // 
            this.lblIpAddress.AutoSize = true;
            this.lblIpAddress.Location = new System.Drawing.Point(137, 28);
            this.lblIpAddress.Name = "lblIpAddress";
            this.lblIpAddress.Size = new System.Drawing.Size(85, 13);
            this.lblIpAddress.TabIndex = 2;
            this.lblIpAddress.Text = "Ip Address(Host)";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(196, 53);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(26, 13);
            this.lblPort.TabIndex = 3;
            this.lblPort.Text = "Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Queue manager name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Queue name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Channel name";
            // 
            // txtIpAddress
            // 
            this.txtIpAddress.Location = new System.Drawing.Point(254, 24);
            this.txtIpAddress.Name = "txtIpAddress";
            this.txtIpAddress.Size = new System.Drawing.Size(281, 20);
            this.txtIpAddress.TabIndex = 7;
            this.txtIpAddress.Text = "127.0.0.1";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(254, 49);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(281, 20);
            this.txtPort.TabIndex = 8;
            this.txtPort.Text = "1421";
            // 
            // txtQMName
            // 
            this.txtQMName.Location = new System.Drawing.Point(254, 74);
            this.txtQMName.Name = "txtQMName";
            this.txtQMName.Size = new System.Drawing.Size(281, 20);
            this.txtQMName.TabIndex = 9;
            this.txtQMName.Text = "QM_TEST";
            // 
            // txtQName
            // 
            this.txtQName.Location = new System.Drawing.Point(254, 99);
            this.txtQName.Name = "txtQName";
            this.txtQName.Size = new System.Drawing.Size(281, 20);
            this.txtQName.TabIndex = 10;
            this.txtQName.Text = "QM_TEST.LOCAL.ONE";
            // 
            // txtCName
            // 
            this.txtCName.Location = new System.Drawing.Point(254, 124);
            this.txtCName.Name = "txtCName";
            this.txtCName.Size = new System.Drawing.Size(281, 20);
            this.txtCName.TabIndex = 11;
            this.txtCName.Text = "QM_TEST.SVRCONN";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(254, 210);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(112, 23);
            this.btnConnect.TabIndex = 12;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.Connect);
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(254, 149);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(281, 20);
            this.txtUserID.TabIndex = 14;
            this.txtUserID.Text = "SLTESTUSER";
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Location = new System.Drawing.Point(181, 153);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(41, 13);
            this.lblUserId.TabIndex = 13;
            this.lblUserId.Text = "User Id";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(254, 175);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(281, 20);
            this.txtPassword.TabIndex = 16;
            this.txtPassword.Text = "12345678";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(169, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Password";
            // 
            // btnGetMessage
            // 
            this.btnGetMessage.Enabled = false;
            this.btnGetMessage.Location = new System.Drawing.Point(110, 395);
            this.btnGetMessage.Name = "btnGetMessage";
            this.btnGetMessage.Size = new System.Drawing.Size(112, 23);
            this.btnGetMessage.TabIndex = 19;
            this.btnGetMessage.Text = "Get message";
            this.btnGetMessage.UseVisualStyleBackColor = true;
            this.btnGetMessage.Click += new System.EventHandler(this.GetMessage);
            // 
            // btnPutMessage
            // 
            this.btnPutMessage.Enabled = false;
            this.btnPutMessage.Location = new System.Drawing.Point(110, 249);
            this.btnPutMessage.Name = "btnPutMessage";
            this.btnPutMessage.Size = new System.Drawing.Size(112, 23);
            this.btnPutMessage.TabIndex = 21;
            this.btnPutMessage.Text = "Put message";
            this.btnPutMessage.UseVisualStyleBackColor = true;
            this.btnPutMessage.Click += new System.EventHandler(this.PutMessage);
            // 
            // txtPutMessage
            // 
            this.txtPutMessage.Location = new System.Drawing.Point(254, 249);
            this.txtPutMessage.Multiline = true;
            this.txtPutMessage.Name = "txtPutMessage";
            this.txtPutMessage.ReadOnly = true;
            this.txtPutMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPutMessage.Size = new System.Drawing.Size(633, 130);
            this.txtPutMessage.TabIndex = 22;
            // 
            // lblConnectStstus
            // 
            this.lblConnectStstus.AutoSize = true;
            this.lblConnectStstus.ForeColor = System.Drawing.Color.Red;
            this.lblConnectStstus.Location = new System.Drawing.Point(384, 215);
            this.lblConnectStstus.Name = "lblConnectStstus";
            this.lblConnectStstus.Size = new System.Drawing.Size(78, 13);
            this.lblConnectStstus.TabIndex = 23;
            this.lblConnectStstus.Text = "Not connected";
            // 
            // txtGetMessage
            // 
            this.txtGetMessage.Location = new System.Drawing.Point(254, 395);
            this.txtGetMessage.Multiline = true;
            this.txtGetMessage.Name = "txtGetMessage";
            this.txtGetMessage.ReadOnly = true;
            this.txtGetMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtGetMessage.Size = new System.Drawing.Size(633, 130);
            this.txtGetMessage.TabIndex = 24;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 544);
            this.Controls.Add(this.txtGetMessage);
            this.Controls.Add(this.lblConnectStstus);
            this.Controls.Add(this.txtPutMessage);
            this.Controls.Add(this.btnPutMessage);
            this.Controls.Add(this.btnGetMessage);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.lblUserId);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtCName);
            this.Controls.Add(this.txtQName);
            this.Controls.Add(this.txtQMName);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtIpAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.lblIpAddress);
            this.Name = "Home";
            this.Text = "IMB MQ Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblIpAddress;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIpAddress;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtQMName;
        private System.Windows.Forms.TextBox txtQName;
        private System.Windows.Forms.TextBox txtCName;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGetMessage;
        private System.Windows.Forms.Button btnPutMessage;
        private System.Windows.Forms.TextBox txtPutMessage;
        private System.Windows.Forms.Label lblConnectStstus;
        private System.Windows.Forms.TextBox txtGetMessage;
    }
}

