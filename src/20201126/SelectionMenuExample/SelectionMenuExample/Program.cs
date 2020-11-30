using SelectionMenuExample.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionMenuExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu myMenu = new Menu();

            //man könnte sich das Menü auch aus einer Datei holen mit ...Verbesserungsvorschlag
            //myMenu.LoadFromFile("menufile.txt");
            
            
            myMenu.Add(new MenuItem("Daten laden", ConsoleKey.F1));
            myMenu.Add(new MenuItem("Daten speichen", ConsoleKey.F2));
            myMenu.Add(new EmptyItem());
            myMenu.Add(new MenuItem("Daten löschen", ConsoleKey.F3));
            myMenu.Add(new MenuItem("Daten drucken", ConsoleKey.F4));
            myMenu.Add(new EmptyItem());
            myMenu.Add(new ColoredMenuItem("Programm beenden", ConsoleKey.Escape, ConsoleColor.Yellow));
            

            myMenu.Display(35);

            // var impliziert den Datentyp aus der Zuweisung man muss nicht speziell den Typ IMenuItem angeben
            //... es erleichter die Lesbarkeit und es sind keine Änderungen nötig falls sich der Datentyp ändern würde
            var mySelection = myMenu.SelectItem("Ihre Wahl: ");

            Console.WriteLine(mySelection.Description);



        }
    }
}
