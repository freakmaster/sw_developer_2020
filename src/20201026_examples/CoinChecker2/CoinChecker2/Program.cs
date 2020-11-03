using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinChecker2
{
    class Program
    {
        static void Main(string[] args)
        {
            double amount = 0;
            string input = string.Empty;
            bool inputIsValide = true;


            do
            {
                Console.Write("Bitte geben Sie einen Betrag in EURO ein: ");
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


            if (inputIsValide)
            {
                amount = double.Parse(input);
            }
            else
            {
                Console.WriteLine("Bitte nur Zahlen eingeben");
            }

            switch (amount)
            {
                case 5:
                    Console.WriteLine($"Der Betrag {amount} ist gültig");
                    break;
                case 10:
                    Console.WriteLine($"Der Betrag {amount} ist gültig");
                    break;
                case 20:
                    Console.WriteLine($"Der Betrag {amount} ist gültig");
                    break;
                case 50:
                    Console.WriteLine($"Der Betrag {amount} ist gültig");
                    break;
                case 100:
                    Console.WriteLine($"Der Betrag {amount} ist gültig");
                    break;
                case 200:
                    Console.WriteLine($"Der Betrag {amount} ist gültig");
                    break;
                default:
                    Console.WriteLine($"Der Betrag {amount} ist nicht gültig");
                    break;
            }

        }
    }
}
