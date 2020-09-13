namespace C5_BT1
{
    partial class AcSyncTcpSrv
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
            this.button1 = new System.Windows.Forms.Button();
            this.results = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.conStatus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "receive from client";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(377, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 48);
            this.button1.TabIndex = 1;
            this.button1.Text = "stop srv";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // results
            // 
            this.results.Location = new System.Drawing.Point(165, 189);
            this.results.Name = "results";
            this.results.Size = new System.Drawing.Size(573, 366);
            this.results.TabIndex = 2;
            this.results.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 638);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "connect status";
            // 
            // conStatus
            // 
            this.conStatus.Location = new System.Drawing.Point(266, 634);
            this.conStatus.Name = "conStatus";
            this.conStatus.Size = new System.Drawing.Size(351, 29);
            this.conStatus.TabIndex = 3;
            // 
            // AcSyncTcpSrv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 790);
            this.Controls.Add(this.conStatus);
            this.Controls.Add(this.results);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AcSyncTcpSrv";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView results;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox conStatus;
    }
}

