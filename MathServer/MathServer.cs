using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;

namespace MathServer
{
    class MathServer
    {
        public static int Main(string[] args)
        {
            HttpChannel chan = new HttpChannel(8000);
            
            ChannelServices.RegisterChannel(chan, false);
            RemotingConfiguration.RegisterWellKnownServiceType(Type.GetType("MathClass, MathClass"), "MyMathServer", 
                WellKnownObjectMode.SingleCall);
            Console.WriteLine("Hit <enter> to exit...");
            Console.ReadLine();
            Console.ReadKey();
            return 0;
        }
    }
}
