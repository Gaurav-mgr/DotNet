using System;
using c = System.Console;
using System.Collections.Generic;
using System.Linq;

namespace Lab8
{
    public class Product
    {
        public string name { get; set; }
        public double price { get; set; }
        public Product(string name, double price)
        {
            this.name = name;
            this.price = price;
        }
    }
    public class q4
    {
        static void Main()
        {
            var products = new List<Product>
            {
                new Product("Laptop",80020.28),
                new Product("A4 Paper", 495.89)
            };

            c.WriteLine("LINQ Operators: ");

            int totalProducts = products.Count();
            c.WriteLine($"[Count]Total Products: {totalProducts}");

            double totalPrice = products.Sum(p => (double)p.price);
            c.WriteLine($"[Sum]Total Price: {totalPrice}");

            double avgPrice = products.Average(p => (double)p.price);
            c.WriteLine($"Average Price: {avgPrice}");

            double maxPrice = products.Max(p => (double)p.price);
            c.WriteLine($"Max Price: {maxPrice}");

            double minPrice = products.Min(p => (double)p.price);
            c.WriteLine($"Min Price: {minPrice}");

            string productName = products.Select(p => p.name).Aggregate((a, b) => a + ", " + b);
            c.WriteLine($"List of Product Names: {productName}");

            c.ReadLine();
        }
    }
}
