namespace C5_BT2_Client
{
    partial class TcpChat
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
            this.newText = new System.Windows.Forms.TextBox();
            this.btnListen = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnCon = new System.Windows.Forms.Button();
            this.results = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "enter text string";
            // 
            // newText
            // 
            this.newText.Location = new System.Drawing.Point(75, 120);
            this.newText.Name = "newText";
            this.newText.Size = new System.Drawing.Size(348, 29);
            this.newText.TabIndex = 1;
            // 
            // btnListen
            // 
            this.btnListen.Location = new System.Drawing.Point(499, 41);
            this.btnListen.Name = "btnListen";
            this.btnListen.Size = new System.Drawing.Size(132, 53);
            this.btnListen.TabIndex = 2;
            this.btnListen.Text = "listen";
            this.btnListen.UseVisualStyleBackColor = true;
            this.btnListen.Click += new System.EventHandler(this.btnListen_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(499, 120);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(137, 53);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnCon
            // 
            this.btnCon.Location = new System.Drawing.Point(730, 87);
            this.btnCon.Name = "btnCon";
            this.btnCon.Size = new System.Drawing.Size(123, 53);
            this.btnCon.TabIndex = 4;
            this.btnCon.Text = "connect";
            this.btnCon.UseVisualStyleBackColor = true;
            this.btnCon.Click += new System.EventHandler(this.btnCon_Click);
            // 
            // results
            // 
            this.results.Location = new System.Drawing.Point(81, 273);
            this.results.Name = "results";
            this.results.Size = new System.Drawing.Size(625, 423);
            this.results.TabIndex = 5;
            this.results.UseCompatibleStateImageBehavior = false;
            // 
            // TcpChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 781);
            this.Controls.Add(this.results);
            this.Controls.Add(this.btnCon);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnListen);
            this.Controls.Add(this.newText);
            this.Controls.Add(this.label1);
            this.Name = "TcpChat";
            this.Text = "Form1";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TcpChat_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newText;
        private System.Windows.Forms.Button btnListen;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnCon;
        private System.Windows.Forms.ListView results;
    }
}

