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
            this.label1 = new System.Windows.Forms.Label();
            this.lblConnectionStatus = new System.Windows.Forms.Label();
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.lblUserId = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtConnectionStatus = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnGetMessage = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtPutMessage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(254, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Connection Status";
            // 
            // lblConnectionStatus
            // 
            this.lblConnectionStatus.AutoSize = true;
            this.lblConnectionStatus.Location = new System.Drawing.Point(379, 258);
            this.lblConnectionStatus.Name = "lblConnectionStatus";
            this.lblConnectionStatus.Size = new System.Drawing.Size(78, 13);
            this.lblConnectionStatus.TabIndex = 1;
            this.lblConnectionStatus.Text = "Not connected";
            this.lblConnectionStatus.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblIpAddress
            // 
            this.lblIpAddress.AutoSize = true;
            this.lblIpAddress.Location = new System.Drawing.Point(137, 66);
            this.lblIpAddress.Name = "lblIpAddress";
            this.lblIpAddress.Size = new System.Drawing.Size(85, 13);
            this.lblIpAddress.TabIndex = 2;
            this.lblIpAddress.Text = "Ip Address(Host)";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(196, 91);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(26, 13);
            this.lblPort.TabIndex = 3;
            this.lblPort.Text = "Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Queue manager name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Queue name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Channel name";
            // 
            // txtIpAddress
            // 
            this.txtIpAddress.Location = new System.Drawing.Point(254, 62);
            this.txtIpAddress.Name = "txtIpAddress";
            this.txtIpAddress.Size = new System.Drawing.Size(281, 20);
            this.txtIpAddress.TabIndex = 7;
            this.txtIpAddress.Text = "127.0.0.1";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(254, 87);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(281, 20);
            this.txtPort.TabIndex = 8;
            this.txtPort.Text = "1421";
            // 
            // txtQMName
            // 
            this.txtQMName.Location = new System.Drawing.Point(254, 112);
            this.txtQMName.Name = "txtQMName";
            this.txtQMName.Size = new System.Drawing.Size(281, 20);
            this.txtQMName.TabIndex = 9;
            this.txtQMName.Text = "QM_TEST";
            // 
            // txtQName
            // 
            this.txtQName.Location = new System.Drawing.Point(254, 137);
            this.txtQName.Name = "txtQName";
            this.txtQName.Size = new System.Drawing.Size(281, 20);
            this.txtQName.TabIndex = 10;
            this.txtQName.Text = "QM_TEST.LOCAL.ONE";
            // 
            // txtCName
            // 
            this.txtCName.Location = new System.Drawing.Point(254, 162);
            this.txtCName.Name = "txtCName";
            this.txtCName.Size = new System.Drawing.Size(281, 20);
            this.txtCName.TabIndex = 11;
            this.txtCName.Text = "QM_TEST.SVRCONN/TCP/DESKTOP-8CH23R4(1421)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(110, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Connect);
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(254, 187);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(281, 20);
            this.txtUserID.TabIndex = 14;
            this.txtUserID.Text = "testMq";
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Location = new System.Drawing.Point(181, 191);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(41, 13);
            this.lblUserId.TabIndex = 13;
            this.lblUserId.Text = "User Id";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(254, 213);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(281, 20);
            this.txtPassword.TabIndex = 16;
            this.txtPassword.Text = "12345678";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(169, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Password";
            // 
            // txtConnectionStatus
            // 
            this.txtConnectionStatus.Location = new System.Drawing.Point(379, 284);
            this.txtConnectionStatus.Name = "txtConnectionStatus";
            this.txtConnectionStatus.Size = new System.Drawing.Size(156, 20);
            this.txtConnectionStatus.TabIndex = 17;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(251, 339);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(50, 13);
            this.lblMessage.TabIndex = 18;
            this.lblMessage.Text = "Message";
            // 
            // btnGetMessage
            // 
            this.btnGetMessage.Location = new System.Drawing.Point(110, 334);
            this.btnGetMessage.Name = "btnGetMessage";
            this.btnGetMessage.Size = new System.Drawing.Size(112, 23);
            this.btnGetMessage.TabIndex = 19;
            this.btnGetMessage.Text = "Get message";
            this.btnGetMessage.UseVisualStyleBackColor = true;
            this.btnGetMessage.Click += new System.EventHandler(this.btnGetMessage_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(110, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "Put message";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtPutMessage
            // 
            this.txtPutMessage.Location = new System.Drawing.Point(254, 415);
            this.txtPutMessage.Name = "txtPutMessage";
            this.txtPutMessage.Size = new System.Drawing.Size(156, 20);
            this.txtPutMessage.TabIndex = 22;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 450);
            this.Controls.Add(this.txtPutMessage);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnGetMessage);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.txtConnectionStatus);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.lblUserId);
            this.Controls.Add(this.button1);
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
            this.Controls.Add(this.lblConnectionStatus);
            this.Controls.Add(this.label1);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblConnectionStatus;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtConnectionStatus;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnGetMessage;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtPutMessage;
    }
}

