using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodenGL
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayHello();
            DisplayHello();
            DisplayHello();
            DisplayHello();

            DisplayColoredMessage("Hallo liebe Leute", ConsoleColor.Yellow);
            DisplayColoredMessage("Hallo liebe Leute", ConsoleColor.Green);
            DisplayColoredMessage("Hallo liebe Leute", ConsoleColor.Red);


            //der Inhalt des übergebenen Wertes wird in eine Variable gepackt, die dann ausgegeben wird
            double erg = CalculateWeight(15.5);

            Console.WriteLine(erg);

            string inputPrompt = string.Empty;


            

        }
        
        
        //eine Methode besteht aus .... Rückgabetyp=void Bezeichnung=DisplayHello ( [Parameter] ) ... Parameter ist optional ... jeder Parameter hat einen Datentyp und eine Variable
        //Signatur

        //der graue Text sind Codelets ... 4 references bedeutet das 4x verwendet wurde ... super praktisch
        static void DisplayHello()
        {
            Console.WriteLine("Hello!");


        }

        //Als Parameter werden die Message und die Farbe übergeben
        static void DisplayColoredMessage(string message, ConsoleColor messageColor)
        {
            ConsoleColor oldColor = Console.ForegroundColor;
            Console.ForegroundColor = messageColor;
            
            Console.WriteLine(message);
            Console.ForegroundColor = oldColor;

        }

        //... Parameter müssen übergeben werden AAAABER  der Rückgabewert in diesem Fall result muss nicht verwendet werden
        static double CalculateWeight(double nettoWeight)
        {
            double result = 0.0;

            result = nettoWeight * 1.25;

            // wenn eine Methode einen Wert zurückgeben soll bzw. einen Rückgabewert definieren, dann muss immer mit return zurückgegeben werden
            return result;
            
        }


        
        
        static int GetInt(string inputPrompt)
        {
            
            string input = string.Empty;
            bool inputIsValide = true;
            int output = 0;

            do
            {
                Console.Write("Bitte geben Sie einen Zahl ein: ");
                input = Console.ReadLine();
                inputIsValide = true;

                if (string.IsNullOrWhiteSpace(input))
                {
                    inputIsValide = false;
                    Console.WriteLine("Bitte machen Sie eine Eingabe!");
                }
                else
                {
                    for (int i = 0; i < input.Length; i++)
                    {
                        if (!char.IsDigit(input[i]))
                        {
                            inputIsValide = false;
                            Console.WriteLine("Ungültige Eingabe ! Es dürfen nur Zahlen eingegeben werden !");
                            break;
                        }
                    }
                }
            }
            while (!inputIsValide);
            output = int.Parse(input);
            return output;
            
                                 
        }
        
    }
}
