using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SoSe2026_CS
{
    internal class Aufgabe6
    {
        public static void start()
        {
            //Console.Write("Bitte geben Sie ihren Namen ein:"); 
            //string vName  = Console.ReadLine();
            //Console.WriteLine("Hallo " + vName);

            /*
            //string str1 = "",str2 = "", str3 ="", str4 = "";
                             

            //Console.Write("Name1= ");
            //str1 = Console.ReadLine();
            //Console.Write("Name2= ");
            //str2 = Console.ReadLine();
            //Console.Write("Tätigkeit= ");
            //str3 = Console.ReadLine();
            //Console.Write("Name3= ");
            //str4 = Console.ReadLine();


            //string eingabeTest = $"Hallo {str1}! \nIch habe tolle Neuigkeiten. {str2} hat" +
                                   $" gestern {str3}! \nLiebe Grüße, \n{str4}";

                     

            //Console.WriteLine(eingabeTest);

            // */






            //string str666 = "";
            //Console.Write(" Bitte geben Sie einen Name ein:");
            //str666 = Console.ReadLine().ToUpper().Trim();
            //Console.WriteLine(str666);
            //Console.WriteLine("Länge: " + str666.Length);
            //Console.WriteLine("Erster Buchstabe " + str666.Substring(0, 1).ToUpper());
            //Console.WriteLine("Letzter Buchstabe " + str666[str666.Length - 1]);

            //Console.Write("Verständnis ist die Variable überschrieben? " + str666 + "\n");




            //Ausgabe:
            Console.WriteLine("Bitte geben Sie einen Namen oder Wort ein: ");
            string eingabeSting = Console.ReadLine();//.Trim()//.ToUpper();
            //Die Konsoleneingabe wird in der Variable eingabeString gespeichert, damit wir sie weiterverarbeiten können
            eingabeSting = eingabeSting.Trim(); //Anfangs und Endes Leerzeichen entfernen
            Console.WriteLine(eingabeSting); //Die bereinigte Eingabe wird ausgegeben
            eingabeSting = eingabeSting.ToUpper(); //Alle Buchstaben in Großbuchstaben umwandeln
            Console.WriteLine(eingabeSting); //Die umgewandelte Eingabe wird ausgegeben
            Console.WriteLine("Länge: " + eingabeSting.Length);
            Console.WriteLine("Erster Buchstabe: " + eingabeSting[0]);
            Console.WriteLine("Letzter Buchstabe: " + eingabeSting[eingabeSting.Length-1]);

            //Mit Substring:
            string ersterBuchstabe = eingabeSting.Substring(0, 1); //Substring(startIndex, length) => gibt eine Teilzeichenfolge zurück, beginnend bei startIndex und mit der angegebenen Länge







        }
    }
}
