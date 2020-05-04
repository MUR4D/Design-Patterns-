using System;
using System.Collections.Generic;
using System.Linq;

namespace AbstractFactory
{
   public static class AnimalWorld
    {
        public static LinkedList<Herbivore> Herbivores { get; set; }

        public static LinkedList<Carnivore> Carnivores { get; set; }

        static AnimalWorld()
        {
            Herbivores = new LinkedList<Herbivore>();
           

            Carnivores = new LinkedList<Carnivore>();
           
        }
        public static void MealHerbivore()
        {
            foreach (var item in Herbivores)
            {
                item.EatGrass();
            }
        }

        public static void MealCarnivore()
        {
            foreach (var item in Carnivores.Zip(Herbivores, Tuple.Create))
            {
                item.Item1.EatHerbivore(item.Item2);
            }
        }

    }
}
