using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoSe2026_CS
{
    internal class Aufgabe4_Schleifen
    {
        public static void Start()
        {
            //Alexander Richter
            //Klasse It1
            //Aufgabe 4
            Console.WriteLine("Zahl 1 eingeben;");
            int z1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Zahl 2 eingeben;");
            int z2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Zahl 3 eingeben;");
            int z3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Zahl 4 eingeben;");
            int z4 = Convert.ToInt32(Console.ReadLine());

            if (z1 > z2 && z1 > z3 && z1 > z4)
            {
                Console.WriteLine($"Die größte Zahl ist: {z1}");
            }
            else if (z2 > z1 && z2 > z3 && z2 > z4)
            {
                Console.WriteLine($"Die größte Zahl ist: {z2}");
            }
            else if (z3 > z1 && z3 > z2 && z3 > z4)
            {
                Console.WriteLine($"Die größte Zahl ist: {z3}");
            }
            else
            {
                Console.WriteLine($"Die größte Zahl ist: {z4}");


            }
        }
    }
}




