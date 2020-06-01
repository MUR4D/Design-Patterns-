using System;
using System.Collections.Generic;

namespace Builder
{
    class Shop<T> where T : class
    {
       public static List<T> products;

        public Shop()
        {
            products = new List<T>();
        }

        public void Add(T product)
        {
            products.Add(product);
        }

        public void Show()
        {
            foreach (var item in products)
            {
                Console.WriteLine(item);
            }
        }
    }
}
