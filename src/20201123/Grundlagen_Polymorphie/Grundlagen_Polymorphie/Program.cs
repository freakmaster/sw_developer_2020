using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grundlagen_Polymorphie.Types;

namespace Grundlagen_Polymorphie
{
    class Program
    {
        static void Main(string[] args)
        {
            // 
            Vehicle[] myVehicleList = new Vehicle[]
            {
                new Vehicle(),
                new Vehicle("Badmobile", "Black Edition", 250),
                new Plane("F16", "Euro-Fighter", 2500, 20000.0),
                new Car("VW" ,"Rabbit Golf" , 120, 100)
            };


            //Hauptprogramm
            //foreach (var vehicle in myVehicleList)
            //{
            //    Display(vehicle);
            //}

            Console.WriteLine(myVehicleList[3].GetInfoString());


        }

        private static void Display(Vehicle vehicle)
        {
            Console.WriteLine(vehicle.GetInfoString());
            Console.WriteLine();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
