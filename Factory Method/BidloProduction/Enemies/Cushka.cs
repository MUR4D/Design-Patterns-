using System;
using System.Collections.Generic;
using System.Text;

namespace BidloProduction.Enemies
{
    public class Cushka : IBidlo
    {
        public void BattleRoar()
        {
            Console.WriteLine("Devushka,vashey mame zat ne nujen?");
        }

        public override string ToString() => "Чушка";
    }
}
