using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoSe2026_CS
{
    internal class Aufgabe2_schleifen
    {
        public static void start()
        {
            //Alexander Richter
            //Klasse It1
            //Aufgabe 16
            Console.WriteLine("Geben sie eine Ganzzahl oder ein Wort ein!");
            int zahl = Convert.ToInt32(Console.ReadLine());
            int summe = 0;
            for (int i = 0; i <= zahl; i++)
            {
                summe += i;
            }
            Console.WriteLine($"Die Summe der Zahlen von 0 bis {zahl} ist: {summe}");


        }
    }
}
