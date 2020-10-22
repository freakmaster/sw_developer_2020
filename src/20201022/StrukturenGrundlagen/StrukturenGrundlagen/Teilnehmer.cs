using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrukturenGrundlagen
{
    struct Teilnehmer
    {
        // public ... weil es nicht gekapselt werden soll... und im gesamten Namensraum verwendet wird ... datentyp ....
        public string Vorname;
        public string Nachname;
        public DateTime Geburtsdatum;
    }
}
