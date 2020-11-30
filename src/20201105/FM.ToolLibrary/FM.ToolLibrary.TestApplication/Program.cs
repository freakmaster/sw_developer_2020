using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FM.ToolLibrary.ConsoleIo;

namespace FM.ToolLibrary.TestApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            /*ConsoleTools.MakeHeader("DAS ist die ÜBERSCHRIFT");

            ConsoleTools.DisplayColoredMessage("Dies ist ein Test...", ConsoleColor.Red);
            ConsoleTools.DisplayColoredMessage("Dies ist ein Test...");

            // double val1 = ConsoleTools.GetDouble("Bitte Wert eingeben (Double) ");

            DateTime date1 = ConsoleTools.GetDateTime("Bitte geben Sie ein Datum(dd.MM.YY) ein: ", "dd.MM.yy");

            Console.ReadLine();
            */

            // DisplayErrorOnSameLine ... ist ein delegate
            var geburtsJahr = ConsoleTools.GetInt("Bitte Jahr eingeben: ", DisplayErrorOnSameLine);
            
        }

        static void DisplayInputError(string errorMessage)
        {
            ConsoleTools.DisplayColoredMessage(errorMessage, ConsoleColor.Red);
        }

        static void DisplayErrorOnSameLine(string errorMessage)
        {
            var oldYposition = Console.CursorTop;
            Console.SetCursorPosition(0, Console.WindowHeight - 3);

            ConsoleTools.DisplayColoredMessage(errorMessage, ConsoleColor.Red);
            Console.ReadLine();

            //löschen der Fehlermeldung
            Console.SetCursorPosition(0, Console.WindowHeight - 3);
            Console.WriteLine(new string(' ', errorMessage.Length));


            Console.SetCursorPosition(0, oldYposition);
        }

    }
}
