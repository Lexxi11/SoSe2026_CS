using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoSe2026_CS
{
    internal class Aufgabe13
    {
        public static void Start()
        {
            int[] zahlen = { 70, 30, 89, 13 };
            zahlen[2] = 110;
            zahlen[3] = zahlen[3] + 17;
            for (int i = 0; i < zahlen.Length; i++)
            {
                zahlen [i] = zahlen[i] / 5;
            }
            int[] neuesArray = new int[6];
            for (int i = 0; i < zahlen.Length; i++)
            {
                neuesArray[i] = zahlen[i];
            }
            neuesArray[4] = 200;
            neuesArray[5] = 500;
            for (int i = 0; i < neuesArray.Length; i++)
            {
                neuesArray[i] = neuesArray[i] * 2;

            }
            for (int i = 0; i < neuesArray.Length; i++)
            {
                Console.WriteLine(neuesArray[i]);
            }
        }
    }
}
// Array = Liste von werten über die man per index zugreifen kann
//0=70 1=30 2=89 3=13
// erster index = 0
// zahlen[2] = 110; // 89 wird durch 110 ersetzt
// int i = 0 -> schelife startet im 1. Element
// i < zahlen.Length -> solange i kleiner als die Anzahl der Elemente im Array ist, läuft die Schleife weiter
// i++ -> i wird um 1 erhöht, damit die Schleife zum nächsten Element im Array weitergeht
// zahlen.Length -> gibt die anzahl der Elemente im Array zurück, hier 4


// Ein Array ist eine Liste von Elementen eines Dateityps, der Index startet bei 0
// mit einer for Schleife kann man automatisch über alle Elemente eines Arraya laufen. 
// Die Schleife startet bei 0, läuft solange der index kleiner als die länge des arrays ist und erhöht den index nach jedem durchlauf mit i++
//dadurch kann man jedes Element im Array einzeln bearbeiten, hier wird jedes Element durch 5 geteilt und in einem neuen Array gespeichert, das dann mit 200 und 500 gefüllt wird und jedes Element mit 2 multipliziert wird. Am Ende werden alle Elemente des neuen Arrays ausgegeben.
