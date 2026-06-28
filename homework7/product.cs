using System;
using System.Collections.Generic;
using System.Text;

namespace homework7
{
    internal class product
    {
        public class Product
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public decimal Price { get; set; }
            public bool Nuts { get; set; }
            public string Image { get; set; }
            public bool Vegeterian { get; set; }
            public int Spiciness { get; set; }
            public string Category { get; set; }

            public void PrintInfo()
            {
                Console.WriteLine($"ID: {Id}");
                Console.WriteLine($"Name: {Name}");
                Console.WriteLine($"Price: {Price}");
                Console.WriteLine($"Category: {Category}");
            }
        }
    }
}
