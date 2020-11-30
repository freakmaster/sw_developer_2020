using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstrakteKlassen
{
    public class TextFileRepository : DataRepository
    {
        private readonly string _fileName;
        
        public TextFileRepository(string fileName, int maxSize)
            :base("TextFile Repository", maxSize)
        {
            _fileName = fileName;
        }

        public string FileName
        {
            get { return _fileName; }
        }

        public override string Read()
        {
            if (string.IsNullOrWhiteSpace(_fileName) || !File.Exists(_fileName))
            {
                Debug.WriteLine($"Dateiname '{_fileName}' darf nicht leer sein oder Datei nicht gefunden.");
            }

            using(StreamReader sr = new StreamReader(_fileName))
            {
                return sr.ReadToEnd();
            }
        }

        public override void Write(string data)
        {
            if (string.IsNullOrWhiteSpace(_fileName))
            {
                Debug.WriteLine($"Dateiname '{_fileName}' darf nicht leer sein.");
                return;
            }

            using(StreamWriter sw = new StreamWriter(_fileName, true))
            {
                sw.WriteLine(data);
            }
        }
    }
}
