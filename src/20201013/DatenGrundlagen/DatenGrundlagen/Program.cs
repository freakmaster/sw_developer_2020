using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatenGrundlagen
{
    class Program
    {
        static void Main(string[] args)
        {
            // Deklaration
            int zahl;

            //Initialisierung
            zahl = 0;


            // Deklaration u. Initialisierung
            int zahl1 = 5;
            
            zahl = int.MaxValue;

            Console.WriteLine(zahl);

            // Dezimalzahlen: float ... nur 8 Nachkommastellen, double ... hat 32 Dezimalstellen, decimal ... ganz genau
            double size_x = 15.321;

            // decimal mit m am Schluß weil ... 15.50 wird Standartmäßig als double erkannt und führt sonst zu Fehler 
            decimal preis = 15.50m;

            Console.WriteLine("Size X = " + size_x);
            Console.WriteLine("Preis = " + preis);

            // Zeichenketten sind strings
            string name = "Gandalf";

            name = "";
            name = string.Empty;

            // ein einziges Zeichen wäre char
            char symbole = 'a';

            // nur true oder false; .... da die Variable aus mehreren Wörtern bestehen ... Camelcase
            bool isPowerOn = true;



        }
    }
}
