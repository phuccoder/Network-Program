using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;

namespace chatclient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtIPServer.Focus();
            btnSend.Enabled = false;
        }
        TcpClient maykhach;
        StreamReader sr;
        StreamWriter sw;
        string readdata = null;

        private void btn_connect_Click(object sender, EventArgs e)
        {
            try
            {
                this.Text = "Nickname : " + txtUsername.Text;
                lstMessage.Enabled = true;
                IPEndPoint ipe = new IPEndPoint(IPAddress.Parse(txtIPServer.Text), 9050);
                maykhach = new TcpClient();
                maykhach.Connect(ipe);
                if (maykhach.Connected)
                {
                    Thread thguiusername = new Thread(new ThreadStart(guiusername));
                    thguiusername.Start();
                    Thread thnhandulieu = new Thread(new ThreadStart(nhandulieu));
                    thnhandulieu.Start();
                }
                else
                    MessageBox.Show("Lỗi kết nối bạn hãy kiểm tra lại");
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối bạn hãy kiểm tra lại");
                Application.Exit();
            }
        }
        private void guiusername()
        {
            sw = new StreamWriter(maykhach.GetStream());
            sw.WriteLine(txtUsername.Text);
            sw.Flush();
        }
        private void nhandulieu()
        {
            while (true)
            {
                sr = new StreamReader(maykhach.GetStream());
                string kq = sr.ReadLine();
                readdata = kq;
                msg();
            }
        }
        private void msg()
        {
            if (this.InvokeRequired)
                this.Invoke(new MethodInvoker(msg));
            else
                lstMessage.Items.Add(readdata);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            btnSend.Enabled = true;
            sw = new StreamWriter(maykhach.GetStream());
            sw.WriteLine(txtChat.Text);
            sw.Flush();
            txtChat.Clear();
            txtChat.Focus();
        }

        private void txtChat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSend.PerformClick();
            }
        }

        private void txtChat_KeyUp(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            if (e.KeyValue == 13)
            {
                txtChat.Clear();
                txtChat.Focus();
            }
        }

        private void txtChat_TextChanged(object sender, EventArgs e)
        {
            if (txtChat.Text == "")
                btnSend.Enabled = false;
            else
                btnSend.Enabled = true;

        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            sw.Close();
            sr.Close();
            maykhach.Close();
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_connect.PerformClick();
            }
        }
    }
}
