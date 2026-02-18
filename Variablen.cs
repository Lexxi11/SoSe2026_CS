using System.Runtime.CompilerServices;

namespace SoSe2026_CS
{
    internal class Variablen
    {
        public static void Start()
        {
            Console.WriteLine("####### Variablen #######");
            //Datentypen: 
            //Interger: int <==> Ganzzahlen
            int zahl1 = 42; // Variable zahl1 erstellen und den Wert 42 zuweisen
            int zahl2 = 666;
            int summ = zahl1 + zahl2;

            Console.WriteLine(zahl1); // Vaiable zahl1 aufrufen <==> Wert auslesen 
            Console.WriteLine(zahl2);
            Console.WriteLine(summ);

            //Variable einen anderen Wert zuweisen
            Console.WriteLine();
            zahl1 = 2398471;
            Console.WriteLine(zahl1);


            //Double: double <==> Gleitkommazahlen            
            double pi = 3.1415926535897932384626433832795;
            Console.WriteLine("pi: " + pi);
            Console.WriteLine("Math.PI: " + Math.PI);
            ;


            //String: string <=> Zeichenketten

            string vorname = "Roman";
            string nachname = "Schmal";
            Console.WriteLine(vorname);
            Console.WriteLine(nachname);
            vorname = "Tobi";
            Console.WriteLine(vorname);


            //Charakter: char <==> einzelne Zeichen            
            char ausrufezeichen = '!';
            Console.WriteLine(ausrufezeichen);
            Console.WriteLine((int)ausrufezeichen);
            int test = 42;
            Console.WriteLine((char)test);
            int test2 = 169;
            Console.WriteLine((char)test2);
            int test3 = 146;
            Console.WriteLine((char)test3);
            int zuGroß = 2147483647;


            Console.WriteLine(zuGroß);
            zuGroß = zuGroß + 1;
            Console.WriteLine(zuGroß);
            zuGroß = zuGroß + 51;
            Console.WriteLine(zuGroß);
            int zuKlein = -2147483648;
            Console.WriteLine(zuKlein);
            zuKlein = zuKlein - 1;
            short klein = 32767; //(2^15)-
            Console.WriteLine(klein); //geht nicht weil: short != int
            //klein = klein + 1;

            //Boolean: bool <==> Wahrheitswerte
            int deinAlter = 18;
            bool altGenug = deinAlter >= 18;
            Console.WriteLine("Alt genug? => " + altGenug);
            Console.WriteLine();


            var ortsname = "Regensburg"; // var => Compiler ermittelt den Datentyp automatisch // hier wird die variable zu einem string
            var postleitzahl = 93047;  // hier wird variable zu einem int
            //ortsname = 55; geht nicht, da variable bereits als string hinterlegt!
            int datum;
            string anrede;
            //geht nicht
            //var test3;

            Console.WriteLine(55);
            Console.WriteLine("55");
            //Console.WriteLine(55=="55");
            //55 (int) ist nicht gleich "55" (string)


            double x = 0.5;
            double y = 0.7;
            x = x * 2;
            x = x * y * 5;
            Console.Write("x = x * y * 5= ");
            Console.WriteLine(x);






        }

    }
}
