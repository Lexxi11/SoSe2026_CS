using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoSe2026_CS
{
    internal class Aufgabe3_Schleifen
    {
    public static void Start()
        {
            //Alexander Richter
            //Klasse It1
            //Aufgabe 17
            Console.WriteLine("Geben sie eine Ganzzahl oder ein Wort ein!");
            int zahl = Convert.ToInt32(Console.ReadLine());
            int fakultaet = 1;
            for (int i = 1; i <= zahl; i++)
            {
                fakultaet *= i;
            }
            Console.WriteLine($"Die Fakultät von {zahl} ist: {fakultaet}");
        }
    }
}
