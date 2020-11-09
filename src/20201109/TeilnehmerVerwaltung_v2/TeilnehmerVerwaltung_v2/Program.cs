using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FM.ToolLibrary.ConsoleIo;

namespace TeilnehmerVerwaltung_v2
{
    class Program
    {
        public struct Teilnehmer
        {
            public Guid TeilnehmerID;
            public string Vorname;
            public string Nachname;
            public string Strasse;
            public string HausNr;
            public int PLZ;
            public string Ort;
            public DateTime GeburtsDatum;
        }

        /// <summary>
        /// Liest einen Teilnehmer ein
        /// </summary>
        /// <param name="anzahlTeilnehmer">Anzahl der Einzulesenden Teilnehmer</param>
        /// <returns></returns>
        public static Teilnehmer[] GetTeilnehmer(int anzahlTeilnehmer)
        {
            Teilnehmer[] teilnehmer = new Teilnehmer[anzahlTeilnehmer];
            for (int i = 0; i < anzahlTeilnehmer; ++i)
            {
                teilnehmer[i].TeilnehmerID = Guid.NewGuid();
                teilnehmer[i].Vorname = ConsoleTools.GetString($"Bitte Vorname von Teilnehmer angeben: ");
                teilnehmer[i].Nachname = ConsoleTools.GetString($"Bitte Nachname von Teilnehmer {teilnehmer[i].Vorname} angeben: ");
                teilnehmer[i].Strasse = ConsoleTools.GetString($"Bitte Strasse von Teilnehmer {teilnehmer[i].Vorname} angeben: ");
                teilnehmer[i].HausNr = ConsoleTools.GetString($"Bitte HausNr von Teilnehmer {teilnehmer[i].Vorname} angeben: ");
                teilnehmer[i].PLZ = ConsoleTools.GetInt($"Bitte PLZ von Teilnehmer {teilnehmer[i].Vorname} angeben: ");
                teilnehmer[i].Ort = ConsoleTools.GetString($"Bitte Ort von Teilnehmer {teilnehmer[i].Vorname} angeben: ");
                teilnehmer[i].GeburtsDatum = ConsoleTools.GetDateTime($"Bitte Geburtsdatum von Teilnehmer {teilnehmer[i].Vorname} angeben: ", "dd.MM.yyyy");
            }

            return teilnehmer;
        }

        /// <summary>
        /// Gibt die
        /// </summary>
        /// <param name="teilnehmer"></param>
        /// <returns></returns>
        public static string PrintTeilnehmer(Teilnehmer[] teilnehmer)
        {
            string text = string.Empty;

            ConsoleTools.DisplayColoredMessage("TeilnehmerID\tVorname\tNachname\tStrasse\tHausNr\tPLZ\tOrt\tGeburtsdatum");
            foreach (Teilnehmer teiln in teilnehmer)
            {
                ConsoleTools.DisplayColoredMessage($"{teiln.TeilnehmerID}\t{teiln.Vorname}\t{teiln.Nachname}\t{teiln.Strasse}\t{teiln.HausNr}\t{teiln.PLZ}\t{teiln.Ort}\t{teiln.GeburtsDatum.ToShortDateString()}");
                text += $"{teiln.TeilnehmerID}\t{teiln.Vorname}\t{teiln.Nachname}\t{teiln.Strasse}\t{teiln.HausNr}\t{teiln.PLZ}\t{teiln.Ort}\t{teiln.GeburtsDatum.ToShortDateString()}\n";
            }

            return text;
        }

        static void Main(string[] args)
        {
            int anzahlTeilnehmer = 0;
            string text = string.Empty;
            string input = string.Empty;


            //Einlesen der Anzahl Teinehemer
            ConsoleTools.DisplayColoredMessage("Willkommen in der Eingabe der Teilnehmerverwaltung.");
            anzahlTeilnehmer = ConsoleTools.GetInt("Bitte Anzahl Teilnehmer angeben: ");

            //Einlesen der Teilnehmer
            Teilnehmer[] teilnehmer = GetTeilnehmer(anzahlTeilnehmer);

            //Tabellarische Ausgabe der Teilnehmer
            text = PrintTeilnehmer(teilnehmer);

            //Abfrage ob Teilnehmer abgespeichert werden sollen
            input = ConsoleTools.GetString("Mochten sie die Teilnehmer abspeichern? (Y/N): ");
            if (input[0] == 'Y' || input[0] == 'y')
            {
                System.IO.File.WriteAllText(".\\Teilnehmer.txt", text);
            }
        }
    }
}