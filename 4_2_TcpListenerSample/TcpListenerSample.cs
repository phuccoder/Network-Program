﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace C4_BT2
{
    class TcpListenerSample
    {
        static void Main(string[] args)
        {
            int recv;
            byte[] data = new byte[1024];
            TcpListener newsock = new TcpListener(9050);
            newsock.Start();
            Console.WriteLine("Waiting for a client...");
            TcpClient client = newsock.AcceptTcpClient();
            NetworkStream ns = client.GetStream();
            string welcome = "Welcome to my test server";
            data = Encoding.ASCII.GetBytes(welcome);
            ns.Write(data, 0, data.Length);
            while (true)
            {
                data = new byte[1024];
                recv = ns.Read(data, 0, data.Length);
                if (recv == 0)
                    break;
                Console.WriteLine(
                Encoding.ASCII.GetString(data, 0, recv));
                ns.Write(data, 0, recv);
            }
            ns.Close();
            client.Close();
            newsock.Stop();
        }
    }
}
