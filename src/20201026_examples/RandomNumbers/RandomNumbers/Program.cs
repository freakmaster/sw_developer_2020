using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int genRand = r.Next(10, 50);
            Console.WriteLine("Random Number = " + genRand);
        }
    }
}
