using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaGrundlagen
{
    public delegate void DoSomethingHandler(string message);
    class Program
    {
        static void Main(string[] args)
        {
            DoSomethingHandler myAction = DisplayMessage;

            myAction("Hello Welt!");

            // Action sind Microsoft vorbereitete delegates mit bis zu 16 Werten ... ohne Rückgabetyp
            Action<string> myNewAction = DisplayMessage;
            
            

            //anonyme Methode (C# 2.0) ... hat keinen Namen
            myAction = delegate (string userText)
            {
                Console.WriteLine("Ausgabe anonyme Methode:");
                Console.WriteLine(userText);
            };

            myAction("blabla anonyme Methode blabla");

            //anonyme Methode (C# 3.0) Lambda
            myAction = (string userText) =>
            {
                Console.WriteLine("vereinfachte anonyme Methode: ");
                Console.WriteLine(userText);
            };

            // wenn es nur 1 Parameter ist kann man sogar die Klammern bei (userText) weg lassen
            myAction = userText =>
            {
                Console.WriteLine("vereinfachte anonyme Methode: ");
                Console.WriteLine(userText);
            };

            //anonyme Methode => klassicher Lambda Einzeiler
            myAction = x => Console.WriteLine(x);
            {
                myAction("TEST");
            };

            myAction("TEST Lambda");

                       

            int[] zahlenReihe = new int[] { 5, 21, 8, 9, 22, 50, 1, 96 };
            //man müsste für jede Prüfung eine eigene Methode machen
            //zahlenReihe = zahlenReihe.Where(CheckSize).ToArray();

            //mit Lambda expressions kann man die Methode on the fly definieren ... 
            zahlenReihe = zahlenReihe.Where(x => x > 10).ToArray();
            zahlenReihe = zahlenReihe.Select(x => x * x).ToArray();

            List<int> sortedElements = new List<int>();
            foreach (var item in zahlenReihe)
            {
                if (item > 10)
                {
                    sortedElements.Add(item);
                }
            }
            zahlenReihe = sortedElements.ToArray();

            //Function sind delegates von Microsoft vorbereitet aber mit Rückgabetyp
            Func<int, bool> myFunction = CheckSize;

        }

        //Methode die man schreiben müsste ohne Lambda expressions für jeden Check schreiben müsste
        static bool CheckSize(int number)
        {

            return number > 10;
        }


        static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }

    }
}
