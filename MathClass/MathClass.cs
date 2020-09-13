using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MathClass
{
    public class MathClass : MarshalByRefObject // support remoting
    {
        public int Add(int a, int b)
        {
            int c = a + b;
            return c;
        }
        public int Subtract(int a, int b)
        {
            int c = a - b;
            return c;
        }
        public int Multiply(int a, int b)
        {
            int c = a * b;
            return c;
        }
        public int Divide(int a, int b)
        {
            int c;
            if (b != 0)
                c = a / b;
            else
                c = 0;
            return c;
        }
    }
}
