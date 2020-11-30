using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Grundlagen
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] meineZahlen = InitArray<double>(10, 1.99);

            DateTime[] geburtstage = InitArray<DateTime>(10, DateTime.Now);
        }
        /// <summary>
        /// InitArray ist eine generische Methode bzw. wurde durch <...> generisch gemacht ... im Hintergrund werden im Bsp. durch das System zwei Methoden generiert ...
        /// ich muss sie nur einmal schreiben und überall wo T (steht für type) eingetragen ist wird einmal als double und einmal als DateTime ersetzt ... generics bieten die Möglichkeiten das T durch den Datentyp 
        /// der in <...> steht zu ersetzen 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="elementCount"></param>
        /// <param name="initValue"></param>
        /// <returns></returns>
        static T[] InitArray<T>(int elementCount, T initValue)
        {
            T[] tmpArray = new T[elementCount];

            for (int i = 0; i < tmpArray.Length; i++)
            {
                tmpArray[i] = initValue;
            }

            return tmpArray;
        }
    }
}
