namespace AbstractFactory
{
    public class Africa : IContinent
    {
        public Carnivore CreateCarnivore()
        {
            return new Lion();
        }

        public Herbivore CreateHerbivore()
        {
            return new Gnu();
        }
    }
}
