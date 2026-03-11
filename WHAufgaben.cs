using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoSe2026_CS
{
    internal class WHAufgaben
    {
       
            public static void Start1()
            {
                //a)
                //Variable deklarieren:
                //Datentyp variablennamen = wert;
                int zahl1 = 10;
                //Ausgabe: cw
                Console.WriteLine(zahl1);
                //b)Kommazahl;
                double dbl_zahl = 5.5; //double => doppelt so viel stellen wie float
                Console.WriteLine(dbl_zahl);
                //c)
                string name = "Dieter"; // != char a = 'a';
                Console.WriteLine(name);
                string leer = "";
                string leerzeichen = " ";

            }
            public static void Start2()
            {   //a)
                Console.WriteLine("Wie heißt du?");
                string eingabeName = Console.ReadLine();
                Console.WriteLine("Hallo " + eingabeName);
                //b)
                Console.Write("Bitte Zahl 1 eingeben: ");
                string zahl1 = Console.ReadLine();
                Console.Write("Bitte Zahl 2 eingeben: ");
                string zahl2 = Console.ReadLine();
                Console.WriteLine(zahl1 + zahl2);
                //Mit Konvertierung:
                int z1 = Convert.ToInt32(zahl1);
                int z2 = Convert.ToInt32(zahl2);
                Console.WriteLine(z1 + z2);
                //c)
                Console.WriteLine("Wie alt bist du?");
                string eingabeAlter = Console.ReadLine();
                Console.WriteLine(eingabeAlter);
            }
            public static void Start3()
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
                Console.WriteLine(dblZahl / 3);
                //b)
                string zahlenString = "25";
                int zahlenAlsZahl = Convert.ToInt32(zahlenString);
                Console.WriteLine(zahlenAlsZahl);
                //c)
                double gleitKommaZahl = 5.25;
                int ganzeZahl = Convert.ToInt32(gleitKommaZahl);
                Console.WriteLine(ganzeZahl);
            }
            public static void Start4()
            {
                //a) 
                string wort1 = "Hasen";
                string wort2 = "Nasen";
                Console.WriteLine(wort1 + wort2);
                Console.WriteLine(wort2 + wort1);
                Console.WriteLine($"{wort1} <==> {wort2}");
                string gesamt = wort1 + wort2;
                Console.WriteLine(gesamt);
                //b)
                string satz = "Das Wort lagerregal ist ein Palindrom!";
                Console.WriteLine(satz);
                Console.WriteLine(satz.Length);
                Console.WriteLine("Der satz : \"" + satz + $"\" hat {satz.Length} Zeichen!");
                //c)
                string langerSatz = "Hallo isch bin ein String!";
                string anfang = langerSatz.Substring(0, 6);
                string ende = langerSatz.Substring(10);
                string neuerString = anfang + "ich" + ende;
                Console.WriteLine(langerSatz);
                Console.WriteLine(neuerString);
                string mitReplace = langerSatz.Replace("String", "Computer");
                Console.WriteLine(mitReplace);
            }
        }
    }
