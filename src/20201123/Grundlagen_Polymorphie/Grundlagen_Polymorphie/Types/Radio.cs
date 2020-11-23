using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grundlagen_Polymorphie.Types
{
    public class Radio
    {
        private double _frequency;
        private int _volume;
        private Power _powerState;

        public Radio()
        {
            _frequency = 90.5;
            _volume = 3;
            _powerState = Power.Off;
        }


        public Power PowerState
        {
            get { return _powerState; }

        }


        public int Volume
        {
            get { return _volume; }
            set
            {
                //Todo: Limit possible 0-10
                _volume = value;
            }
        }

        public double Frequency
        {
            get { return _frequency; }
            set
            {
                // ToDo: Limit possible 86.0 - 102.0 (FM Band)
                _frequency = value;
            }

        }

        public string GetInfoString()
        {
            return $"Freq: {_frequency} | MHz | {Volume} | Volume";
        }

        public void SetVolume(int newVolume)
        {
            if (_powerState == Power.On)
            {
                _volume = newVolume;
                return;
            }
            else
            {
                Console.WriteLine($"Kann Lautstärke nicht verändern weil Power Off");
            }
        }


        public void SetPowerState(Power newPowerState)
        {
            switch (newPowerState)
            {
                case Power.On:
                    Console.WriteLine("Radio ist on" + GetInfoString());
                    break;
                case Power.Off:
                    Console.WriteLine("Radio ist off");
                    break;
                case Power.Suspend:
                    Console.WriteLine("Radio ist suspend");
                    break;
                default:
                    break;
            }
        }



    }
}
