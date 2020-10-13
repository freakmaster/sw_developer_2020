using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrundlagenEingaben
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = string.Empty; // effizient und elegant ........ string name = ""; .... nicht ganz so effizient ... 
            

            Console.Write("Bitte Namen eingeben: ");
            name = Console.ReadLine();


            Console.WriteLine("Hallo " + name + "!");
            Console.WriteLine($"Hallo {name}!");


            // #region ... zusammenklapbar... Code Strukturieren ... markieren und mit rechtsklick ... Snippet usw.

            #region Ausgabe string mit Variablen Inhalten

            //eleganterer Weg Strings mit Variablen auszugeben ... ist zu bevorzugen
            string ausgabe = $"Lieber {name}, {name} ist ein schöner Name!";
            Console.WriteLine(ausgabe);

            //auch möglicher Weg mit Strings und Variablen zu arbeiten 
            Console.WriteLine("Hallo {0}!{1}", name, name);

            int zahl1 = 5;
            int zahl2 = 2;
            int erg = zahl1 + zahl2;

            Console.WriteLine("Rechnung : {0} + {1} = {2}", zahl1, zahl2, erg);
            // oder auch möglich
            Console.WriteLine("Rechnung : {1} + {2} = {0}", erg, zahl1, zahl2);

            //auch möglich bzw. der sicherste Weg
            string newOutputString = string.Format("Rechnung : {1} + {2} = {0}", erg, zahl1, zahl2); 

            #endregion



        }
    }
}
