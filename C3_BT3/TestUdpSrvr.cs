﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace C3_BT3
{
    class TestUdpSrvr
    {
        static void Main(string[] args)
        {
            int recv;
            byte[] data = new byte[1024];
            IPEndPoint ipep = new IPEndPoint(IPAddress.Any, 9050);
            Socket newsock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            newsock.Bind(ipep);
            Console.WriteLine("Waiting for a client...");
            IPEndPoint sender = new IPEndPoint(IPAddress.Any, 0);
            EndPoint tmpRemote = (EndPoint)(sender);
            recv = newsock.ReceiveFrom(data, ref tmpRemote);
            Console.WriteLine("Message received from {0}:", tmpRemote.ToString());
            Console.WriteLine(Encoding.ASCII.GetString(data, 0, recv));
            string welcome = "Welcome to my test server";
            data = Encoding.ASCII.GetBytes(welcome);
            newsock.SendTo(data, data.Length, SocketFlags.None, tmpRemote);
            for (int i = 0; i < 5; i++)
            {
                data = new byte[1024];
                recv = newsock.ReceiveFrom(data, ref tmpRemote);
                Console.WriteLine(Encoding.ASCII.GetString(data, 0, recv));
            }
            newsock.Close();
        }
    }
}
