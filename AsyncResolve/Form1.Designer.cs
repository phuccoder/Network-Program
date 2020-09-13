namespace AsyncResolve
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
            this.results = new System.Windows.Forms.ListBox();
            this.btnResolve = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // results
            // 
            this.results.FormattingEnabled = true;
            this.results.ItemHeight = 24;
            this.results.Location = new System.Drawing.Point(369, 349);
            this.results.Name = "results";
            this.results.Size = new System.Drawing.Size(356, 244);
            this.results.TabIndex = 10;
            // 
            // btnResolve
            // 
            this.btnResolve.Location = new System.Drawing.Point(789, 233);
            this.btnResolve.Name = "btnResolve";
            this.btnResolve.Size = new System.Drawing.Size(120, 54);
            this.btnResolve.TabIndex = 9;
            this.btnResolve.Text = "Resolve";
            this.btnResolve.UseVisualStyleBackColor = true;
            this.btnResolve.Click += new System.EventHandler(this.btnResolve_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Phân giải";
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(369, 245);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(356, 29);
            this.address.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Địa chỉ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 827);
            this.Controls.Add(this.results);
            this.Controls.Add(this.btnResolve);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.address);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox results;
        private System.Windows.Forms.Button btnResolve;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label label1;
    }
}

