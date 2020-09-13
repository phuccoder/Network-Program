using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegateExample
{
    public delegate int delCalculation(int So1, int So2);
    class Calculation
    {
        
        public int Cong(int So1, int So2)
        {
            return So1 + So2;
        }
        public int Tru(int So1, int So2)
        {
            return So1 - So2;
        }
        static void Main(string[] args)
        {
            Calculation objTinhToan = new Calculation();
            delCalculation objDelCong = objTinhToan.Cong;
            int KQ_Cong = objDelCong(10, 5);
            Console.WriteLine("Cong KQ = {0}", KQ_Cong);
            delCalculation objDelTru = objTinhToan.Tru;
            int KQ_Tru = objDelTru(10, 5);
            Console.WriteLine("Tru KQ = {0}", KQ_Tru);
            Console.ReadKey();
        }
    }
}
