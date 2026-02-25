using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoSe2026_CS
{
    internal class AufgabeTeams
    {
        public static void Start()
        {
            string str1, str2, str3, str4, str5, str6, str7, str8, str9;
            str1 = "wie";
            str2 = "dir";
            str3 = "es";
            str4 = "Danke";
            str5 = "Hallo";
            str6 = "geht";
            str7 = "gut";
            str8 = "mir";
            str9 = "Danke";

            //{0} {1} {2} {3} {4}.. für die Formattierung, die Zahlen geben an, welche Variable an welcher Stelle eingesetzt wird

            string frage = string.Format("{0}, {1} {2} {3} {4}?", str5, str1, str4, str3, str2);
            Console.WriteLine(frage);
            string antwort = string.Format("{0}, {1} {2} {3} {4}!", str9, str3, str6, str8, str7);
            Console.WriteLine(antwort);
            Console.WriteLine(frage + "\n" + antwort);
            


            //Oder:
            Console.WriteLine("{4}, {0} {5} {2} {1}?\n{3}, {2} {5} {7} {6}!", str1, str2, str3, str4, str5, str6, str7, str8);
            //\n für Zeilenumbruch

            Console.WriteLine($"{str5}, {str1} {str6} {str3} {str2}?");
            Console.WriteLine($"{str4}, {str3} {str6} {str8} {str7}!");

        }
    }
}
