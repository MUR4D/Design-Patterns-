using BidloProduction.Enemies;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace BidloProduction.Levels
{
   public class EasyLevel:IBidloFactory
    {
       static Random rnd = new Random();

        public IBidlo Create()
        {
            string[] bidlos = new string[]
            {
                "Alkonaft",
                "Cushka",
                "Gopnik"
            };

            switch (bidlos[rnd.Next(0,bidlos.Length)])
            {
                case "Alkonaft":
                    return new Alkash();
                    ;
                case "Cushka":
                    return new Cushka();
                    ;
                case "Gopnik":
                    return new Gopnik();
                    ;
                default:
                    throw new Exception("There are stuff like that :D");
                    
            }

            
        }
        public override string ToString()
        {
            return "Easy level"; 
        }
    }
}
