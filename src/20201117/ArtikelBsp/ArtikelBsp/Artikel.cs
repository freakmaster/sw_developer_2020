using System;

namespace ArtikelBsp
{
    public class Artikel
    {
        private string _bezeichnung;
        private Guid _code;
        private decimal _preis;
        private ArtikelStatus _status;
        

        public Artikel()
        {

        }

        public string Bezeichnung
        {
            // Kapselung ... lesen u. schreiben nur via Eigenschaften ... nicht innerhalb der Klasse verwenden ... nur für Zugriff von aussen
            // Kapselung bedeutet dass nur gültige Objekte erzeugt werden und Blackbox(funktionelle Details sollten verborgen werden)
            get
            {
                return _bezeichnung;
            }

            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _bezeichnung = value;
                }
            }
        }
        public Guid Code
        {
            get
            {
                return _code;
            }
        }

        public decimal Preis
        {
            get
            {
                return _preis;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _bezeichnung = value;
                }
            }
        }

        static void GetInfoString()
        {
            
        }


    }
}