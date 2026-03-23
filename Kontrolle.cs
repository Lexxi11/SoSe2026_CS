using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoSe2026_CS
{
    internal class Kontrolle
    {
        public static void Start()
        {
            /*
            Console.Write("Passwort eingeben: ");
            string pw = "12345!";
            string eingabe = Console.ReadLine();
            if (pw == eingabe)
            {
                Console.WriteLine("Login!");
            }
            //if (Bedingung)
            //{
            //      Code...
            //      wird nur ausgeführt, falls Bedingung = True
            //}         
            int x;
            bool konv = int.TryParse(Console.ReadLine(), out x);
            // int.TryParse versucht "Console.ReadLine()" zu einer int zu konvertieren
            //      -> Wenn konvertierung erfolgreich       => konv = true
            //      -> Wenn konvertierung nicht erfolgreich => konv = false
            if (konv) //In der Bedingung wird immer True/False überprüft
            {
                Console.WriteLine("Eingabe war eine Ganzzahl!");
            }
            else //beim else gibt es keine Bedingung!
            {
                Console.WriteLine("Eingabe war keine ganze Zahl!");
            }
            if (true) //Unnötig, weil es IMMER ausgeführt wird!
            {
                Console.WriteLine("wird immer aus geführt!");
            }
            else //Unnötig, weil es NIEMALS ausgeführt wird!
            {
                Console.WriteLine("wird niemals angezeigt!");
            }

            if (false) //Unnötig, weil es NIEMALS ausgeführt wird!
            {
                Console.WriteLine("wird niemals angezeigt!");
            }
            else //Unnötig, weil es IMMER ausgeführt wird!
            {
                Console.WriteLine("wird immer aus geführt!");
            }
            

            Console.Write("Alter: ");                   //Ausgabe:
            string eingabeAlter = Console.ReadLine();   //Eingabe:
            int alterZahl;                              //Anlegen einer int-Variable
            bool korrekteEingabe = int.TryParse(eingabeAlter, out alterZahl);
            //Kann eingabe konvertiert werden?
            if (korrekteEingabe) //Falls eingabe Konvertierung erfolgreich:
            {
                if(alterZahl >= 18) //Überprüfung, ob alter größer gleich 18
                {
                    Console.WriteLine("Eintreten!"); //wenn alter >= 18
                }
                else
                {
                    Console.WriteLine("Nö!");   //wenn, sonstige
                }
            }
            else //Falls eingabe Konvertierung NICHT erfolgreich war
            {
                Console.WriteLine("Keine korrekte Eingabe!");
            }
           */
            int i = 20;

            if (i > 10) //Entweder das ist true
            {
                Console.WriteLine("i>10");
            }
            else if (i < 0) //oder das ist true
            {
                Console.WriteLine("i<0");
            }
            else //ansonsten wird das hier ausgeführt
            {
                Console.WriteLine("i<=10 und i>=0");
            }
            //Aber nur eines von den 3 Fällen kann auftreten




        }
    }
}
