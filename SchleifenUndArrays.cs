using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoSe26_CS
{
    internal class SchleifenUndArrays
    {
        public static void Start()
        {
            //Schleifen
            // while-schleife
            //while(Bedingung){
            // tue etwas
            //}
            /*
            Console.WriteLine("Bitte gib stop ein: ");
            while (Console.ReadLine() != "stop")
            {
                Console.WriteLine("Bitte gib stop ein: ");

            }
            */
            //Aufgabe 1
            int counter = 0;
            while (counter <= 20)
            {
                if (counter % 2 == 0)
                {
                    Console.WriteLine(counter);
                }
                counter++;
            }

            //Aufgabe 2

            Console.WriteLine("##########################");
            Console.WriteLine("########Aufgabe 2#########");
            Console.WriteLine("##########################");
            Console.WriteLine("\n");
            Console.Write("Bitte Eine zahl eingeben: ");
            int eingabeZahl = 0;
            string eingabeString = Console.ReadLine();
            eingabeZahl = Convert.ToInt32(eingabeString);
            int summe = 0;
            string ausgabe = "";
            Console.WriteLine((eingabeZahl * (eingabeZahl + 1)) / 2);
            while (eingabeZahl >= 0)
            {
                summe += eingabeZahl;
                ausgabe += $"{eingabeZahl} + ";
                eingabeZahl--;
            }
            Console.WriteLine(summe + $" , [{ausgabe}\b\b]");


            //Aufgabe 3

            Console.WriteLine("Bitte eine Zahl zwischen 1 und 25");
            int eingabZ = -1;
            while (!int.TryParse(Console.ReadLine(), out eingabZ)
                || eingabZ > 25 || eingabZ <= 0)
            {
                Console.WriteLine("Falsche Eingabe");
            }
            Console.Clear();
            int produkt = 1;
            while (eingabZ > 0)
            {
                produkt *= eingabZ;
                Console.Write(eingabZ + " * ");
                eingabZ--;
            }
            Console.WriteLine("\b\b = " + produkt);


            //Aufgabe 4
            /*
             * Nach eingabe von vier Zahlen soll das Programm, die größte dieser ausgaben
             */
            int schleifenZähler = 1;
            int maxZahl = int.MinValue; //MinValue = -2147483648 (kleines möglicher INT-wert)
            int minZahl = int.MaxValue;
            int summeA4 = 0;
            while (schleifenZähler <= 10)
            {
                Console.Write($"Bitte {schleifenZähler}. Zahl eingeben: ");
                int eingabe4zahl = 0;
                while (!int.TryParse(Console.ReadLine(), out eingabe4zahl))
                {
                    Console.WriteLine("Falsche Eingabe");
                    Console.Write($"Bitte {schleifenZähler}. Zahl eingeben: ");
                }
                summe += eingabe4zahl;
                if (eingabe4zahl > maxZahl)
                {
                    maxZahl = eingabe4zahl;
                }
                if (eingabe4zahl < minZahl)
                {
                    minZahl = eingabe4zahl;
                }
                schleifenZähler++;
                //schleifenzähler = schleifenzähler +1;
                //schleifenzähler +=1;
            }
            Console.WriteLine("Größte Zahl: " + maxZahl);
            Console.WriteLine("Kleinste Zahl: " + minZahl);
            Console.WriteLine($"Durchschnitt = {summe / (schleifenZähler - 1)}");



        }
    }
}
