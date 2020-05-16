using BidloProduction.Enemies;
using System;
using System.Collections.Generic;
using System.Text;

namespace BidloProduction.Levels
{
    public class HardLevel : IBidloFactory
    {
        Random rnd = new Random();
        public IBidlo Create()
        {

            string[] bidlos = new string[]
            {
                "Cushka",
                "Gopnik",
                
            };

            switch (bidlos[rnd.Next(0,bidlos.Length)])
            {
                case "Cushka":
                    return new Cushka();
                case "Gopnik":
                    return new Gopnik();
                default:
                    throw new Exception("There are no such stuff:D");
            }

        }

        public override string ToString()
        {
            return "Hard Level"; 
        }
    }
}
