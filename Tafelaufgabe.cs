using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoSe2026_CS
{
    internal class Tafelaufgabe
    {
        public static void Start()
        {
            //A^B^B = A
            //A=10110011
            //B=01001101

            int A = Convert.ToInt32("10110011", 2);
            int B = Convert.ToInt32("01001101", 2);
            int ergebnius = A ^ B ^ B;
            int ergebnius2 = ergebnius ^ B;
            Console.WriteLine("A                 = " + Convert.ToString(A, 2).PadLeft(8, '0'));
            Console.WriteLine("B                 = " + Convert.ToString(B, 2).PadLeft(8, '0'));
            Console.WriteLine("A ^ B        = " + Convert.ToString(ergebnius, 2).PadLeft(8, '0'));
            Console.WriteLine("(A ^ B) ^ B       = " + Convert.ToString(ergebnius2, 2).PadLeft(8, '0'));

        }
    }
}
