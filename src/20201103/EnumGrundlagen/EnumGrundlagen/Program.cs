using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumGrundlagen
{
    class Program
    {
        static void Main(string[] args)
        {
            // Enum ist praktisch wenn eine Variable nur bestimmte Werte haben soll .... wird als String gespeichert

            ParticipantState state = ParticipantState.Krank;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("TEST");
            // Consolen Farben sollten wie folgt immer reseted werden
            Console.ResetColor();
            Console.WriteLine("TEST");

            if(state == ParticipantState.Krank)
            {
                Console.WriteLine("Der Typ ist krank");
            }

            Console.WriteLine($"State: {state}");

            // praktisch ist.... wenn man switch schreibt und dann mit TAB weiter geht ... macht VStudio gleich den switch case block für alle möglichen Werte ... voll cool ! 

            switch (state)
            {
                case ParticipantState.Anwesend:
                    break;
                case ParticipantState.Abwesend:
                    break;
                case ParticipantState.Krank:
                    break;
                case ParticipantState.Unbekannt:
                    break;
                case ParticipantState.Abgemeldet:
                    break;
                default:
                    break;
            }

            //eigenes Snippet erstellen ... nur cw schreiben und dann mit TAB TAB ... kann via Tools -> Code Snippet Manager bearbeitet werden oder checken wo auf der Platte das Snippet liegt und anpassen
            Console.WriteLine($"");

        }
    }
}
