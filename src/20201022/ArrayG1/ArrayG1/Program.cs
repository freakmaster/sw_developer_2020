using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayG1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deklaration
            int zahl;
            int[] zahlen;

            //Dimensionierung...5 Werte für den Array...kann auch nachträglich nicht vergrößert werden...das Array kann auch erst nach der Dimensionierung verwendet werden
            zahlen = new int[5];

            //Initalisierung
            zahl = -2;

            zahlen[0] = 50;
            zahlen[1] = 0;
            zahlen[2] = 10;
            zahlen[3] = 20;
            zahlen[4] = 30;

            //die folgende Zeile erweitert nicht das Array sondern erzeugt ein neues mit Platz für 6 Werten
            //zahlen = new int[6]

            zahlen[0] = zahlen[1] + zahlen[2];

            //Ausgabe der Inhalte ause dem Array
            
            for (int i=0; i<zahlen.Length-1; i++)
            {
                Console.WriteLine($"Element {i + 1}: {zahlen[i]}");
            }

            

        }
    }
}
