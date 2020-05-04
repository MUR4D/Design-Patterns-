using System;

namespace AbstractFactory
{
   public abstract class Herbivore
    {
        public int Height { get; set; } = 0;

        public bool isAlive { get; set; } = true;

        public void EatGrass()
        {
            Console.WriteLine($"{this} has  eated");
            Height += 10;
        }
    }
}
