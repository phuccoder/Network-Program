namespace chatclient
{
    partial class Form1
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
            this.txtIPServer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.btn_connect = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lstMessage = new System.Windows.Forms.ListView();
            this.txtChat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtIPServer
            // 
            this.txtIPServer.Location = new System.Drawing.Point(245, 46);
            this.txtIPServer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIPServer.Name = "txtIPServer";
            this.txtIPServer.Size = new System.Drawing.Size(278, 26);
            this.txtIPServer.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ip server";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(545, 328);
            this.btnSend.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(84, 29);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(529, 45);
            this.btn_connect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(84, 29);
            this.btn_connect.TabIndex = 3;
            this.btn_connect.Text = "connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(245, 106);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(278, 26);
            this.txtUsername.TabIndex = 4;
            this.txtUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsername_KeyDown);
            // 
            // lstMessage
            // 
            this.lstMessage.Location = new System.Drawing.Point(245, 140);
            this.lstMessage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstMessage.Name = "lstMessage";
            this.lstMessage.Size = new System.Drawing.Size(278, 159);
            this.lstMessage.TabIndex = 5;
            this.lstMessage.UseCompatibleStateImageBehavior = false;
            // 
            // txtChat
            // 
            this.txtChat.Location = new System.Drawing.Point(245, 329);
            this.txtChat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtChat.Name = "txtChat";
            this.txtChat.Size = new System.Drawing.Size(278, 26);
            this.txtChat.TabIndex = 6;
            this.txtChat.TextChanged += new System.EventHandler(this.txtChat_TextChanged);
            this.txtChat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtChat_KeyDown);
            this.txtChat.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtChat_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "user";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(619, 45);
            this.btnDisconnect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(142, 29);
            this.btnDisconnect.TabIndex = 8;
            this.btnDisconnect.Text = "disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 393);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtChat);
            this.Controls.Add(this.lstMessage);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIPServer);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIPServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.ListView lstMessage;
        private System.Windows.Forms.TextBox txtChat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDisconnect;
    }
}

