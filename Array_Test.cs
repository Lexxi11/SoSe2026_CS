using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoSe2026_CS
{
    internal class Array_Test
    {
        public static void Start()
        {
            //Arrays - viele Variablen auf einmal
            string str = "Hallo";
            //Charr-Array = {'h','a','l', 'l', 'o'};
            Console.WriteLine(str[0]); //string an der Stelle 0
            int länge_Des_Strings = str.Length; //Länge des Strings

            //=> Array, hierbei handelt es sich um eine Datenstruktur, die mehrere Werte des gleichen Datentyps speichern kann.
            //Datentyp[] Name_des_Arrays = new Datentyp[Anzahl_der_Stellen]{Werte};
            //char[] charArray = new char[5]; //Array mit 5 Stellen
            char[] chrArray = new char[5] { 'H', 'A', 'L', 'L', 'O' }; //Array mit 5 Stellen, die mit Werten gefüllt werden
                                                                       //ählich zu string str = "Hallo";, aber hiermit können wir die Werte einzeln ansprechen und verändern
                                                                       //ähnlich zu
                                                                       //char ch1 = 'H'; char ch2 = 'A'; char ch3 = 'L'; char ch4 = 'L'; char ch5 = 'O';
                                                                       //Andere Möglichkeiten, ein Array zu erstellen:
                                                                       //int[] intArray = new int[] { 1, 2, 3, 4, 5 }; //Array mit 5 Stellen, die mit Werten gefüllt werden
            int[] intArray2 = new int[5]; //Array mit 5 Stellen, die mit Werten gefüllt werden können
            intArray2[0] = 666;
            int[] intArray3 = { 42, 0, 1, 2, 3, 666, -54 }; //Array mit 7 Stellen, die mit Werten gefüllt werden, hier wird die Anzahl der Stellen automatisch erkannt
            int[] intArray4 = new int[3] { -53, 7, 34 };

            intArray2[0] = 666; //Array an der Stelle 0 den Wert 666 zuweisen
            //String[] kapitel = new string[10000]; //Array mit 10000 Stellen, die mit Werten gefüllt werden können
            Console.WriteLine(intArray3[2]);
            Console.WriteLine(intArray3[1]);
            Console.WriteLine(intArray3[5]);



            //Array mit mehreren Dimensionen

            string[] vornamen = new string[5];
            string[] nachnamen = new string[5];
            int[] alter = new int[5];

            Console.Write("Vorname: ");
            vornamen[0] = Console.ReadLine();

            Console.Write("Nachname: ");
            nachnamen[0] = Console.ReadLine();

            Console.Write("Alter: ");
            alter[0] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Hallo " + vornamen[0] + " " + nachnamen[0] + ", du bist " + alter[0] + " Jahre alt.");






        }
    }
}
