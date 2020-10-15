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
            int headerXPosition = 0;
            string headerText = "Flächenberechnung";


            // Signatur der Methode lesen ... 2 Möglichkeiten ... void bedeutet gibt nichts zurück(=Datentyp)...oder Frequenz und Dauer übergeben 
            //Console.Beep();
            //Console.Beep(1000, 10000);


            // create Header
            Console.WriteLine(new string('#', Console.WindowWidth - 1));
            headerXPosition = (Console.WindowWidth - headerText.Length) / 2;
            Console.CursorLeft = headerXPosition;
            Console.WriteLine("Flächenberechnung");
            Console.WriteLine(new string('#', Console.WindowWidth - 1));

            // Wert für a einlesen und string in double umwandeln
            Console.WriteLine("\n Bitte Seiten längen angeben:");
            Console.Write("\n\t a: ");

            // try und catch gehören immer zusammen ... es darf nichts dazwischen stehen ... nicht optimiert
            try
            {
                a = double.Parse(input = Console.ReadLine());

                // Wert für b einlesen und string in double umwandeln
                Console.Write("\n\t b: ");
                b = double.Parse(input = Console.ReadLine());
            }
            catch (Exception e) 
            {
                Console.WriteLine("Uuups! Leider ist was schief gelaufen.");
                Console.WriteLine(e.Message);

                Console.WriteLine("Source: \n" + e.StackTrace);

                Environment.Exit(1);
            }
            
            // berechnen der Fläche und anzeigen
            erg = a * b;

            Console.WriteLine("\n Fläche des Rechtecks ({0} x {1}): {2}", a, b, erg);
            // Console.WriteLine($"\n Fläche des Rechtecks ({a} x {b}): {erg}"); // .... wäre auch möglich
            

//            finally
//            {

//            }
            Console.WriteLine("Programm Ende!");
            
        }
    }
}
