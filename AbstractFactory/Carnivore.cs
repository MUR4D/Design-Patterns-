using System;

namespace AbstractFactory
{
    public abstract class Carnivore
    {
        public int Power { get; set; } = 0;

        public bool isAlive { get; set; } = true;

        public void EatHerbivore(Herbivore herbivore)
        {
            if (this.Power >= herbivore.Height)
            {
                herbivore.isAlive = false;
                this.Power += 10;
                Console.WriteLine($"{this} has  eated");
            }
            else
            {
                herbivore.isAlive = true;
                this.Power -= 10;
            }
        }
    }
}
