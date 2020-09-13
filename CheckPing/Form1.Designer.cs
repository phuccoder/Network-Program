namespace CheckPing
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
            this.lvResult = new System.Windows.Forms.ListView();
            this.lvDetail = new System.Windows.Forms.ListView();
            this.lvThongke = new System.Windows.Forms.ListView();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btcheck = new System.Windows.Forms.Button();
            this.btreset = new System.Windows.Forms.Button();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumpacket = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chbxContinous = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvResult
            // 
            this.lvResult.Location = new System.Drawing.Point(32, 320);
            this.lvResult.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvResult.Name = "lvResult";
            this.lvResult.Size = new System.Drawing.Size(542, 99);
            this.lvResult.TabIndex = 0;
            this.lvResult.UseCompatibleStateImageBehavior = false;
            // 
            // lvDetail
            // 
            this.lvDetail.Location = new System.Drawing.Point(32, 33);
            this.lvDetail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvDetail.Name = "lvDetail";
            this.lvDetail.Size = new System.Drawing.Size(1499, 276);
            this.lvDetail.TabIndex = 1;
            this.lvDetail.UseCompatibleStateImageBehavior = false;
            // 
            // lvThongke
            // 
            this.lvThongke.Location = new System.Drawing.Point(620, 320);
            this.lvThongke.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvThongke.Name = "lvThongke";
            this.lvThongke.Size = new System.Drawing.Size(911, 98);
            this.lvThongke.TabIndex = 2;
            this.lvThongke.UseCompatibleStateImageBehavior = false;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(32, 492);
            this.txtInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(407, 26);
            this.txtInput.TabIndex = 3;
            // 
            // btcheck
            // 
            this.btcheck.Location = new System.Drawing.Point(165, 564);
            this.btcheck.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btcheck.Name = "btcheck";
            this.btcheck.Size = new System.Drawing.Size(84, 29);
            this.btcheck.TabIndex = 4;
            this.btcheck.Text = "ping";
            this.btcheck.UseVisualStyleBackColor = true;
            this.btcheck.Click += new System.EventHandler(this.btcheck_Click);
            // 
            // btreset
            // 
            this.btreset.Location = new System.Drawing.Point(294, 564);
            this.btreset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btreset.Name = "btreset";
            this.btreset.Size = new System.Drawing.Size(84, 29);
            this.btreset.TabIndex = 5;
            this.btreset.Text = "reset";
            this.btreset.UseVisualStyleBackColor = true;
            this.btreset.Click += new System.EventHandler(this.btreset_Click);
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(620, 492);
            this.txtSize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(162, 26);
            this.txtSize.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(628, 461);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "kich thuoc";
            // 
            // txtNumpacket
            // 
            this.txtNumpacket.Location = new System.Drawing.Point(866, 492);
            this.txtNumpacket.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNumpacket.Name = "txtNumpacket";
            this.txtNumpacket.Size = new System.Drawing.Size(131, 26);
            this.txtNumpacket.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(863, 461);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "so goi tin";
            // 
            // chbxContinous
            // 
            this.chbxContinous.AutoSize = true;
            this.chbxContinous.Location = new System.Drawing.Point(637, 564);
            this.chbxContinous.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chbxContinous.Name = "chbxContinous";
            this.chbxContinous.Size = new System.Drawing.Size(110, 24);
            this.chbxContinous.TabIndex = 9;
            this.chbxContinous.Text = "gui lien tuc";
            this.chbxContinous.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 461);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "ip hoac host";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1562, 668);
            this.Controls.Add(this.chbxContinous);
            this.Controls.Add(this.txtNumpacket);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.btreset);
            this.Controls.Add(this.btcheck);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lvThongke);
            this.Controls.Add(this.lvDetail);
            this.Controls.Add(this.lvResult);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvResult;
        private System.Windows.Forms.ListView lvDetail;
        private System.Windows.Forms.ListView lvThongke;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btcheck;
        private System.Windows.Forms.Button btreset;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumpacket;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chbxContinous;
        private System.Windows.Forms.Label label3;
    }
}

