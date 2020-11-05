using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetIntBsp
{
    class Program
    {
        static void Main(string[] args)
        {
            int eineVariable = 0;

            eineVariable = GetInt("Bitte Länge eingeben: ");
            Console.WriteLine("Länge =" + eineVariable);

            double gewicht = GetDouble("Gewicht eingeben: ");
            Console.WriteLine($"Das Gewicht ist {gewicht}.");

            DateTime gebDate = GetDateTime("Geburtsdatum eingeben: ");
            Console.WriteLine($"Sie sind {DateTime.Now.Year - gebDate.Year} Jahre alt.");



        }

        /// <summary>
        /// Reads an integer value from console input.
        /// </summary>
        /// <param name="inputPrompt"></param>
        /// <returns>Input value as integer</returns>
        static int GetInt(string inputPrompt)
        {
            int userInputValue = 0;

            bool userInputIsValid = false;
            
            do
            {
                Console.Write(inputPrompt);
                try
                {
                    userInputValue = int.Parse(Console.ReadLine());
                    userInputIsValid = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");

                }
            }
            while (!userInputIsValid);

            return userInputValue;
        }
        /// <summary>
        /// Reads a Double value from console input.
        /// </summary>
        /// <param name="inputPrompt"></param>
        /// <returns></returns>
        static double GetDouble(string inputPrompt)
        {
            double userInputValue = 0.0;

            bool userInputIsValid = false;
            do
            {
                Console.Write(inputPrompt);
                try
                {
                    userInputValue = double.Parse(Console.ReadLine());
                    userInputIsValid = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");

                }
            }
            while (!userInputIsValid);

            return userInputValue;
        }
        /// <summary>
        /// Reads a string value from console input.
        /// </summary>
        /// <param name="inputPrompt"></param>
        /// <returns></returns>
        static string GetString(string inputPrompt)
        {
            string userInputValue = string.Empty;
            Console.WriteLine(inputPrompt);
            userInputValue = Console.ReadLine();
            return userInputValue;
        }
        /// <summary>
        /// Reads a DateTime value from console input. The input format must be dd.MM.yyyy hh:mm:ss
        /// </summary>
        /// <param name="inputPrompt"></param>
        /// <returns></returns>
        static DateTime GetDateTime(string inputPrompt)
        {
            DateTime userInputValue = DateTime.MinValue;
            bool userInputIsValid = false;

            string inputFormat = "dd.MM.yyyy hh:mm:ss";
            
            do
            {
                Console.Write(inputPrompt);
                try
                {
                    // da Datums von Land zu Land unterschiedlich angegeben werden ... prüfen wir mit ParseExact ... ob die Eingabe dem gewünschten Format entspricht
                    // die unterschiedlichen Formate zb. unter https://docs.microsoft.com/en-us/dotnet/standard/base-types/custom-date-and-time-format-strings
                    userInputValue = DateTime.ParseExact(Console.ReadLine(), inputFormat, CultureInfo.InvariantCulture);
                    userInputIsValid = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");

                }
            }
            while (!userInputIsValid);

            return userInputValue;
        }

    }
}
