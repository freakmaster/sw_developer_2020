using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abfragen
{
    class Program
    {
        static void Main(string[] args)
        {
            int zahl1 = 50;
            int zahl2 = 15;

            if(zahl1 > zahl2)
            {
                Console.WriteLine($"{zahl1} ist größer als {zahl2}.");
            }

            if(DateTime.Now.Month == 10)
            {
                Console.WriteLine("Wir haben Oktober ....");
            }
            else
            {
                Console.WriteLine("keine Ahnung welchen Monat wir haben ....");
            }


            if(zahl1 > zahl2 && DateTime.Now.DayOfWeek == DayOfWeek.Wednesday)
            {
                Console.WriteLine($"{zahl1} ist größer als {zahl2} und es ist Mittwoch");
            }

            //wenn im folgenden Beispiel könnte man auch nur ein & verwenden ... aber falls kein raidSystem existiert wird es auf Fehler laufen
            //.... das && ist viel Performanter, da sobald die erste Bedingung nicht wahr ist gleich in den entsprechenden Codeblock gesprungen wird
            
            //if(raidSystem != null && raidSystem.isFull != true)
            //{
            //    //schreibe neue daten!
            //}

        }
    }
}
