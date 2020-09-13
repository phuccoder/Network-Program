using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.IO;
using System.Threading;

namespace SrvTcpMsgClnt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public delegate void ShowMessage(string Message_);
        public void Show(string Message_)
        {
            if (lstReceive.InvokeRequired)
            {
                ShowMessage message = new ShowMessage(Show);
                lstReceive.Invoke(message, new object[] { Message_ });
                return;
            }
            lstReceive.Items.Add(Message_);
        }
        TcpClient tcpClient;
        StreamReader reader;
        StreamWriter writer;

        private void button1_Click(object sender, EventArgs e)
        {
            tcpClient = new TcpClient();
            tcpClient.Connect(txtIP.Text, int.Parse(txtPort.Text));
            writer = new StreamWriter(tcpClient.GetStream());
            writer.WriteLine(txtMessage.Text);
            writer.Flush();
            new Thread(new ThreadStart(ReceiveMessage)).Start();
        }
        private void ReceiveMessage()
        {
            reader = new StreamReader(tcpClient.GetStream());
            string strReturn = reader.ReadLine();
            if (strReturn.Trim().Length > 0)
                Show("Thông điệp từ Server : " + strReturn);
        }

        private void txtMessage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                button1_Click(sender, e);
        }

        private void lstReceive_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstReceive.SelectedItem != null)
                txtResult.Text = lstReceive.SelectedItem.ToString();
        }
    }
}
