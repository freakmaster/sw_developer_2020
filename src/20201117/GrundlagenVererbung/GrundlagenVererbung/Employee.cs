using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Employee
    {
        private string _name;
        private Guid _id;
        private DateTime _geburtsDatum;
        private decimal _gehalt;


        //HACK! ... zu finden in View -> Tasklist ... die verwendbaren Schlüsselwörter unter Tools -> Options -> Tasklist
        //public Employee()
        //{
        //
        //}


        public Employee(string name, DateTime geburtsDatum, decimal gehalt)
        {
            _name = Name;
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
            return $"[{Id}]: {_name} - {_geburtsDatum.Date}";
        }

        public decimal GetCalculatedSalary()
        {
            return _gehalt;
        }


    }

