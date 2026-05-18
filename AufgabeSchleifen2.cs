using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoSe2026_CS
{
    internal class AufgabeSchleifen2
    {
        public static void Start()
        {
            // Alexander Richter
            // Klasse It1
            // Aufgabe 18 - überarbeitet: saubere Arrays, Min/Max, Durchschnitt

            string[] monate = new[]
            {
                    "Januar","Februar","März","April","Mai","Juni",
                    "Juli","August","September","Oktober","November","Dezember"
                };

            int[] umsatz = new int[monate.Length];
            var rnd = new Random();
            int summe = 0;
            int min = int.MaxValue, max = int.MinValue;
            int minIdx = -1, maxIdx = -1;

            for (int i = 0; i < umsatz.Length; i++)
            {
                umsatz[i] = rnd.Next(1000, 5000);
                summe += umsatz[i];

                if (umsatz[i] < min)
                {
                    min = umsatz[i];
                    minIdx = i;
                }

                if (umsatz[i] > max)
                {
                    max = umsatz[i];
                    maxIdx = i;
                }
            }

            for (int i = 0; i < umsatz.Length; i++)
            {
                Console.WriteLine($"{monate[i]}: {umsatz[i]} Euro");
            }

            double durchschnitt = (double)summe / umsatz.Length;
            Console.WriteLine();
            Console.WriteLine($"Der durchschnittliche Umsatz pro Monat beträgt: {durchschnitt:F2} Euro");
            Console.WriteLine($"Niedrigster Umsatz: {monate[minIdx]} mit {min} Euro");
            Console.WriteLine($"Höchster Umsatz:   {monate[maxIdx]} mit {max} Euro");
        }
    }
               // Pseudocode(detaillierter Plan):
                //1.Definiere ein string[] mit den 12 Monatsnamen statt einer kommaseparierten Zeichenkette.
               // 2.Erstelle ein int[] für Umsätze mit Länge = Anzahl Monate.
               // 3.Erzeuge ein Random-Objekt(ggf.als lokale Variable).
                //4.Initialisiere Variablen: summe, min, max, minIndex, maxIndex.
                //5.Schleife über alle Monate(for i = 0..Length - 1):
                  // a.Erzeuge zufälligen Umsatz für den Monat und speichere in umsatz[i].
                   //b.addiere zum summe.
                   //c.aktualisiere min und max inkl.Index, falls nötig.
                //6.Zweite Schleife: Ausgabe eines Zeilenstrings "Monat: Betrag Euro" pro Monat.
                //7.Berechne Durchschnitt als double und gib mit zwei Nachkommastellen aus.
                //8.Gib zusätzlich Monat mit minimalem und maximalem Umsatz aus.
                //9.Optional: Fehlerfreie, lesbare und leicht testbare Methode(keine wiederholten String.Split - Aufrufe).
}
