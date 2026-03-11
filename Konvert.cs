using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoSe2026_CS
{
    internal class Konvert
    {
        public static void Start()
        {
            //a)
            int ganzZahl = 10;
            double dblZahl = Convert.ToDouble(ganzZahl);
            //Ganzzahl:
            Console.WriteLine("Int:");
            Console.WriteLine(ganzZahl);
            Console.WriteLine(ganzZahl / 3);
            Console.WriteLine("Double");
            Console.WriteLine(dblZahl);
        }
        public static void Start2()
        {
            //b)
            double dblZahl = 5.5;
            int ganzZahl = Convert.ToInt32(dblZahl);
            //Double:
            Console.WriteLine("Double:");
            Console.WriteLine(dblZahl);
            Console.WriteLine(dblZahl / 3);
            Console.WriteLine("Int");
            Console.WriteLine(ganzZahl);
        }
        public static void Start3()
        {
            //c)
            string strZahl = "10";
            int ganzZahl = Convert.ToInt32(strZahl);
            Console.WriteLine("String:");
            Console.WriteLine(strZahl);
            Console.WriteLine("Int:");
            Console.WriteLine(ganzZahl);
        }
        public static void Start4()
        {
            //d)
            string strZahl = "5.5";
            double dblZahl = Convert.ToDouble(strZahl);
            Console.WriteLine("String:");
            Console.WriteLine(strZahl);
            Console.WriteLine("Double:");
            Console.WriteLine(dblZahl);
        }
    }
}

