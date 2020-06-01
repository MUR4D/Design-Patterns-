namespace Builder
{
    abstract class Product
    {
        public string Name { get; set; }

        public string Collection { get; set; }

        public string Size { get; set; }

        public override string ToString()
        {
            return $"{Name} {Size} {Collection}"; 
        }


    }
}
