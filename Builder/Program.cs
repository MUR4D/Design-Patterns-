using System.Net.Http.Headers;

namespace Builder
{


    class Program
    {
        static void Main(string[] args)
        {
            Shop<Product> shop = new Shop<Product>();

            Tshirt shirt = TshirtBuilder.BuildTshirt();
            shirt.Name = "adidas";
            shirt.Size = "xl";
            shirt.Collection = "last";
            Jeans jeans = JeansBuilder.BuildJeans();
            jeans.Name = "colins";
            jeans.Collection = "last";
            jeans.Size = "L";
            Cap cap = CapBuilder.BuildCap();
            cap.Name = "Ny";
            cap.Size = "s";
            cap.Collection = "last";

            shop.Add(shirt);
            shop.Add(jeans);
            shop.Add(cap);



            shop.Show();

        }
    }
}
