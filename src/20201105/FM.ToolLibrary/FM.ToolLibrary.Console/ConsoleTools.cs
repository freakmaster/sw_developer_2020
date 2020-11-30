using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.ToolLibrary.ConsoleIo
{
    public abstract class ConsoleTools
    {
        /// <summary>
        /// Generates colored messages for the console output
        /// </summary>
        /// <param name="message">The message to display</param>
        /// <param name="messageColor">The color of the message</param>
        public static void DisplayColoredMessage(string message, ConsoleColor messageColor)
        {
            ConsoleColor oldColor = Console.ForegroundColor;
            Console.ForegroundColor = messageColor;

            Console.WriteLine(message);

            Console.ForegroundColor = oldColor;
        }

        /// <summary>
        /// Generates yellow messages for the console output
        /// </summary>
        /// <param name="message">The message to display</param>

        public static void DisplayColoredMessage(string message)
        {
            DisplayColoredMessage(message, ConsoleColor.Yellow);
        }


        /// <summary>
        /// Reads an integer value from console input.
        /// </summary>
        /// <param name="inputPrompt">Prompt for the user</param>
        /// <returns>Input value as integer</returns>
        public static int GetInt(string inputPrompt, DisplayErrorHandler displayErrorHandler)
        {
            int userInputValue = 0;
            bool userInputIsValid = false;

            do
            {
                Console.Write(inputPrompt);
                try
                {
                    //read input value and convert to int
                    userInputValue = int.Parse(Console.ReadLine());
                    userInputIsValid = true;
                }
                catch (Exception ex)
                {
                    //Aufruf der Methode aus dem delegate
                    displayErrorHandler(ex.Message);
                    userInputIsValid = false;
                }
            }
            while (!userInputIsValid);

            return userInputValue;
        }

        /// <summary>
        /// Reads an double value from console input.
        /// </summary>
        /// <param name="inputPrompt">Prompt for the user</param>
        /// <returns></returns>
        public static double GetDouble(string inputPrompt)
        {
            double userInputValue = 0;
            bool userInputIsValid = false;

            do
            {
                Console.Write(inputPrompt);
                try
                {
                    //read input value and convert to double
                    userInputValue = double.Parse(Console.ReadLine());
                    userInputIsValid = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    userInputIsValid = false;
                }
            }
            while (!userInputIsValid);

            return userInputValue;
        }

        /// <summary>
        /// Reads a DateTime value from console input.
        /// </summary>
        /// <param name="inputPrompt">Prompt for the user</param>
        /// <returns></returns>
        public static DateTime GetDateTime(string inputPrompt)
        {
            DateTime userInputValue = DateTime.MinValue;
            bool userInputIsValid = false;

            do
            {
                Console.Write(inputPrompt);
                try
                {
                    //read input value and convert to DateTime
                    userInputValue = DateTime.Parse(Console.ReadLine());
                    userInputIsValid = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    userInputIsValid = false;
                }
            }
            while (!userInputIsValid);

            return userInputValue;
        }
        /// <summary>
        /// Reads a DateTime value from console input with specified format
        /// </summary>
        /// <param name="inputPrompt"></param>
        /// <returns></returns>
        public static DateTime GetDateTime(string inputPrompt, string inputFormat)
        {
            DateTime userInputValue = DateTime.MinValue;
            bool userInputIsValid = false;
            
            //string inputFormat = "dd.MM.yyyy hh:mm:ss";

            do
            {
                Console.Write(inputPrompt);
                try
                {
                    //read input value and convert to DateTime
                    userInputValue = DateTime.ParseExact(Console.ReadLine(), inputFormat, CultureInfo.InvariantCulture);
                    userInputIsValid = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    userInputIsValid = false;
                }
            }
            while (!userInputIsValid);

            return userInputValue;
        }

        /// <summary>
        /// Reads an string value from console input.
        /// </summary>
        /// <param name="inputPrompt">Prompt for the user</param>
        /// <returns></returns>
        static string GetString(string inputPrompt)
        {
            Console.Write(inputPrompt);

            //read input value and convert to string
            return Console.ReadLine();
        }

        public static void MakeHeader(string headerText)
        {
            int headerXPosition = 0;

            Console.WriteLine(new string ('#', Console.WindowWidth - 1));
            headerXPosition = (Console.WindowWidth - headerText.Length) / 2;
            Console.CursorLeft = headerXPosition;
            Console.WriteLine(headerText);
            Console.WriteLine(new string ('#', Console.WindowWidth - 1));
        }
        
    }
}