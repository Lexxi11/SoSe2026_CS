using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SoSe2026_CS
{
    internal class strOperationen
    {
        public static void Start()
        {
            // string str1 = "Hallo";
            // string str2 = "Welt";
            // Console.WriteLine(str1 + " " + str2);
            // Console.WriteLine(str1 + 42);
            // Console.WriteLine("Die Antwort auf die Frage nach dem Leben, dem Universum und allem lautet: " + 42);
            // Console.WriteLine("Die Antwort auf die Frage nach dem Leben, dem Universum und allem lautet: " + (40 + 2));
            // Console.WriteLine("Die Antwort auf die Frage nach dem Leben, dem Universum und allem lautet: " + 40 + 2);


            string vName, nName, mail;
            // string vName = "Roman";
            // string Name = "Tobi";
            // string mail = "email@example.com";
            vName = "Thomas";
            nName = "Teufel";
            mail = "belzebub@hell.com";
            string zusammen = string.Format(" {0} {1} hat die Mail: {2}", vName, nName, mail);
            Console.WriteLine(zusammen);
            string zusammen2 = vName + " " + nName + " hat die Mail: " + mail;
            Console.WriteLine(zusammen2);

            // String -Literal:
            // \n <=> "\n" : new Line => für Zeilenumbruch
            // \t <=> "\t" : tabulator => für Einrückung
            // \" <=> "\"" : Anführungszeichen => um Anführungszeichen in einem String zu verwenden
            // \\ <=> "\\" : Backslash => um einen Backslash in einem String zu verwenden
            // \b <=> "\b" : Backspace => um ein Zeichen zu löschen

            Console.WriteLine("Das \t ist ein Test");
            Console.WriteLine("Das \n ist ein Test");
            Console.WriteLine("Das \"ist ein Test");
            Console.WriteLine("Das \\ist ein Test");
            Console.WriteLine("Das\b ist ein Test");
            Console.WriteLine("########################");
            Console.WriteLine("\n");
            Console.WriteLine("\n");




            string zusammen3 = string.Format("Hallo {0},\n\nwie geht es dir?\n\nViele Grüße,\n{1}", vName, nName);
            Console.WriteLine(zusammen3);


            // C# unterstützte Sonderzeichen als Literalzeichenfolgen:
            int z1 = 42, z2 = 69;
            // $ - interpolierte Zeichenfolge => ermöglicht die direkte Einbettung von Variablen und Ausdrücken in einen String
            string testSTR = $"Die Summe von {z1} und {z2} = {z1 + z2}";
            string testSTR2 = "Die Summe von {z1} und {z2} = {z1 + z2}\nDas ist ein Test";
            Console.WriteLine(testSTR);
            Console.WriteLine(testSTR2);

            // @ - verbatim string literal => ermöglicht die Verwendung von Backslashes und Zeilenumbrüchen ohne Escape-Sequenzen
            string urlString = @"https://www.youtube.com/watch?v=dQw4w9WgXcQ";
            string test = @" \ @ # $ % ^ & * ( ) _ + - = { } [ ] | \ : ; "" ' < > , . ? / ` ~"; //Alle Sonderzeichen in einem String
            Console.WriteLine(test);
            string einLangesWort = "DasIstEinLangesWortOhneLeerzeichen";
            Console.WriteLine(einLangesWort.Length);
            //String.Length => gibt die Anzahl der Zeichen in einem String zurück;
            int anzahlZeichen = einLangesWort.Length;
            Console.WriteLine($"{einLangesWort} hat {anzahlZeichen} Zeichen!");

            // string.ToUpper() => gibt eine neue Zeichenfolge zurück, in der alle Zeichen in Großbuchstaben umgewandelt wurden
            // string.ToLower() => gibt eine neue Zeichenfolge zurück, in der alle Zeichen in Kleinbuchstaben umgewandelt wurden
            string vorname = "Roman";
            Console.WriteLine(vorname);
            vorname = vorname.ToUpper();  // vorname = "ROMAN";
            Console.WriteLine(vorname);   
            Console.WriteLine(vorname.ToLower());

            // string.Trim() => gibt eine neue Zeichenfolge zurück, in der alle führenden und nachfolgenden Leerzeichen entfernt wurden
            string dau = "  Das ist ein Test  lol rofl hhah ";
            Console.WriteLine(dau + "hat die länge" + dau.Length);
            dau = dau.Trim();
            Console.WriteLine(dau + "hat die länge" + dau.Length);



        }

    }
}
