namespace Strategy
{
    class Drink :IBuy
    {
        public string Name { get; set; }

        public Drink(string name)
        {
            Name = name;
        }

        public override string ToString() => Name;

        public IBuy Buy() => new Drink(Name);
    }
}
