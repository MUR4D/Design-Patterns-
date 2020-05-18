using System;

namespace DeepCopy_MemberwiseCopy
{
    class Program
    {
        static void Main(string[] args)
        {
            var adress = new Adress { City = "Baku", Street = 10 };
            var contact1 = new Contact
            { Name = "John",

                Adress = adress.DeepCopy()

            };
            var contact2 = contact1.DeepCopy();
            contact2.Name = "Murad";
            contact2.Adress.Street = 1000;
            
            
            Console.WriteLine(contact1);
            Console.WriteLine(contact2);

        }
    }
}
