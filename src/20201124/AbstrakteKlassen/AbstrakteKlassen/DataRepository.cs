namespace AbstrakteKlassen
{
    public abstract class DataRepository
    {

        private string _name;
        private int _maxSize;

        public DataRepository(string name, int maxSize)
        {
            _name = name;
            _maxSize = maxSize;
        }


        public string Name
        {
            get { return _name; }
        }



        public int MaxSize
        {
            get { return _maxSize; }
        }

        // Abstrakte Member ... benötigen keine Implementierung
        public abstract void Write(string data);


        public abstract string Read();
        


    }
}
