using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace C1_BT4
{
    class GetDNSHostInfo
    {
        static void Main(string[] argv)
        {
            if (argv.Length != 1)
            {
                Console.WriteLine("Usage: GetDNSHostInfo hostname");
                Console.ReadKey();
                return;                
            }

            IPHostEntry results = Dns.GetHostByName(argv[0]);

            Console.WriteLine("Host name: {0}", results.HostName);

            foreach (string alias in results.Aliases)
            {
                Console.WriteLine("Alias: {0}", alias);
            }

            foreach (IPAddress address in results.AddressList)
            {
                Console.WriteLine("Address: {0}", address.ToString());
            }

            Console.ReadKey();
        }
        
    }
}
