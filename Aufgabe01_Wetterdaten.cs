// ============================================================
//  ECKERT SCHULEN – Berufsförderungswerk
//  C# Grundlagen | Schleifen & Arrays
// ------------------------------------------------------------
//  Aufgabe 01: Wetterdaten einer Wetterstation
//  Klasse:     Fachinformatiker/in (FIAE / FISI)
// ------------------------------------------------------------
//  HINWEIS: Verändere NICHT die vorgegebenen Arrays!
//           Schreibe deinen Code ausschließlich in den
//           mit TODO markierten Abschnitten.
// ============================================================

using System;
using System.Numerics;
using System.Runtime.ExceptionServices;

class Aufgabe01_Wetterdaten
{
    static void Start()
    {
        // ----------------------------------------------------------
        // VORGEGEBENE DATEN – Tagesdurchschnittstemperaturen (°C)
        // Messstation München-Pasing, Januar 2024 (31 Tage)
        // ----------------------------------------------------------
        double[] temperaturen = {
             -3.2,  -1.8,   0.5,   2.1,  -0.4,
             -5.7,  -6.1,  -4.3,  -2.9,  -1.1,
              1.7,   3.4,   4.0,   2.8,   1.5,
             -0.7,  -2.2,  -3.8,  -1.6,   0.9,
              2.3,   4.7,   5.1,   3.9,   2.0,
              0.1,  -1.3,  -2.5,  -0.8,   1.2,
              3.6
        };

        // Kurzform: int tag = 1 entspricht temperaturen[0]
        // Der Monat hat genau 31 Tage (temperaturen.Length == 31)

        Console.WriteLine("=== Wetterstation München-Pasing | Januar 2024 ===");
        Console.WriteLine();


        // ----------------------------------------------------------
        // AUFGABE 1 (★☆☆) – Alle Temperaturen ausgeben
        // ----------------------------------------------------------
        // Gib alle Tageswerte auf der Konsole aus.
        // Format: "Tag  1: -3,2 °C"
        //         "Tag  2: -1,8 °C"
        //         ...
        // Hinweis: Verwende {tag,2} für rechtsbündige Tageszahl.
        //          Verwende {temp:F1} für eine Nachkommastelle.
        // ----------------------------------------------------------

        Console.WriteLine("--- Alle Tageswerte ---");

        // TODO Aufgabe 1 – dein Code hier:
        for (int i = 0; i < temperaturen.Length; i++)
        {
            Console.WriteLine($"Tag {i + 1,2}: {temperaturen[i],5:F1} °C");
        }



        Console.WriteLine();


        // ----------------------------------------------------------
        // AUFGABE 2 (★☆☆) – Durchschnittstemperatur berechnen
        // ----------------------------------------------------------
        // Berechne die Durchschnittstemperatur des gesamten Monats.
        // Gib das Ergebnis mit 2 Nachkommastellen aus.
        // Format: "Durchschnitt: 0,42 °C"
        // ----------------------------------------------------------

        Console.WriteLine("--- Monatsdurchschnitt ---");

        // TODO Aufgabe 2 – dein Code hier:
        double summe = 0;
        for (int i = 0; i < temperaturen.Length; i++)
        {
            summe += temperaturen[i];
        }
        double durchschnitt = summe / temperaturen.Length;
        Console.WriteLine($"Durchschnitt: {durchschnitt:F2} °C");




        Console.WriteLine();


        // ----------------------------------------------------------
        // AUFGABE 3 (★★☆) – Kältester und wärmster Tag
        // ----------------------------------------------------------
        // Finde den kältesten und den wärmsten Tag des Monats.
        // Gib Temperatur UND Tagnummer (1-basiert) aus.
        // Format: "Kältester Tag: Tag  6 mit -5,7 °C"
        //         "Wärmster Tag:  Tag 23 mit  5,1 °C"
        // Hinweis: Initialisiere min/max mit dem ersten Element!
        //          KEINE Verwendung von Array.Sort() oder LINQ.
        // ----------------------------------------------------------

        Console.WriteLine("--- Extremwerte ---");

        // TODO Aufgabe 3 – dein Code hier:
        double minTemp = temperaturen[0];
        double maxTemp = temperaturen[0];
        int minTag = 1;
        int maxTag = 1;
        for (int i = 1; i < temperaturen.Length; i++)
        {
            if (temperaturen[i] < minTemp)
            {
                minTemp = temperaturen[i];
                minTag = i + 1;
            }
            if (temperaturen[i] > maxTemp)
            {
                maxTemp = temperaturen[i];
                maxTag = i + 1;
            }
        }
        Console.WriteLine($"Kältester Tag: Tag {minTag,2} mit {minTemp,5:F1} °C");
        Console.WriteLine($"Wärmster Tag:  Tag {maxTag,2} mit {maxTemp,5:F1} °C");



        Console.WriteLine();


        // ----------------------------------------------------------
        // AUFGABE 4 (★★☆) – Frosttage zählen
        // ----------------------------------------------------------
        // Zähle, an wie vielen Tagen die Temperatur unter 0 °C lag
        // (Frosttage). Gib zusätzlich alle Frosttage einzeln aus.
        // Format: "Frosttage gesamt: 14"
        //         "  -> Tag  1: -3,2 °C"
        //         "  -> Tag  6: -5,7 °C"
        //         ...
        // ----------------------------------------------------------

        Console.WriteLine("--- Frosttage ---");

        // TODO Aufgabe 4 – dein Code hier:
        int frosttage = 0;
        for (int i = 0; i < temperaturen.Length; i++)
        {
            if (temperaturen[i] < 0)
            {
                frosttage++;
                Console.WriteLine($"  -> Tag {i + 1,2}: {temperaturen[i],5:F1} °C");
            }
        }
        Console.WriteLine($"Frosttage gesamt: {frosttage}");



        Console.WriteLine();


        // ----------------------------------------------------------
        // AUFGABE 5 (★★★) – Längste Kältephase (Strähne)
        // ----------------------------------------------------------
        // Finde die längste zusammenhängende Periode, in der die
        // Temperatur durchgehend unter 0 °C blieb.
        // Gib Startag, Endtag und Länge der Periode aus.
        // Format: "Längste Kältephase: Tag 6 bis Tag 10 (5 Tage)"
        //
        // Denkanstoß: Brauchst du eine oder zwei Schleifen?
        //             Wie merkst du dir Start und Länge der
        //             BISHER längsten Periode?
        // ----------------------------------------------------------

        Console.WriteLine("--- Längste Kältephase ---");

        // TODO Aufgabe 5 – dein Code hier:

        int aktuelleLaenge = 0;
        int besteLaenge = 0;
        int aktuelleStart = 0;
        int besteStart = 0;
        int besteEnde = 0;
        for (int i = 0; i < temperaturen.Length; i++)
        {
            if (temperaturen[i] < 0)
            {
                if (aktuelleLaenge == 0)
                {
                    aktuelleStart = i + 1; // Starttag (1-basiert)
                }
                aktuelleLaenge++;
            }
            else
            {
                if (aktuelleLaenge > besteLaenge)
                {
                    besteLaenge = aktuelleLaenge;
                    besteStart = aktuelleStart;
                    besteEnde = i; // Endtag ist der letzte Frosttag
                }
                aktuelleLaenge = 0; // Reset für die nächste Periode
            }
        }



        Console.WriteLine();


        // ----------------------------------------------------------
        // AUFGABE 6 (★★★) – Temperaturtendenz (Vergleich mit Vortag)
        // ----------------------------------------------------------
        // Gib für jeden Tag (ab Tag 2) aus, ob es wärmer, kälter
        // oder gleich warm war wie am Vortag.
        // Format: "Tag  2: -1,8 °C  ↑ wärmer   (+1,4 °C)"
        //         "Tag  6: -5,7 °C  ↓ kälter   (-5,3 °C)"
        //         "Tag  X:  0,0 °C  = gleich   ( 0,0 °C)"
        //
        // Hinweis: Differenz = temperaturen[i] - temperaturen[i-1]
        //          Verwende ein if/else if/else für die Pfeile.
        // ----------------------------------------------------------

        Console.WriteLine("--- Tägliche Tendenz ---");

        // TODO Aufgabe 6 – dein Code hier:

        for (int i = 1; i < temperaturen.Length; i++)
        {
            double differenz = temperaturen[i] - temperaturen[i - 1];
            if (differenz > 0)
            {
                Console.WriteLine($"Tag {i + 1,2}: {temperaturen[i]:F1} °C wärmer ({differenz:+0.0;-0.0} °C)");
            }

        }

        Console.WriteLine();
        Console.WriteLine("=== Programmende ===");
    }
}
