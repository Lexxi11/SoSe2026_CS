using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoSe2026_CS
{
    internal class Eingabe
    {
        public static void Start()
        {
            //Console.Write("Bitte geben Sie Ihren Namen ein: ");
            //string vName = Console.ReadLine();
            //Console.WriteLine("Hallo "+ vName);
            string str1 = "", str2 = "", str3 = "", str4 = "";

            Console.Write("1: ");
            str1 = Console.ReadLine();
            Console.Write("2: ");
            str2 = Console.ReadLine();
            Console.Write("3: ");
            str3 = Console.ReadLine();
            Console.Write("4: ");
            str4 = Console.ReadLine();

            string eingabeTest = $"Hallo {str1}!\nIch habe tolle Neuigkeiten. {str2} hat" +
                                   $" gestern {str3}!\nLiebe Grüße,\n{str4}";

            Console.WriteLine(eingabeTest);

            //Ausgabe - Lösung: 
            Console.Write("Bitte geben Sie einen Namen oder Wort ein: "); //ausgabe ohne Zeilenumbruch
            string eingabeString; //Variable vom Typ string definieren
            eingabeString = Console.ReadLine();
            //Die Konsoleneingabe wird als Wert an die Variable übergeben
            eingabeString = eingabeString.Trim(); //Anfgangs/End - Leerzeichen entfernen
            Console.WriteLine(eingabeString); //Ausgabe des getrimmten Strings
            eingabeString = eingabeString.ToUpper(); //Alles in Großbuchstaben
                                                     //z.B "roman"       = "ROMAN"
            Console.WriteLine("Länge: " + eingabeString.Length);//Ausgabe der Länge des strings
                                                                // "ROMAN" = 'R'+'O'+'M'+'A'+'N'

            Console.WriteLine("Erster Buchstabe: " + eingabeString[0]);//Ausgabe des ersten Buchstaben
            Console.WriteLine("Letzter Buchstabe: " + eingabeString[eingabeString.Length - 1]);
            //                           eingabeString an der Stelle (länge des strings -1)
            //Mit Substrings:
            string ersterBuchstabe = eingabeString.Substring(0, 1);
            string letzterBuchstabe = eingabeString.Substring(eingabeString.Length - 1, 1);




        }
    }
}
