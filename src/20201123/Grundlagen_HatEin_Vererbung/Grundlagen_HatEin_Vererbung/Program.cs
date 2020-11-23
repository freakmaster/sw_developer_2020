using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grundlagen_HatEin_Vererbung
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle myCar = new Vehicle("Badmobil", "Badmobil Black Edition V2", 250);
            myCar.GetInfoString();
            myCar.ChangeRadioPowerState(Power.On);
            Console.WriteLine(myCar.GetInfoString());
            Console.WriteLine();
            myCar.State = VehicleState.Unlocked;
            Console.WriteLine(myCar.GetInfoString());
            myCar.MediaVolume = 8;
            
            Console.WriteLine(myCar.GetInfoString());

            /*
            Car ford = new Car("Ford Mustang", "Supercar", 260, DriveMode.RWD);
            Car honda = new Car("Honda Civic", "BudgetRacer", 220, DriveMode.AWD);
            Plane f16 = new Plane("F16", "Fighter", 2500, 60000.00, 0.0);
            RadioMitCD kennwood = new RadioMitCD(90.5, 5, Power.On, true, 12);
            kennwood.SetVolume(10);
            kennwood.GetInfoString();

            Console.WriteLine($"hat CD: {kennwood.ModeCD} - Track {kennwood.Track} ");

            Console.WriteLine(ford.GetInfoString());
            Console.WriteLine(ford.GetDriveMode());
            Console.WriteLine(honda.GetInfoString());
            Console.WriteLine(honda.GetDriveMode());

            Console.WriteLine();

            Console.WriteLine(f16.GetInfoString());

            Console.WriteLine($"aktuelle Flughöhe: {f16.CurrentAltitude}");
            f16.AddAltitude(5000);
            Console.WriteLine($"aktuelle Flughöhe: {f16.CurrentAltitude}");
            f16.AddAltitude(10000);
            Console.WriteLine($"aktuelle Flughöhe: {f16.CurrentAltitude}");
            f16.AddAltitude(20000);
            Console.WriteLine($"aktuelle Flughöhe: {f16.CurrentAltitude}");
            f16.AddAltitude(30000);
            Console.WriteLine($"aktuelle Flughöhe: {f16.CurrentAltitude}");
            f16.AddAltitude(-20000);
            Console.WriteLine($"aktuelle Flughöhe: {f16.CurrentAltitude}");
            f16.AddAltitude(20000);
            Console.WriteLine($"aktuelle Flughöhe: {f16.CurrentAltitude}");
            */


        }
    }
}
