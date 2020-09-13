using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net.Sockets;
using System.Net;
using System.Collections;
using System.IO;
using System.ComponentModel;
using System.Data;

namespace chatserver
{
    class Program
    {
        public static Hashtable clientsList = new Hashtable();

        static void Main(string[] args)
        {
            Console.WriteLine("---SERVER CHAT---\n");
            IPEndPoint ipe = new IPEndPoint(IPAddress.Any, 9050);
            TcpListener maychu = new TcpListener(ipe);
            TcpClient maykhach = default(TcpClient);
            int counter = 0;
            maychu.Start();
            while (true)
            {
                counter = counter + 1;
                maykhach = maychu.AcceptTcpClient();
                StreamReader srUsername = new StreamReader(maykhach.GetStream());
                string dataclient = srUsername.ReadLine();
                clientsList.Add(dataclient, maykhach);
                broadcast(dataclient + " Online", dataclient, false);
                Console.WriteLine(dataclient + " Joined chat");
                handleClient client = new handleClient();
                client.startClient(maykhach, dataclient, clientsList);
            }
            maychu.Stop();
            maykhach.Close();
            Console.ReadLine();
        }
        public static void broadcast(string msg, string uName, bool flag)
        {
            foreach (DictionaryEntry Item in clientsList)
            {
                TcpClient broadcastSocket;
                broadcastSocket = (TcpClient)Item.Value;
                StreamWriter swMessage = new StreamWriter(broadcastSocket.GetStream());
                string data = null;
                if (flag == true)
                    data = uName + ": " + msg;
                else
                    data = msg;
                swMessage.WriteLine(data);
                swMessage.Flush();
            }
        }
        public class handleClient
        {
            TcpClient maykhach;
            string clNo;
            Hashtable clientsList;
            int requestCount = 0;
            string rCount = null;
            public void startClient(TcpClient inClientSocket, string clineNo, Hashtable cList)
            {
                this.maykhach = inClientSocket;
                this.clNo = clineNo;
                this.clientsList = cList;
                Thread ctThread = new Thread(new ThreadStart(doChat));
                ctThread.Start();
            }
            private void doChat()
            {
                while ((true))
                {
                    try
                    {
                        requestCount = requestCount + 1;
                        StreamReader sr = new StreamReader(maykhach.GetStream());
                        string data = sr.ReadLine();
                        Console.WriteLine(clNo + " : " + data);
                        rCount = Convert.ToString(requestCount);
                        Program.broadcast(data, clNo, true);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }
            }
        }
    }
}
