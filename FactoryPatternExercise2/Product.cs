using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    internal class Product
    {
        public Product (string name, double Price)
        {
            this.Name = name;
            this.Price = Price;
        }
        public string Name { get; set; }
        public double Price { get; set; }
        public void PrintProducts(IEnumerable<Product> products)
        {
            Console.WriteLine("Products in the database and their price:");
            foreach (Product product in products)
            {
                Console.WriteLine($"{product.Name}: ${product.Price}");
            }
        }
    }
}
