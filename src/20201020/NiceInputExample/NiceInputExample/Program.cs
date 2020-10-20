using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiceInputExample
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *  Der User soll sein Geburtsjahr eingeben. Daraufhin wird das Alter berechnet und ausgegeben.
             *  -Fehleingaben sollen abgefange werden (Fehlertolerante Eingabe)
             *  -der User soll nach einer Fehleingabe seine Eingae wiederholen dürfen
             *  -die Anzahl der Versuche ist nicht begrenzt
             *  -Gültiges Geburtsjahr:
             *      -nicht in der Zukunft
             *      - PEGI 7+
             *      -nicht vor 1870 (max. 150 Jahre) => 150 Jahre ab heute! 
             * 
             * 
             * 
             * 
             * 
             */

            string input = string.Empty;
            int maxJahr = DateTime.Now.Year - 150;
            int minJahr = DateTime.Now.Year - 7;
            int gebJahr = 0;
            bool validEntry = false;

            while(validEntry != true)
            {
            Console.Write("Bitte geben Sie Ihr Geburtsjahr ein: ");

                input = Console.ReadLine();

                if(string.IsNullOrWhiteSpace(input) == true)
                {
                    validEntry = false;
                }
                else
                {

               
                //ungültige Zeichen erkennen
                    for(int i=0; i<input.Length; i++)
                    {
                        if(char.IsDigit(input[i]) == false)
                        {
                            validEntry = false;
                            break;
                        }
                    }
                }

                if (validEntry == true)
                {
                    gebJahr = int.Parse(input = Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("\aFEHLER: Bitte nur ganze Zahlen eingeben.");
                }
                
                if (gebJahr > maxJahr && gebJahr < minJahr)
                {
                    int alter = DateTime.Now.Year - gebJahr;
                    Console.WriteLine($"\nSie sind {alter} Jahre alt.");
                    validEntry = true;
                }

            }
        }
    }
}
