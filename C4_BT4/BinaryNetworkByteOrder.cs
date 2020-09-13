﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace C4_BT4
{
    class BinaryNetworkByteOrder
    {
        static void Main(string[] args)
        {
            short test1 = 45;
            int test2 = 314159;
            long test3 = -123456789033452;
            byte[] data = new byte[1024];
            string output;
            data = BitConverter.GetBytes(test1);
            output = BitConverter.ToString(data);
            Console.WriteLine("test1 = {0}, string = {1}", test1, output);
            data = BitConverter.GetBytes(test2);
            output = BitConverter.ToString(data);
            Console.WriteLine("test2 = {0}, string = {1}", test2, output);
            data = BitConverter.GetBytes(test3);
            output = BitConverter.ToString(data);
            Console.WriteLine("test3 = {0}, string = {1}", test3, output);
            short test1b = IPAddress.HostToNetworkOrder(test1);
            data = BitConverter.GetBytes(test1b);
            output = BitConverter.ToString(data);
            Console.WriteLine("test1 = {0}, nbo = {1}", test1b, output);
            int test2b = IPAddress.HostToNetworkOrder(test2);
            data = BitConverter.GetBytes(test2b);
            output = BitConverter.ToString(data);
            Console.WriteLine("test2 = {0}, nbo = {1}", test2b, output);
            long test3b = IPAddress.HostToNetworkOrder(test3);
            data = BitConverter.GetBytes(test3b);
            output = BitConverter.ToString(data);
            Console.WriteLine("test3 = {0}, nbo = {1}", test3b, output);
        }
    }
}
