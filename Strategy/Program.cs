using System;
using System.Collections.Generic;

namespace Strategy
{

    class Program
    {
        static void Main(string[] args)
        {
            List<IBuy> products = new List<IBuy>();
            
            Auto auto = new Auto();
            auto.SetStrategy(new Drink("Pepsi"));
            products.Add(auto.ExecuteStrategy());
            auto.SetStrategy(new Drink("Sprite"));
            products.Add(auto.ExecuteStrategy());
            auto.SetStrategy(new Drink("Fanta"));
            products.Add(auto.ExecuteStrategy());
            auto.SetStrategy(new Drink("7Up"));
            products.Add(auto.ExecuteStrategy());
            auto.SetStrategy(new Snack("Snickers"));
            products.Add(auto.ExecuteStrategy());
            auto.SetStrategy(new Snack("Twix"));
            products.Add(auto.ExecuteStrategy());
            auto.SetStrategy(new Snack("Mars"));
            products.Add(auto.ExecuteStrategy());
            auto.SetStrategy(new Snack("lays"));
            products.Add(auto.ExecuteStrategy());
            foreach (var item in products)
            {
                Console.WriteLine(item);
            }
        }
    }
}
