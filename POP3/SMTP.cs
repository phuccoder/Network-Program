using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Web.Mail;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace POP3
{
    public partial class SMTP : Form
    {
        public string f2server;
        public string f2username;
        Form1 server = new Form1();

        public SMTP(string server, string username)
        {
            InitializeComponent();
            f2server = server;
            f2username = username;
            txtfrom.Text = username;
        }

        private void cmdexit_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void cmdattach_Click(object sender, EventArgs e)
        {
            string dir;
            OpenFileDialog op = new OpenFileDialog();
            op.ShowDialog();
            dir = op.FileName;
            txtattach.Text = dir;
        }

        private void cmdsend_Click(object sender, EventArgs e)
        {
            MailAttachment myattach = new MailAttachment(txtattach.Text, MailEncoding.Base64);
            MailMessage newmessage = new MailMessage();
            newmessage.From = txtfrom.Text;
            newmessage.To = txtto.Text;
            if (txtcc.Text != "")
            {
                newmessage.Cc = txtcc.Text;
            }
            newmessage.Subject = txtsubject.Text;
            newmessage.Priority = MailPriority.High;
            newmessage.Attachments.Add(myattach);
            newmessage.Body = txtbody.Text;
            try
            {
                SmtpMail.SmtpServer = f2server;
                SmtpMail.Send(newmessage);
                lblstatus.Text = "Send mail successful!";
            }
            catch (System.Web.HttpException)
            {
                lblstatus.Text = "Error send mail !!!";
            }
            txtto.Text = "";
            txtcc.Text = "";
            txtattach.Text = "";
            txtsubject.Text = "";
            txtbody.Text = "";
        }
    }
}
