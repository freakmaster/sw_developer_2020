using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foreach_Grundlagen
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * anzahl teilnehmer
             * namen + geburtsjahr teilnehmer
             * 
             * tabelarische ansicht der daten
             * 
             * 
             */

            int anzahl = 0;
            string inputanzahl = string.Empty;
            string[] participantNames;

            Console.WriteLine("Bitte geben Sie die Anzahl der Teilnehmer ein: ");
            anzahl = int.Parse(Console.ReadLine());

            //Teilnehmer liste erzeugen und initialisieren

            participantNames = new string[anzahl];

            for (int i = 0; i < participantNames.Length; i++)
            {
                participantNames[i] = string.Empty;
            }

            //Teilnehmernamen einlesen
            for (int i = 0; i < participantNames.Length; i++)
            {
                Console.WriteLine("Bitte geben Sie den Namen des {i + 1}. Teilnehmers ein: ");
                participantNames[i] = Console.ReadLine();
            }


            //Ausgabe der Teilnehmernamen

            Console.WriteLine("\nListe der Teilnehmer");

            /*Lösung mit FOR
             * for (int i = 0; i < participantNames.Length; i++)
            {
                Console.WriteLine($"Namen des {i + 1}. Teilnehmers: {participantNames[i]}");

            }
            */

            //Lösung mit FOREACH .... participant ist quasi nur eine iterations variable und kann nicht geändert werden
            foreach(string participant in participantNames)
            {
                Console.WriteLine($"\t{participant}");
            }



        }
    }
}
