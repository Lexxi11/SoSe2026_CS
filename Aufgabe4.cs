using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoSe2026_CS
{
    internal class Aufgabe4
    {
        public static void Start()
        {
            //Console.WriteLine("Hier könnte ihre Werbung stehen");
            //Variable anlegen
            //Datentyp Namen = Wert
            string vorname = "Alex";
            Console.WriteLine(vorname);
            string vorname1 = "Hans";
            Console.WriteLine(vorname + vorname1);

            Console.WriteLine("Hallo Welt");

            int zahl = 666;
            Console.WriteLine(zahl);
            zahl = 42;
            Console.WriteLine(zahl * 3);

            char frage = '?';
            Console.WriteLine(frage);

            double kontoStand = -42.66;
            Console.WriteLine(kontoStand / 6);

            kontoStand = kontoStand + 3000;
            Console.WriteLine("kontoStand: " + kontoStand);
            kontoStand = kontoStand * 2;
            Console.WriteLine("kontoStand: "+kontoStand);
            kontoStand /= 2; //kontoStand = kontoStand / 2;
            kontoStand += 1; //kontoStand = kontoStand + 1;
            kontoStand -= 666; //kontoStand = kontoStand - 666;
            Console.WriteLine("Kontostand: "+kontoStand);
        }
    }


}
