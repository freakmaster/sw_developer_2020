using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            var testClass = new TestClass();

            try
            {
                testClass.Calculate(0, 5);
            }

            catch(CalculationImpossibleException cex)
            {
                Console.WriteLine("Eine CalculationImpossibleException wurde abgefangen");
                Console.WriteLine($"ERROR: {cex.Message}");
            }
            catch(ArgumentException aex)
            {
                Console.WriteLine("Juhu");
                Console.WriteLine($"ERROR: {aex.Message}");
            }
            // Basisklasse sollte für Exception am Schluss stehen weil hier alles abgefangen ist ... weil sich alle von Exception ableiten
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR: {ex.Message}");
            }
                        
        }
    }
}
