using System;
using System.Collections.Generic;
using System.Text;

namespace BidloProduction.Enemies
{
    public class Alkash : IBidlo
    {
        public void BattleRoar()
        {
            Console.WriteLine("Day manat na proezd");
        }

        public override string ToString() => "Alkash";
    }
}
