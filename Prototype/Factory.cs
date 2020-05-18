namespace DeepCopy_MemberwiseCopy
{
   public class Factory
    {
        private static Contact main = new Contact { Adress = new Adress { City = "Baku", Street = 0 } };

        private static Contact aux = new Contact { Adress = new Adress { City = "Baku", Street = 15 } };
        private static Contact NewContact(string name,int street,Contact prototype)
        {
            var res= prototype.DeepCopy();
            res.Name = name;
            res.Adress.Street = street;
            return res;
        }

        public static Contact NewMainContact(string name,int street)
        {
            return NewContact(name, street, main);
        }

        public static Contact NewAuxContact(string name, int street)
        {
            return NewContact(name, street, aux);
        }
    }
}
