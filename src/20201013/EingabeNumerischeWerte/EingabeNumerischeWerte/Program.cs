﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EingabeNumerischeWerte
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variablen deklarieren und Werte zuweisen
            int geburtsJahr = 0;
            int alter = 0;
            string input = string.Empty;

            //Geburtsjahr einlesen
            Console.Write("Bitte Geburtsjahr eingeben: ");
            input = Console.ReadLine();

            // der String geburtsJahr wird in eine Integer umgewandelt
            geburtsJahr = int.Parse(input);

            // Alter berechnen
            alter = DateTime.Now.Year - geburtsJahr;

            //Ausgabe Ergebnis
            Console.WriteLine($"Sie sind {alter} Jahre jung!");
                                          
        }
    }
}
