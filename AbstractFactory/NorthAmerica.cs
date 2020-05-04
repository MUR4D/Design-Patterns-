namespace AbstractFactory
{
   public class NorthAmerica : IContinent
    {
        public Carnivore CreateCarnivore()
        {
            return new Wolf();
        }

        public Herbivore CreateHerbivore()
        {
            return new Bison();
        }
    }
}
