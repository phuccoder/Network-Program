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

namespace ControlClientForm
{
    public partial class Form1 : Form
    {
        const int PORT = 9050;
        const int BUFF = 10000;
        TcpClient client;
        byte[] readbuff = new byte[BUFF];

        public Form1()
        {
            InitializeComponent();
        }
        void SendData(string data)
        {
            lock (client.GetStream())
            {
                StreamWriter sw = new StreamWriter(client.GetStream());
                sw.Write(data + (char)13);
                sw.Flush();
            }
        }
        private void ProcessCommand(string message)
        {
            string[] DataArr;
            DataArr = message.Split('+');
            switch (DataArr[0])
                {
                    case "THONGBAO":
                    {
                        if (MessageBox.Show("Programs : \r" + DataArr[2] + "is running on server. Continue ?", "Warning", 
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
                        {
                            if (DataArr[1] == "SHUTDOWN-F")
                                SendData("SHUTDOWN+YES+OK");
                            if (DataArr[1] == "SHUTDOWN")
                                SendData("SHUTDOWN+NO+OK");
                            if (DataArr[1] == "RESTART-F")
                                SendData("RESTART+YES+OK");
                            if (DataArr[1] == "RESTART")
                                SendData("RESTART+NO+OK");
                            if (DataArr[1] == "LOCK")
                                SendData("LOCK+NO+OK");
                            if (DataArr[1] == "LOGOFF")
                                SendData("LOGOFF+NO+OK");
                        }
                    break;
                }
            }
        }
        void DoRead(IAsyncResult ar)
        {
            int byteRead;
            string message;
            try
            {
                byteRead = client.GetStream().EndRead(ar);
                if (byteRead < 1)
                {
                    return;
                }
                message = Encoding.ASCII.GetString(readbuff, 0, byteRead - 2);
                ProcessCommand(message);
                client.GetStream().BeginRead(readbuff, 0, BUFF, new AsyncCallback(DoRead), null);
            }
            catch (Exception e)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtIP.Text == "")
            {
                MessageBox.Show("Input IP Address Please");
                return;
            }
            try
            {
                client = new TcpClient(txtIP.Text, PORT);
                client.GetStream().BeginRead(readbuff, 0, BUFF, new
                AsyncCallback(DoRead), null);
                MessageBox.Show("Sucessful!");
                btConnect.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Can not connect to server!");
                this.Dispose();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (client == null)
            {
                MessageBox.Show("First, connect to server!");
            }
            else
                SendData("LOCK+YES+");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (client == null)
            {
                MessageBox.Show("First, connect to server !");
            }
            else
                SendData("LOGOFF+YES+");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (client == null)
            {

                MessageBox.Show("First, connect to server");
            }
            else
            {
                if (checkBox1.Checked == true)
                {
                    SendData("RESTART+YES+");
                }
                else
                {
                    SendData("RESTART+NO+");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (client == null)
            {
                MessageBox.Show("First, connect to server!");
            }
            else
            {
                if (checkBox1.Checked == true)
                {
                    SendData("SHUTDOWN+YES+");
                }
                else
                {
                    SendData("SHUTDOWN+NO+");
                }
            }
        }
    }
}
