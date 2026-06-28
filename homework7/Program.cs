using static homework7.product;

namespace homework7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product
            {
                Id = 1,
                Name = "Pizza",
                Price = 25,
                Nuts = false,
                Image = "pizza.jpg",
                Vegeterian = false,
                Spiciness = 7,
                Category = "Fast Food"
            };

            product.PrintInfo();
        }
    }
}
