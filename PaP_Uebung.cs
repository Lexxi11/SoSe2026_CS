using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoSe2026_CS
{
    internal class PaP_Uebung
    {
        public static void Start()
        {
            Console.WriteLine("Punktzahl eingeben (0-100)");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int punktzahl) || punktzahl < 0 || punktzahl > 100)
            {
                Console.WriteLine("Ungültige Eingabe! Bitte eine Zahl zwischen 0 und 100 eingeben.");
                return;
            }

            // wenn die Eingabe gültig ist, wird die Note berechnet
            // Note: 1 = 92-100, 2 = 81-91, 3 = 67-80, 4 = 50-66, 5 = 30-49, 6 = 0-29


            int grade;
            // Beschreibung der Note
            string description;
            // Überprüfung der Punktzahl und Zuweisung der Note und Beschreibung
            if (punktzahl >= 92)
            //wenn die Punktzahl größer oder gleich 92 ist, wird die Note 1 zugewiesen und die Beschreibung "Sehr gut" gesetzt
            {
                grade = 1;
                description = "Sehr gut";
            }
            else if (punktzahl >= 81)
            //wenn die Punktzahl größer oder gleich 81 ist, wird die Note 2 zugewiesen und die Beschreibung "Gut" gesetzt
            {
                grade = 2;
                description = "Gut";
            }
            else if (punktzahl >= 67)
            //wenn die Punktzahl größer oder gleich 67 ist, wird die Note 3 zugewiesen und die Beschreibung "Befriedigend" gesetzt
            {
                grade = 3;
                description = "Befriedigend";
            }
            else if (punktzahl >= 50)
            //wenn die Punktzahl größer oder gleich 50 ist, wird die Note 4 zugewiesen und die Beschreibung "Ausreichend" gesetzt
            {
                grade = 4;
                description = "Ausreichend";
            }
            else if (punktzahl >= 30)
            //wenn die Punktzahl größer oder gleich 30 ist, wird die Note 5 zugewiesen und die Beschreibung "Mangelhaft" gesetzt
            {
                grade = 5;
                description = "Mangelhaft";
            }
            else
            //wenn die Punktzahl kleiner als 30 ist, wird die Note 6 zugewiesen und die Beschreibung "Ungenügend" gesetzt
            {
                grade = 6;
                description = "Ungenügend";
            }

            Console.WriteLine($"Punkte: {punktzahl} => Note: {grade} ({description})");
            Console.Write("Ist Herr Schmal zufrieden? (ja/nein): ");
            string zufrieden = Console.ReadLine();

            if (zufrieden.Equals("ja", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Herr Schmal ist zufrieden.");
            }
            else if (zufrieden.Equals("nein", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Herr Schmal ist nicht zufrieden.");
            }
            else
            {
                Console.WriteLine("Bitte nur ja oder nein eingeben.");
            }


        }


    }
}    