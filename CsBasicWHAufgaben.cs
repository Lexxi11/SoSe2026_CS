using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoSe2026_CS
{
    internal class CsBasicWHAufgaben
    {
        public static void Start()
        {
            //Aufgabe 1: 
            int a = 5;
            int b = 10;
            int c = 15;
            int d = 20;

            Console.WriteLine(a + b + c + d);
            Console.WriteLine((a + b) * (c + d));
            Console.WriteLine((a * b) + (c * d));
            Console.WriteLine((a * c) - (b * d));

            double e = 10.5;
            double f = 15.5;
            double g = 20.5;

            Console.WriteLine(d + e + f + g);
            Console.WriteLine((d + e) * (f + g));
            Console.WriteLine((d * e) + (f * g));
            Console.WriteLine((d * f) - (e * g));

            Console.Clear();

            string ergebnis1 = $"Ergebnis 1: {a + b + c + d}";
            Console.WriteLine(ergebnis1);


            // ########
            // ########
            // ######## Aufgabe 2:
            // ########
            // ########
            
            Console.WriteLine("Hey, wie ist dein Name? ");
            Console.ReadLine();
            string str1 = Console.ReadLine();
            Console.WriteLine("Hallo, " + str1);
            
        }
    }
}
