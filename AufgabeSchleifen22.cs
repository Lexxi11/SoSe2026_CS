using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace SoSe2026_CS
{
    internal class AufgabeSchleifen22
    {
        public static void Start()
        {
            // Alexander Richter
            // Klasse It1
            // Aufgabe 17 - überarbeitet: saubere Arrays, Min/Max, Durchschnitt
            // Nutzer kann Ganzzahl angeben, zahlt bestimmt größe des Arrays, das mit Zufallszahlen gefüllt wird
            // Dieses Array soll mit Bubblesort-Algorithmus sortiert werden und ausgegeben werden

            Console.WriteLine("Geben Sie die Anzahl der Zufallszahlen ein:");
            string? input = Console.ReadLine();
            if (!int.TryParse(input, out int groesse) || groesse <= 0)
            {
                Console.WriteLine("Ungültige Eingabe. Bitte eine positive ganze Zahl eingeben.");
                return;
            }

            int[] zahlen = new int[groesse];
            Random rnd = new Random();
            for (int i = 0; i < zahlen.Length; i++)
            {
                zahlen[i] = rnd.Next(1, 101);
            }

            Console.WriteLine("Unsortierte Zahlen:");
            Console.WriteLine(string.Join(" ", zahlen));

            // Bubblesort-Algorithmus
            for (int i = 0; i < zahlen.Length - 1; i++)
            {
                for (int j = 0; j < zahlen.Length - i - 1; j++)
                {
                    if (zahlen[j] > zahlen[j + 1])
                    {
                        int temp = zahlen[j];
                        zahlen[j] = zahlen[j + 1];
                        zahlen[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("\nSortierte Zahlen:");
            Console.WriteLine(string.Join(" ", zahlen));

            // Min, Max, Durchschnitt
            if (zahlen.Length > 0)
            {
                int min = zahlen.Min();
                int max = zahlen.Max();
                double avg = zahlen.Average();
                Console.WriteLine($"\nMin: {min}  Max: {max}  Durchschnitt: {avg:F2}");
            }
        }
    }
}
    
    
