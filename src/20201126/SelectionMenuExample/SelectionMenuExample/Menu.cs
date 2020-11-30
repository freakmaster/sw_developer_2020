using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionMenuExample
{
    public class Menu : IMenu
    {
        // erzeugt eine Liste von Klassen die das Interface IMenuItem implementieren
        private List<IMenuItem> _items;

        public Menu()
        {
            _items = new List<IMenuItem>();
        }

        public int Count
        {
            get { return _items.Count; }
        }

        public void Add(IMenuItem menuItem)
        {
            _items.Add(menuItem);
        }

        public void Remove(IMenuItem menuItem)
        {
            _items.Remove(menuItem);
        }
        public void Display(int width)
        {
            // menuItem ist die Schnittstelle bzw. eine Variable vom Typ IMenuItem ... für jedes item in menuItem soll angezeigt werden
            foreach (var menuItem in _items)
            {
                menuItem.Display(width);
            }
        }

        public IMenuItem SelectItem(string inputPrompt)
        {
            //explizite Wertzuweisung kann hier entfallen wenn unten impliziert wird
            //ConsoleKeyInfo userInput;

            while (true)
            {
                Console.Write(inputPrompt);

                //var impliziert den Datentyp hier
                var userInput = Console.ReadKey(true);

                foreach (var menuItem in _items)
                {
                    if (userInput.Key == menuItem.Code)
                    {
                        return menuItem;
                    }

                }
                Console.WriteLine("Ungültige Eingabe!");
            }
        }
    }
}
