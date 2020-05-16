using System;
using System.Collections.Generic;
using System.Text;

namespace BidloProduction.Enemies
{
    public class Gopnik : IBidlo
    {
        public void BattleRoar()
        {
            Console.WriteLine("Semki est?A esli naydu?!");
        }

        public override string ToString()
        {
            return "Гопник"; 
        }
    }
}
