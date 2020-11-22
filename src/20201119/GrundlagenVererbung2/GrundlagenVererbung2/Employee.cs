using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrundlagenVererbung2
{
    public class Employee
    {
        private string _name;
        private Guid _id;
        private DateTime _geburtsDatum;
        private decimal _gehalt;


        //HACK! ... zu finden in View -> Tasklist ... die verwendbaren Schlüsselwörter unter Tools -> Options -> Tasklist
        // zuerst einen std. konstruktor angelegt, damit das system am anfang nicht selbst einen erzeugt ... es muss immer erst die basis-klasse employee instanziert werden
        //public Employee()
        //{
        //
        //}


        public Employee(string name, DateTime geburtsDatum, decimal gehalt)
        {
            _name = name;
            _geburtsDatum = geburtsDatum;
            _gehalt = gehalt;
            _id = Guid.NewGuid();
        }



        public decimal Gehalt
        {
            get { return _gehalt; }
        }

        public DateTime GeburtsDatum
        {
            get { return _geburtsDatum; }
        }

        public string Name
        {
            get { return $"{_name}"; }

        }

        public Guid Id
        {
            get { return _id; }
        }



        public string GetInfoString()
        {
            return $"[{Id}]: {_name} - {_geburtsDatum.ToShortDateString}";
        }

        public decimal GetCalculatedSalary()
        {
            return _gehalt;
        }

        



    }
}