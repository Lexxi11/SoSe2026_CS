using System.Net.Http.Headers;

namespace SoSe2026_CS
{
    internal class ArithmetischeOP
    {
        public static void Start()
        {
            Console.WriteLine("###### Arithmetische Operationen ######");

            // => Mathematische Möglichkeiten
            // Addieren:    +

            Console.Write("19+5= ");
            Console.Write(19 + 5);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Writeline wird erst NACH dem befehl zum Zeilenumbruch gezwungen");
            Console.WriteLine(42 + 652);
            Console.WriteLine(51 + 82);
            // Console.WriteLine("19+5");text wird ausgegeben weil "-"

            //Subtrahieren: -
            Console.WriteLine(652 - 42);
            Console.WriteLine(82 - 51);

            //Multiplizieren:   *
            Console.WriteLine(21 * 7);
            Console.WriteLine(63 * 4);

            //Dividieren:   /
            Console.Write("81/9= ");//Write macht keinen Zeilenumbruch
            Console.WriteLine(81 / 9);
            Console.Write("72/5= ");
            Console.WriteLine(72.0 / 5);
            Console.WriteLine("Erst ein Punkt hinter der Zahlenangabe, macht es möglich in VS die Zahlenausgabe als Komma zu schreiben");

            //Modulo-Operator:  %
            Console.WriteLine(5 % 2);
            Console.WriteLine(22 % 26 % 25);
            Console.WriteLine(123 % 7);
            Console.WriteLine(5%123);

            //Math-Klasse:
            Console.WriteLine(Math.Abs(-42)); // Absolut bzw. Betrag 
            Console.WriteLine(Math.Sqrt(144)); // Squareroot <==> Quadratwurzel
            Console.WriteLine(Math.Pow(42, 2)); //Power ==> Potenz
            Console.WriteLine(Math.Round(144.23456456, 2));  // Runden, Nachkommastelle


            //Farben in der Console:
            //Console.ForegroundColor = ConsoleColor.Blue;
            //Console.WriteLine("Text");
            //Console.ResetColor();
            //Console.WriteLine("\u001b[31mRot\u001b[0m normal");






        }
    }
}
