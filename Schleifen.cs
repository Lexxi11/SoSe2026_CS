using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoSe2026_CS
{
    internal class Schleifen
    {
        public static void Start()
        {
            //Alexander Richter
            //Klasse It1
            //Aufgabe 15
            //int zahlAR;
            //tring eingabeStringAR;
            //Console.WriteLine("Geben sie eine Ganzzahl oder ein Wort ein!");
            //eingabeStringAR = Console.ReadLine();
            //if (int.TryParse(eingabeStringAR, out zahlAR))
            //{
            //   for (int i = 0; i < zahlAR; i++)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //else { Console.WriteLine("Das ist keine Zahl!"); }


            //Schleifen
            //While-Schleife
            //while bedingung
            //tue etwas
            int counter = 0;
            while (counter <= 20)
            {
               if (counter % 2 == 0)
                {
                    Console.WriteLine(counter);
                }
                counter++;


            }
        }
    }
}
