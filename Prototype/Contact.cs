using System;

namespace DeepCopy_MemberwiseCopy
{
    [Serializable]
    public class Contact
    {
        public string Name;
        public Adress Adress;

        public override string ToString()
        {
            return $"Name:{Name} Adress:{Adress.City} {Adress.Street}";
        }
    }
}
