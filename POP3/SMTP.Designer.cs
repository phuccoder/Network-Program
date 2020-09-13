namespace POP3
{
    partial class SMTP
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
            this.txtfrom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdexit = new System.Windows.Forms.Button();
            this.cmdattach = new System.Windows.Forms.Button();
            this.txtattach = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdsend = new System.Windows.Forms.Button();
            this.txtto = new System.Windows.Forms.TextBox();
            this.txtcc = new System.Windows.Forms.TextBox();
            this.txtsubject = new System.Windows.Forms.TextBox();
            this.txtbody = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblstatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtfrom
            // 
            this.txtfrom.Location = new System.Drawing.Point(161, 115);
            this.txtfrom.Name = "txtfrom";
            this.txtfrom.Size = new System.Drawing.Size(338, 29);
            this.txtfrom.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "from";
            // 
            // cmdexit
            // 
            this.cmdexit.Location = new System.Drawing.Point(615, 483);
            this.cmdexit.Name = "cmdexit";
            this.cmdexit.Size = new System.Drawing.Size(131, 65);
            this.cmdexit.TabIndex = 2;
            this.cmdexit.Text = "exit";
            this.cmdexit.UseVisualStyleBackColor = true;
            this.cmdexit.Click += new System.EventHandler(this.cmdexit_Click);
            // 
            // cmdattach
            // 
            this.cmdattach.Location = new System.Drawing.Point(615, 115);
            this.cmdattach.Name = "cmdattach";
            this.cmdattach.Size = new System.Drawing.Size(172, 72);
            this.cmdattach.TabIndex = 3;
            this.cmdattach.Text = "attach";
            this.cmdattach.UseVisualStyleBackColor = true;
            this.cmdattach.Click += new System.EventHandler(this.cmdattach_Click);
            // 
            // txtattach
            // 
            this.txtattach.Location = new System.Drawing.Point(161, 175);
            this.txtattach.Name = "txtattach";
            this.txtattach.Size = new System.Drawing.Size(338, 29);
            this.txtattach.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "attach";
            // 
            // cmdsend
            // 
            this.cmdsend.Location = new System.Drawing.Point(615, 236);
            this.cmdsend.Name = "cmdsend";
            this.cmdsend.Size = new System.Drawing.Size(172, 48);
            this.cmdsend.TabIndex = 5;
            this.cmdsend.Text = "send";
            this.cmdsend.UseVisualStyleBackColor = true;
            this.cmdsend.Click += new System.EventHandler(this.cmdsend_Click);
            // 
            // txtto
            // 
            this.txtto.Location = new System.Drawing.Point(161, 236);
            this.txtto.Name = "txtto";
            this.txtto.Size = new System.Drawing.Size(338, 29);
            this.txtto.TabIndex = 6;
            // 
            // txtcc
            // 
            this.txtcc.Location = new System.Drawing.Point(161, 305);
            this.txtcc.Name = "txtcc";
            this.txtcc.Size = new System.Drawing.Size(338, 29);
            this.txtcc.TabIndex = 7;
            // 
            // txtsubject
            // 
            this.txtsubject.Location = new System.Drawing.Point(161, 379);
            this.txtsubject.Name = "txtsubject";
            this.txtsubject.Size = new System.Drawing.Size(338, 29);
            this.txtsubject.TabIndex = 8;
            // 
            // txtbody
            // 
            this.txtbody.Location = new System.Drawing.Point(161, 449);
            this.txtbody.Name = "txtbody";
            this.txtbody.Size = new System.Drawing.Size(338, 29);
            this.txtbody.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "to";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "cc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 383);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "subject";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 453);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "body";
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Location = new System.Drawing.Point(156, 523);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(64, 25);
            this.lblstatus.TabIndex = 10;
            this.lblstatus.Text = "status";
            // 
            // SMTP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 583);
            this.Controls.Add(this.lblstatus);
            this.Controls.Add(this.txtbody);
            this.Controls.Add(this.txtsubject);
            this.Controls.Add(this.txtcc);
            this.Controls.Add(this.txtto);
            this.Controls.Add(this.cmdsend);
            this.Controls.Add(this.txtattach);
            this.Controls.Add(this.cmdattach);
            this.Controls.Add(this.cmdexit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtfrom);
            this.Name = "SMTP";
            this.Text = "SMTP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtfrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdexit;
        private System.Windows.Forms.Button cmdattach;
        private System.Windows.Forms.TextBox txtattach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdsend;
        private System.Windows.Forms.TextBox txtto;
        private System.Windows.Forms.TextBox txtcc;
        private System.Windows.Forms.TextBox txtsubject;
        private System.Windows.Forms.TextBox txtbody;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblstatus;
    }
}