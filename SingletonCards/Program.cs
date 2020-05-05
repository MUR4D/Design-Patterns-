using System;

namespace SingletonCards
{


    class Program
    {
        static void Main(string[] args)
        {
            Card card = new Card() { Index = 6, Suit = "Cherv" };
            Card card1 = new Card() { Index = 6, Suit = "Pika" };
            Singletone.Instance.Data.Add(card);
            Singletone.Instance.Data.Add(card1);

            foreach (var item in Singletone.Instance.Data)
            {
                Console.WriteLine(item);
            }
        }
    }
}
