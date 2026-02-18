using System.Xml;

namespace SoSe2026_CS
{
    internal class LogischeOP
    {
        public static void Start()
        {
            Console.WriteLine("####### Logische Operationen #######");
            
            //Kleiner <
            Console.WriteLine(42 < 666);
            Console.WriteLine(6 * 6 < 5 * 7);
            //Größer >
            Console.WriteLine(77 > 11 * 7);
            Console.WriteLine(99 > 6 + 3 + 5 + 4 + 8 + 5 + 3 + 3 + 45 + 2);
            //Größer/Kleiner Gleich >= / <=
            Console.WriteLine(0 >= 0);
            Console.WriteLine(5 - 2 + 5 - 7 + 3 <= 666);
            //Nicht (Umkehrung) / (Negation)
            Console.WriteLine(!true);
            Console.WriteLine(42 != 42);
            //Verknüpfungen:
            //Oder: || "Alt+Gr <"  | "Strg+Alt <"
            Console.WriteLine(7 > 7 || 8 > 8);
            Console.WriteLine(2 == 3 || 32 < 42 || 666 <= 3 || true);

            //Und:  &&
            Console.WriteLine(12 > 2 && 6 < 12);
            Console.WriteLine(2 > 1 && 66 % 2 == 0 && 42 * 3 <= 5 * 66);




        }
    }
}
