namespace AbstractFactory
{
   public interface IContinent
    {
        Herbivore CreateHerbivore();

        Carnivore CreateCarnivore();
    }
}
