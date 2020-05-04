using System;
using System.Linq;

namespace AbstractFactory
{

    class Program
    {
        static void Main(string[] args)
        {
            AnimalWorld.Herbivores.AddLast(new Gnu());
            AnimalWorld.Herbivores.AddFirst(new Bison());
            AnimalWorld.Carnivores.AddLast(new Lion());
            AnimalWorld.Carnivores.AddFirst(new Wolf());
            AnimalWorld.MealHerbivore();
            foreach (var item in AnimalWorld.Herbivores)
            {
                Console.WriteLine(item.Height);
            }
            AnimalWorld.MealCarnivore();
            

        }
    }
}
