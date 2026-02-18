namespace SoSe2026_CS
{
    internal class testlol
    {
        public static void Start()
        {
            PrintHeader("Arithmetische Operationen");

            // Addition
            PrintOperation("19 + 5", 19 + 5);
            PrintOperation("42 + 652", 42 + 652);
            PrintOperation("51 + 82", 51 + 82);

            PrintNote("WriteLine schreibt automatisch am Ende einen Zeilenumbruch.");

            // Subtraktion
            PrintOperation("652 - 42", 652 - 42);
            PrintOperation("82 - 51", 82 - 51);

            // Multiplikation
            PrintOperation("21 * 7", 21 * 7);
            PrintOperation("63 * 4", 63 * 4);

            // Division
            PrintOperation("81 / 9", 81 / 9);
            PrintOperation("72.0 / 5", 72.0 / 5);
            PrintNote("Mit einer Kommazahl (z.B. 72.0) wird 'double'-Division gemacht.");

            // Modulo
            PrintOperation("5 % 2", 5 % 2);
            PrintOperation("22 % 26 % 25", 22 % 26 % 25);
            PrintOperation("123 % 7", 123 % 7);
            PrintOperation("5 % 123", 5 % 123);

            PrintSeparator();

            // Math class
            PrintHeader("Math-Klasse");
            PrintOperation("Math.Abs(-42)", Math.Abs(-42));
            PrintOperation("Math.Sqrt(144)", Math.Sqrt(144));
            PrintOperation("Math.Pow(42, 2)", Math.Pow(42, 2));
            PrintOperation("Math.Round(144.23456456, 2)", Math.Round(144.23456456, 2));

            PrintSeparator();

            // Console colors (optional)
            PrintHeader("Farben in der Console (optional)");
            PrintColoredLine("INFO: Das ist blau", ConsoleColor.Blue);
            PrintColoredLine("WARN: Das ist gelb", ConsoleColor.Yellow);
            PrintColoredLine("ERROR: Das ist rot", ConsoleColor.Red);

            // ANSI example (works only in terminals that support it)
            Console.WriteLine("\u001b[32mANSI Grün\u001b[0m normal");
        }

        // ---------- Helper Methods ----------

        private static void PrintHeader(string title)
        {
            PrintSeparator();
            Console.WriteLine($"###### {title} ######");
            PrintSeparator();
        }

        private static void PrintSeparator()
        {
            Console.WriteLine(new string('#', 40));
        }

        private static void PrintOperation(string expression, object result)
        {
            Console.WriteLine($"{expression,-20} = {result}");
        }

        private static void PrintNote(string text)
        {
            Console.WriteLine();
            Console.WriteLine($"[NOTE] {text}");
            Console.WriteLine();
        }

        private static void PrintColoredLine(string text, ConsoleColor color)
        {
            var oldColor = Console.ForegroundColor;
            Console.ForegroundColor = color;

            Console.WriteLine(text);

            Console.ForegroundColor = oldColor; // safer than ResetColor() if background was changed
        }
    }
}
