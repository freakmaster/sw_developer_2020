using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EingabeDezimalWerte
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variablen deklarieren und Wert zuweisen
            double a = 0;
            double b = 0;
            double erg = 0;
            string input = String.Empty;

            
            Console.WriteLine("#########################################");
            Console.WriteLine("         Flächen Berechnung              ");
            Console.WriteLine("#########################################");

            // Wert für a einlesen und string in double umwandeln
            Console.WriteLine("\n Bitte Seiten längen angeben:");
            Console.Write("\n\t a: ");
            input = Console.ReadLine();

            a = double.Parse(input);

            // Wert für b einlesen und string in double umwandeln
            Console.Write("\n\t b: ");
            input = Console.ReadLine();

            // berechnen der Fläche
            b = double.Parse(input);

            erg = a * b;

            Console.WriteLine("\n Fläche des Rechtecks ({0} x {1}): {2}", a, b, erg);
            // Console.WriteLine($"\n Fläche des Rechtecks ({a} x {b}): {erg}"); // .... wäre auch möglich

        }
    }
}
