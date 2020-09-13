using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace POP3
{
    public partial class Form1 : Form
    {
        public string server;
        public string username;

        public Form1()
        {
            InitializeComponent();
            ColumnHeader header1 = lstmail.Columns.Add("No.", 5 *
            Convert.ToInt32(lstmail.Font.SizeInPoints), HorizontalAlignment.Center);
            ColumnHeader header2 = lstmail.Columns.Add("From", 20 *
            Convert.ToInt32(lstmail.Font.SizeInPoints), HorizontalAlignment.Center);
            ColumnHeader header3 = lstmail.Columns.Add("To", 20 *
            Convert.ToInt32(lstmail.Font.SizeInPoints), HorizontalAlignment.Center);
            ColumnHeader header4 = lstmail.Columns.Add("Subject", 20 *
            Convert.ToInt32(lstmail.Font.SizeInPoints), HorizontalAlignment.Left);
            ColumnHeader header5 = lstmail.Columns.Add("Date", 20 *
            Convert.ToInt32(lstmail.Font.SizeInPoints), HorizontalAlignment.Left);
        }

        private void cmdexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private TcpClient mailclient;
        private NetworkStream ns;
        private StreamReader sr;
        private StreamWriter sw;

        private void cmdlogin_Click(object sender, EventArgs e)
        {
            lblstatus.Text = "Status: Checking for messages...";
            Thread startlogin = new Thread(new ThreadStart(loginandretr));
            startlogin.IsBackground = true;
            startlogin.Start();
            server = txtserver.Text;
            username = txtusername.Text;
        }
        void loginandretr()
        {
            string response;
            string from = "";

            string to = "";
            string subject = "";
            string date = "";
            int totmessages;
            try
            {
                mailclient = new TcpClient(txtserver.Text, 110);
            }
            catch (SocketException)
            {
                lblstatus.Text = "Status: Unable to connect to server";
                return;
            }
            ns = mailclient.GetStream();
            sr = new StreamReader(ns);
            sw = new StreamWriter(ns);
            response = sr.ReadLine(); //Get opening POP3 banner
            sw.WriteLine("User " + txtusername.Text); //Send username
            sw.Flush();
            response = sr.ReadLine();
            if (response.Substring(0, 3) == "-ER")
            {
                lblstatus.Text = "Status: Unable to log into server";
                return;
            }
            sw.WriteLine("Pass " + txtpassword.Text); //Send password
            sw.Flush();
            try
            {
                response = sr.ReadLine();
            }
            catch (IOException)
            {
                lblstatus.Text = "Status: Unable to log into server";
                return;
            }
            if (response.Substring(0, 4) == "-ERR")
            {
                lblstatus.Text = "Status: Unable to log into server";
                return;
            }
            sw.WriteLine("stat"); //Send stat command to get number of messages
            sw.Flush();
            response = sr.ReadLine();
            string[] nummess = response.Split(' ');
            totmessages = Convert.ToInt16(nummess[1]);
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
            if (totmessages > 0)
            {
                lblstatus.Text = "Status: you have " + totmessages + " messages";
            }
            else
            {
                lblstatus.Text = "Status: You have no messages";
            }
            for (int i = 1; i <= totmessages; i++)
            {

                sw.WriteLine("top " + i + " 0"); //read header of each message
                sw.Flush();
                response = sr.ReadLine();
                while (true)
                {
                    response = sr.ReadLine();
                    if (response == ".")

                        break;
                    if (response.Length > 4)
                    {

                        if (response.Substring(0, 5) == "From:")
                            from = response;
                        if (response.Substring(0, 3) == "To:")
                            to = response;
                        if (response.Substring(0, 8) == "Subject:")
                            subject = response;
                        if (response.Substring(0, 5) == "Date:")
                            date = response;
                    }
                }

                if (from != "")
                {
                    string[] myItems = new string[]

                    {i+"",
                    from + " ",
                    to + " " ,
                    subject + "",
                    date+""
                    };

                    ListViewItem lvi = new ListViewItem(myItems);
                    lstmail.Items.Add(lvi);
                }

            }
        }

        private void cmdsend_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            SMTP f2 = new SMTP(txtserver.Text, txtusername.Text);
            f2.Show();
        }

        private void lstmail_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem lstItem = lstmail.SelectedItems[0];
            lblfrom.Text = lstItem.SubItems[1].Text;
            lblto.Text = lstItem.SubItems[2].Text;
            lblsubject.Text = lstItem.SubItems[3].Text;
            ShowMessage(lstItem.Text);
        }
        public void ShowMessage(string messnumber)
        {
            StreamReader sr = new StreamReader(ns);
            StreamWriter sw = new StreamWriter(ns);
            string response;
            sw.WriteLine("retr " + messnumber); //Retrieve entire message
            sw.Flush();
            response = sr.ReadLine();
            while (true)
            {
                response = sr.ReadLine();
                if (response == ".")
                    break;

                txtbody.Text += response + "\r\n";

            }
        }
    }
}
