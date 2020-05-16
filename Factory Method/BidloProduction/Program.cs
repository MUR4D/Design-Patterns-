using BidloProduction.Game;
using BidloProduction.Levels;
using System;

namespace BidloProduction
{

    class Program
    {
        static void Main(string[] args)
        {
            IBidloFactory[] lvls = new IBidloFactory[] { 
                new EasyLevel(),
                new MiddleLevel(),
                new HardLevel()
            };

            Console.WriteLine("Choose level:");

            for (int i = 0; i < lvls.Length; i++) 
            {
                Console.WriteLine($"{i + 1}. {lvls[i].ToString()}"); 
            }

            int lvlNumber = Convert.ToInt32(Console.ReadLine()) - 1; 

            if (lvlNumber > -1 && lvlNumber < lvls.Length) 
            {
                mGame game = new mGame(lvls[lvlNumber]); 
                game.Start();
            }

            else Console.WriteLine("Incorrect choose");




            Console.ReadKey(true);
        }
    }
}
