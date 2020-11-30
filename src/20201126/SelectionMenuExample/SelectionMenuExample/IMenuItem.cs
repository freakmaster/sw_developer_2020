using System;

namespace SelectionMenuExample
{
    public interface IMenuItem
    {
        string Description { get; }
        ConsoleKey Code { get; }

        //muss der Code überprüft werden
        //bool Selectable { get; set; }
        
        //welche Menüpunkte sind sichtbar ... natürlich sind unsichtbare Menüpunkte auch nicht auswählbar ... selectable bzw. nur sichtbare sind auch auswählbar
        //bool Visible { get; set; }

        void Display(int width);

    }
}