using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrundlagenOperatoren
{
    class Program
    {
        static void Main(string[] args)
        {
            // arithmetische Operatoren
            // + - * / %

            double erg = 0;
            double zahl1 = 5;
            double zahl2 = 2;
            double zahl3 = 81;



            erg = zahl1 + zahl2;
            Console.WriteLine("Ergebnis: " + erg);

            erg = zahl1 / zahl2;
            Console.WriteLine("Ergebnis: " + erg);

            // Restwertdivision ... % = Modulo
            erg = zahl1 % zahl2;
            Console.WriteLine("Ergebnis: " + erg);

            //Deklaration
            double erg1;

            //Wertzuweisung
            erg1 = Math.Sqrt(zahl3);
            Console.WriteLine("Ergebnis: " + erg1);

            //logische Operatoren
            // & = AND
            // | = OR
            // ! = NOT

            bool logikErgebnis = true;
            bool wert1 = true;
            bool wert2 = false;


            logikErgebnis = wert1 & wert2;


            //Vergleichsoperatoren
            //
            // <  >  ==  !=  <=  >=

            bool vergleichErgebnis = 5 > 2;   //= true
            vergleichErgebnis = "Gandalf" == "Atilla";  //=false
            vergleichErgebnis = "GAndalf" != "Atilla"; //=true
            Console.WriteLine("VErgleichsErgebnis: " + vergleichErgebnis);

            // zusammengesetzte Operatoren

            int zahl = 5;
                        
            zahl = zahl + 3;
            // oder elegantere Form
            zahl += 3; // zahl = 11

            zahl -= 5; // zahl = 6
            zahl *= 2; // zahl = 12
            zahl /= 6; // zahl = 2

            Console.WriteLine("Ergebnis von zahl: " + zahl);

            // Inkrement und Dekrementieren
            zahl++;
            zahl--;

            //priorisieren ... wann wird ein Wert erhöht ... prä- und postinkrement ... davor oder danach 

            zahl = 5;
            Console.WriteLine("Zahl: " + zahl);   //  5
            Console.WriteLine("Zahl: " + zahl++); // 5 ... zuerst wird ausgegeben dann wird erhöht
            Console.WriteLine("Zahl: " + zahl++); // 6
            Console.WriteLine("Zahl: " + ++zahl); // 8 ... zuerst wird erhöht dann wird ausgegeben
            Console.WriteLine("Zahl: " + zahl++); // 8
            // zahl = 9

                                 
            Console.WriteLine("Ergebnis von zahl: " + zahl);




        }
    }
}
