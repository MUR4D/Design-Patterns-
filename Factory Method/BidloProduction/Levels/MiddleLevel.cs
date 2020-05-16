using BidloProduction.Enemies;
using System;
using System.Collections.Generic;
using System.Text;

namespace BidloProduction.Levels
{
    public class MiddleLevel : IBidloFactory
    {
        public IBidlo Create()
        {
            int counter = 0;

            if (counter < 10) return new Gopnik();


            IBidloFactory bidloFactory = new EasyLevel();
            return bidloFactory.Create();
        }

        public override string ToString()
        {
            return "Middle level";
        }
    }
}
