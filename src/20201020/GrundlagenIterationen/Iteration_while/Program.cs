using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration_while
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string input = string.Empty;


            // while ist Kopf gesteuert ... kann sein dass auch nie ausgeführt wird ... falls string input ="q" statt Empty vorgegeben wird
            while(input != "q")
            {
                Console.Write("[while]: Bitte geben Sie etwas ein: ");
                input = Console.ReadLine();
            }

            // do while ist Fuß gesteuert ... wird immer mind. 1x ausgeführt
            do
            {
                Console.Write("[do while]: Bitte geben Sie etwas ein: ");
                input = Console.ReadLine();
            }
            while (input != "q");

        }
    }
}
