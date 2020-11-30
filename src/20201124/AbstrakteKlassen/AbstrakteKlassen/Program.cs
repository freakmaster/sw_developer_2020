using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstrakteKlassen
{
    class Program
    {
        static void Main(string[] args)
        {
            DataRepository repository = new TextFileRepository("Test.txt", 200);
            // DataRepository repository = new MemoryRepository(20);

            //daten speichern
            PersistMyData(repository, "Dies ist ein Testdatensatz");


            // ausgbae
            string myData = ReadMyData(repository);
            Console.WriteLine(myData);

        }

        static string ReadMyData(DataRepository repository)
        {
            if (repository != null)
            {
                Console.WriteLine();
                repository.Read();
            }

            return string.Empty;
        }
        


        static void PersistMyData(DataRepository repository, string dataToPersist)
        {
            if(repository != null)
            {
                repository.Write(dataToPersist);
            }
                      
        }

    }
}
