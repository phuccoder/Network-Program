using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegateEx
{
    class Program
    {
        public delegate int Calculation(int a, int b);
        static int Add(int a, int b)
        {
            return a + b;
        }
        static int Sub(int a, int b)
        {
            return a - b;
        }
        static int Calculate(int a, int b, Calculation cal)
        {
            return cal(a, b);
        }
        static void Main(string[] args)
        {
            int c = Calculate(9, 4, Add);
            Console.WriteLine(c);
            int d = Calculate(9, 4, Sub);
            Console.WriteLine(d);
            Console.ReadLine();
        }
    }
}
