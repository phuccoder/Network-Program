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
namespace UdpClientMsg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public delegate void ShowMessage(string Message);
        public void Show(string Message)
        {
            if (lstReceive.InvokeRequired)
            {
                ShowMessage message = new ShowMessage(Show);
                lstReceive.Invoke(message, new object[] { Message });
                return;
            }
            lstReceive.Items.Add(Message);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtIP.Text.Trim().Length == 0)
            MessageBox.Show("Vui lòng nhập vào địa chỉ IP!");
             else
             {
                 UdpClient udpClient = new UdpClient();
                 udpClient.Connect(txtIP.Text, int.Parse(txtPort.Text));
                 if (txtIP.Text.Trim().Length == 0)
                 txtIP.Text = "Bạn hãy nhập vào thông điệp ...";
                 else
                 {
                     Byte[] sendBytes = Encoding.Unicode.GetBytes(txtIP.Text);
                     udpClient.Send(sendBytes, sendBytes.Length);
                    IPEndPoint remote = new IPEndPoint(IPAddress.Parse(txtIP.Text), int.Parse(txtPort.Text));
                     Byte[] receivedBytes = udpClient.Receive(ref remote);
                     string message = Encoding.Unicode.GetString(receivedBytes);
                     Show("Nhận thông điệp từ -> " + remote.Address.ToString() + " : " + message);
                     txtIP.Text = "";
                }
             }
        }


        private void lstReceive_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstReceive.SelectedItem != null)
                txtResult.Text = lstReceive.SelectedItem.ToString();
        }

        private void txtMessage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                button1_Click(sender, e);
        }
    }
}
