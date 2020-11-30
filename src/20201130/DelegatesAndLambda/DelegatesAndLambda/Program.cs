using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndLambda
{
    // Type Spezifikation ... Schlüsselwort delegate ... die Bezeichung des Datentypes DoSomethingHandler
    public delegate void DoSomethingHandler(string message);

    class Program
    {
        static void Main(string[] args)
        {
            DoSomethingHandler myAction;
            DoSomethingHandler[] myActionList = new DoSomethingHandler[2];

            // Methode als WERT zuweisen

            myAction = CreateOutput;
            myAction("Hallo");
            // ich kann auch Methoden in Arrays ablegen
            myActionList[0] = DisplayMessage;
            myActionList[1] = CreateOutput;

            //Methode über delegate aufrufen .... der Aufruf bleibt gleich aber liefert eine andere Methode ... DisplayMessage oder CreateOutput
            myAction("HaLLO Welt!");



            foreach (var method in myActionList)
            {
                Console.WriteLine($"Invoke: {method.Method.Name}:");
                method("Wie cool ist das denn?");
                Console.WriteLine();

            }
        }



            static void CreateOutput(string text)
            {
                Console.WriteLine("...creating output now:");
                Console.WriteLine("\t{0}", text.ToUpper());
            }



            static void DisplayMessage(string userMessage)
            {
                Console.WriteLine(userMessage);
            }

        }
}

