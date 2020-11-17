using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrundlagenVererbung
{
    public class Sales : Employee
    {
        private double _provision;
        
        public Sales(string name, DateTime geburtDatum, decimal gehalt, double provision)
               : base(name, geburtsDatum, gehalt)
        {
            _provision = provision;
        }

        public double Provision
        {
            get { return _provision; }
            set { _provision = value; }
        }

    }
}
