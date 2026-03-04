using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoSe2026_CS
{
    internal class Aufgabe5
    {
        public static void Start()
        {
            string inputString = " werPolizeidjsue ";

            // führende und endende Leerzeichen entfernen
            inputString = inputString.Trim();

            // String ausgeben
            Console.WriteLine(inputString);

            // Anzahl der Zeichen ausgeben
            Console.WriteLine("Anzahl: " + inputString.Length);

            // "Polizei" herausziehen
            string polizei = inputString.Substring(3, 7);
            Console.WriteLine(polizei);

            // in Großbuchstaben ausgeben
            Console.WriteLine(polizei.ToUpper());


           //   Console.WriteLine(inputString.IndexOf("P"));
           //   var Polizei2 = inputString.Substring(inputString.IndexOf("Polizei"), "Polizei".Length);
           //   Console.WriteLine(Polizei2);
           //   Console.WriteLine(Polizei2.ToUpper());
           //   Console.WriteLine(Polizei2.Length);



        }
    }
}