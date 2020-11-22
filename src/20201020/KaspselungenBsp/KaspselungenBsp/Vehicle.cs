using System;

namespace KaspselungenBsp
{
    internal class Vehicle
    {
        private string _marke;
        private DateTime _baujahr;
        private decimal _preis;

        public Vehicle(string marke, DateTime baujahr, decimal preis)
        {
            _marke = Marke;
            _baujahr = Baujahr;
            _preis = Preis;
        }

        public string Marke
        {
            get { return _marke; }
            set { _marke = value; }
        }

        public DateTime Baujahr
        {
            get { return _baujahr; }
            set { Baujahr = value; }
        }

        public decimal Preis
        {
            get { return _preis; }
            set { _preis = value; }
        }



    }
}