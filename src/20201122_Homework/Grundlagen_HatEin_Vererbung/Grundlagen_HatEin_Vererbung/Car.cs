using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grundlagen_HatEin_Vererbung
{
    public class Car : Vehicle
    {
        private DriveMode _driveMode;
    

        public Car(string model, string description, int maxSpeed, DriveMode driveMode)
               : base(model, description, maxSpeed)
        {
            _driveMode = driveMode;
        }

        public DriveMode driveMode
        {
            get { return _driveMode; }
        }
        
        public bool SetDriveMode(DriveMode newdriveMode)
        {
            switch (newdriveMode)
            {
                case DriveMode.AWD:
                    Console.WriteLine("Allrad ist aktiviert");
                    break;
                case DriveMode.FWD:
                    Console.WriteLine("Vorderradantrieb ist aktiviert");
                    break;
                case DriveMode.RWD:
                    Console.WriteLine("Hinterradantrieb ist aktiviert");
                    break;
                default:
                    break;                    
            }

            return false;

        }

        public string GetDriveMode()
        {
            return $"Antriebsart: {_driveMode}";
        }


    }
}
