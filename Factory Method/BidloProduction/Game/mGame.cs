using BidloProduction.GameObjects;
using BidloProduction.Levels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BidloProduction.Game
{
   public class mGame
    {
        private Park park;
        private Hero you;

        public mGame(IBidloFactory level)
        {
            you = new Hero();

            Tree[] trees = new Tree[]
            {
                new Tree(),
                new Tree(),
                new Tree(),
            };

            Bench[] benches = new Bench[]
            {
                new Bench(),
                new Bench(),
            };

            IBidlo[] bidlos = new IBidlo[100];

            for (int i = 0; i < bidlos.Length; i++)
            {
                bidlos[i] = level.Create();
            }

            park = new Park(bidlos, trees, benches);

        }

        public void Start()
        {
            Console.WriteLine("Location has been loaded");
            Console.WriteLine("Trees have been loaded");
            Console.WriteLine("Benches have been loaded");
            Console.WriteLine("Monsters are their places");
            Console.WriteLine("Hero's been loaded");
            Console.WriteLine("And here is aaa bulshiiit:D");

            park.BidloStatistics();
        }
    }
}
