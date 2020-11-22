using System;

namespace Grundlagen_HatEin_Vererbung
{
    public class Plane : Vehicle
    {
        private double _maxAltitude;
        private double _currentAltitude = 0.0;

        public Plane(string model, string description, int maxSpeed, double maxAltitude, double currentAltitude)
            : base(model, description, maxSpeed)
        {
            _currentAltitude = currentAltitude;
            _maxAltitude = maxAltitude;
        }

        public double MaxAltitude
        {
            get { return _maxAltitude; }
        }

        public double CurrentAltitude
        {
            get { return _currentAltitude; }
            set { _currentAltitude = value; }
        }

        public void AddAltitude(double addAlt)
        {


            if(_maxAltitude > _currentAltitude + addAlt)
            {
                _currentAltitude += addAlt;
                return;
            }
            else
            {
                Console.WriteLine($"Die maximale Flughöhe {_maxAltitude} darf nicht überschritten werden ! Aktuelle Höhe = {_currentAltitude}");
                return;
            }
        }

    }
    
}