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
            _marke = marke;
            _baujahr = baujahr;
            _preis = preis;
        }


        public string Marke
        {
            get { return _marke; }
        }


    }
}