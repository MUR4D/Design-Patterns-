using BidloProduction.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BidloProduction.Game
{
    public class Park
    {
        IBidlo[] bidlos;

        Tree[] trees;

        Bench[] benches;

        public Park(IBidlo[] bidlos, Tree[] trees, Bench[] benches)
        {
            this.bidlos = bidlos;
            this.trees = trees;
            this.benches = benches;
        }

        public void BidloStatistics()
        {
            var alkashCount = bidlos.Where(x => { return x.ToString() == "Alkash"||x.ToString()=="Alkonaft"; }).Count();

            Console.WriteLine($"{alkashCount} Alkashey");

            var cushkaCount = bidlos.Where(x => { return x.ToString() == "Cushka"; }).Count();

            Console.WriteLine($"{ cushkaCount} Cushek");

            var gopnikCount = bidlos.Where(x => { return x.ToString() == "Gopnik"; }).Count();

            Console.WriteLine($"{gopnikCount} Gopnikov");
        }
    }
}
