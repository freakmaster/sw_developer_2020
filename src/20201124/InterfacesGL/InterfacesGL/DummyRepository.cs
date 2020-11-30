using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstrakteKlassen;

namespace InterfacesGL
{
    public class DummyRepository : IDataRepository
    {
        public string Name => throw new NotImplementedException();

        public int MaxSize => throw new NotImplementedException();

        public string Read()
        {
            Console.WriteLine("Lese nun die Staen ");
            return "hallo!";
        }

        public void Write(string data)
        {
            Console.WriteLine("Daten werden geschrieben");
        }
    }
}
