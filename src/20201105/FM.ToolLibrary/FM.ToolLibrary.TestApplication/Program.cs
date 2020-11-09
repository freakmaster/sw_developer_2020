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
            ConsoleTools.MakeHeader("DAS ist die ÜBERSCHRIFT");

            ConsoleTools.DisplayColoredMessage("Dies ist ein Test...", ConsoleColor.Red);
            ConsoleTools.DisplayColoredMessage("Dies ist ein Test...");

            // double val1 = ConsoleTools.GetDouble("Bitte Wert eingeben (Double) ");

            DateTime date1 = ConsoleTools.GetDateTime("Bitte geben Sie ein Datum(dd.MM.YY) ein: ", "dd.MM.yy");

            Console.ReadLine();
            
        }
    }
}
