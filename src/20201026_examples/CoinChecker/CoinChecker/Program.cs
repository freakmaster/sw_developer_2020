using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            double amount = 0;
            string input = string.Empty;
            bool inputIsValid = true;




            do
            {
                // request amount from user
                Console.Write("Bitte geben Sie einen gültigen Münzbetrag ein: ");
                input = Console.ReadLine();

                //check if input is valid...no empty strings 
                inputIsValid = true;

                if (string.IsNullOrWhiteSpace(input))
                {
                    inputIsValid = false;
                }
                else
                {
                    // check each char of the string whether it's a digit or not
                    for (int i = 0; i < input.Length; i++)
                    {
                        if (!char.IsDigit(input[i]) || char.Equals(input[i], '.'))
                        {
                            inputIsValid = false;
                            break;
                        }
                    }
                }
            }
            while (!inputIsValid);

                amount = double.Parse(input);

                if (amount == 5 || amount == 10 || amount == 20 || amount == 50 || amount == 100 || amount == 200 )
                {
                    Console.WriteLine($"Der Betrag {amount} ist gültig");
                }
                else
                {
                    Console.WriteLine($"Der Betrag {amount} ist ungültig");
                }
            
            Console.Beep(440, 1000);
            Console.Beep(880, 500);
            Console.Beep(1720, 500);
            Console.Beep(3360, 1000);
            Console.Beep(6720, 500);
            Console.Beep(13440, 200);
            Console.Beep(440, 100);



        }
    }
}
