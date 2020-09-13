namespace POP3
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
            this.lstmail = new System.Windows.Forms.ListView();
            this.cmdexit = new System.Windows.Forms.Button();
            this.cmdlogin = new System.Windows.Forms.Button();
            this.lblstatus = new System.Windows.Forms.Label();
            this.txtserver = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.cmdsend = new System.Windows.Forms.Button();
            this.lblfrom = new System.Windows.Forms.Label();
            this.lblto = new System.Windows.Forms.Label();
            this.lblsubject = new System.Windows.Forms.Label();
            this.txtbody = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstmail
            // 
            this.lstmail.Location = new System.Drawing.Point(339, 310);
            this.lstmail.Name = "lstmail";
            this.lstmail.Size = new System.Drawing.Size(699, 306);
            this.lstmail.TabIndex = 0;
            this.lstmail.UseCompatibleStateImageBehavior = false;
            this.lstmail.SelectedIndexChanged += new System.EventHandler(this.lstmail_SelectedIndexChanged);
            // 
            // cmdexit
            // 
            this.cmdexit.Location = new System.Drawing.Point(874, 195);
            this.cmdexit.Name = "cmdexit";
            this.cmdexit.Size = new System.Drawing.Size(164, 29);
            this.cmdexit.TabIndex = 1;
            this.cmdexit.Text = "exit";
            this.cmdexit.UseVisualStyleBackColor = true;
            this.cmdexit.Click += new System.EventHandler(this.cmdexit_Click);
            // 
            // cmdlogin
            // 
            this.cmdlogin.Location = new System.Drawing.Point(874, 74);
            this.cmdlogin.Name = "cmdlogin";
            this.cmdlogin.Size = new System.Drawing.Size(164, 46);
            this.cmdlogin.TabIndex = 2;
            this.cmdlogin.Text = "login";
            this.cmdlogin.UseVisualStyleBackColor = true;
            this.cmdlogin.Click += new System.EventHandler(this.cmdlogin_Click);
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Location = new System.Drawing.Point(334, 264);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(64, 25);
            this.lblstatus.TabIndex = 3;
            this.lblstatus.Text = "status";
            // 
            // txtserver
            // 
            this.txtserver.Location = new System.Drawing.Point(460, 74);
            this.txtserver.Name = "txtserver";
            this.txtserver.Size = new System.Drawing.Size(344, 29);
            this.txtserver.TabIndex = 4;
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(460, 132);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(344, 29);
            this.txtusername.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(334, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(334, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "pass";
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(460, 195);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(344, 29);
            this.txtpassword.TabIndex = 7;
            // 
            // cmdsend
            // 
            this.cmdsend.Location = new System.Drawing.Point(874, 132);
            this.cmdsend.Name = "cmdsend";
            this.cmdsend.Size = new System.Drawing.Size(164, 46);
            this.cmdsend.TabIndex = 8;
            this.cmdsend.Text = "send";
            this.cmdsend.UseVisualStyleBackColor = true;
            this.cmdsend.Click += new System.EventHandler(this.cmdsend_Click);
            // 
            // lblfrom
            // 
            this.lblfrom.AutoSize = true;
            this.lblfrom.Location = new System.Drawing.Point(334, 673);
            this.lblfrom.Name = "lblfrom";
            this.lblfrom.Size = new System.Drawing.Size(50, 25);
            this.lblfrom.TabIndex = 9;
            this.lblfrom.Text = "from";
            // 
            // lblto
            // 
            this.lblto.AutoSize = true;
            this.lblto.Location = new System.Drawing.Point(334, 748);
            this.lblto.Name = "lblto";
            this.lblto.Size = new System.Drawing.Size(28, 25);
            this.lblto.TabIndex = 9;
            this.lblto.Text = "to";
            // 
            // lblsubject
            // 
            this.lblsubject.AutoSize = true;
            this.lblsubject.Location = new System.Drawing.Point(334, 819);
            this.lblsubject.Name = "lblsubject";
            this.lblsubject.Size = new System.Drawing.Size(74, 25);
            this.lblsubject.TabIndex = 9;
            this.lblsubject.Text = "subject";
            // 
            // txtbody
            // 
            this.txtbody.Location = new System.Drawing.Point(513, 884);
            this.txtbody.Name = "txtbody";
            this.txtbody.Size = new System.Drawing.Size(525, 29);
            this.txtbody.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(334, 884);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "body";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1439, 999);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbody);
            this.Controls.Add(this.lblsubject);
            this.Controls.Add(this.lblto);
            this.Controls.Add(this.lblfrom);
            this.Controls.Add(this.cmdsend);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.txtserver);
            this.Controls.Add(this.lblstatus);
            this.Controls.Add(this.cmdlogin);
            this.Controls.Add(this.cmdexit);
            this.Controls.Add(this.lstmail);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstmail;
        private System.Windows.Forms.Button cmdexit;
        private System.Windows.Forms.Button cmdlogin;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.TextBox txtserver;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button cmdsend;
        private System.Windows.Forms.Label lblfrom;
        private System.Windows.Forms.Label lblto;
        private System.Windows.Forms.Label lblsubject;
        private System.Windows.Forms.TextBox txtbody;
        private System.Windows.Forms.Label label4;
    }
}

