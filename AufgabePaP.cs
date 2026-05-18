using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoSe2026_CS
{
    internal class AufgabePaP
    {
        public static void Start()
        {
            //Ausgabe
            Console.WriteLine("Willkommen! Bitte geben Sie eine Zahl ein:");

            //Eingabe
            string input = Console.ReadLine();

            //Validierung
            if (!double.TryParse(input, out double zahl))
            { 
                Console.WriteLine("Ihre Eingabe ist keine Zahl!");
                return;
            }
            
            //Bereich prüfen
            if (zahl > 10 && zahl < 20)
            {
                Console.WriteLine("Die eingegebene Zahl liegt in Bereich von 10 bis 20");
            }
            else
            {
                Console.WriteLine("Die eingegebene Zahl liegt nicht im Bereich von 10 bis 20");
            }





}


}
}
