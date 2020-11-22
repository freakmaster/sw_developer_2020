using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrundlagenVererbung2
{
    class Program
    {
        static void Main(string[] args)
        {
            Sales susi = new Sales("Susi Musterfrau", new DateTime(2000, 5, 19), 1500.8m, 0.15);
            Manager manni = new Manager("Manni Mustermann", new DateTime(2000, 6, 20), 1500.8m, 20);

            Console.WriteLine(susi.GetInfoString());
            Console.WriteLine(manni.GetInfoString());
            Console.WriteLine($"Anteile: {manni.Shares}%");

            manni.AddShares(25);
            Console.WriteLine($"Anteile: {manni.Shares}%");
            manni.RemoveShares(10);
            Console.WriteLine($"Anteile: {manni.Shares}%");

        }
    }
}
