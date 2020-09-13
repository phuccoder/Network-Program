﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace C3_BT4
{
    class BadUdpClient
    {
        static void Main(string[] args)
        {
            byte[] data = new byte[30];
            string input, stringData;
            IPEndPoint ipep = new IPEndPoint( IPAddress.Parse("127.0.0.1"), 9050);
            Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            string welcome = "Hello, are you there?";
            data = Encoding.ASCII.GetBytes(welcome);
            server.SendTo(data, data.Length, SocketFlags.None, ipep);
            IPEndPoint sender = new IPEndPoint(IPAddress.Any, 0);
            EndPoint tmpRemote = (EndPoint)sender;
            data = new byte[30];
            int recv = server.ReceiveFrom(data, ref tmpRemote);
            Console.WriteLine("Message received from {0}:", tmpRemote.ToString());
            Console.WriteLine(Encoding.ASCII.GetString(data, 0, recv));
            while (true)
            {
                input = Console.ReadLine();
                if (input == "exit")
                    break;
                server.SendTo(Encoding.ASCII.GetBytes(input), tmpRemote);
                data = new byte[30];
                recv = server.ReceiveFrom(data, ref tmpRemote);
                stringData = Encoding.ASCII.GetString(data, 0, recv);
                Console.WriteLine(stringData);
            }
            Console.WriteLine("Stopping client");
            server.Close();
        }
    }
}
