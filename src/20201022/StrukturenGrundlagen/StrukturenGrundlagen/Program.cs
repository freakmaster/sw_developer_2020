using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrukturenGrundlagen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deklaration ... Datentyp=Teilnehmer ... Variablenname=einTeilnehmer ... mit new erzeugen lassen
            Teilnehmer einTeilnehmer = new Teilnehmer();

            //Initialisierung einer struct gleich mit Werten ... man könnte auch zuerst alle leer machen
            einTeilnehmer.Vorname = "Gandalf";
            einTeilnehmer.Nachname = "der Graue";
            einTeilnehmer.Geburtsdatum = new DateTime(1880, 4, 16);

            Console.WriteLine($"{einTeilnehmer.Vorname} {einTeilnehmer.Nachname}");

            Teilnehmer[] meineTeilnehmer;

            Console.WriteLine($"meineTeilnehmer[3].Geburtsdatum");

        }
    }
}
