namespace Strategy
{
    class Snack :IBuy
    {
        public string Name { get; set; }

        public Snack(string name)
        {
            Name = name;
        }
        public override string ToString() => Name;
        public IBuy Buy() => new Snack(Name);
    }
}
