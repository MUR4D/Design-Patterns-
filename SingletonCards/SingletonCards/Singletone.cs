using System.Collections.Generic;

namespace SingletonCards
{
    class Singletone

    {
        static private Singletone instance = null;
        static public Singletone Instance
        {
            get
            {
                if (instance == null)
                    instance = new Singletone();
                return instance;
            }
        }

        public List<Card> Data { get; set; }

        private Singletone()
        {
            Data = new List<Card>();
        }
    }
}
