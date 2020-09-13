using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace C2_BT2
{
    class BadTcpSrvr
    {
        static void Main(string[] args)
        {
            int recv;
            byte[] data = new byte[1024];

            IPEndPoint ipep = new IPEndPoint(IPAddress.Any, 9050);
            Socket newsock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            newsock.Bind(ipep);
            newsock.Listen(10);

            Console.WriteLine("Waiting for a client...");

            Socket client = newsock.Accept();
            IPEndPoint newclient = (IPEndPoint)client.RemoteEndPoint;

            string welcome = "Welcome to my test server";
            data = Encoding.ASCII.GetBytes(welcome);
            client.Send(data, data.Length, SocketFlags.None);

            Console.WriteLine("Connected with {0} at port {1}", newclient.Address, newclient.Port);

            for (int i = 0; i < 5; i++)
            {
                recv = client.Receive(data);
                Console.WriteLine(Encoding.ASCII.GetString(data, 0, recv));
            }

            Console.WriteLine("Disconnecting from {0}", newclient.Address);
            client.Close();
            newsock.Close();
        }
    }
}
