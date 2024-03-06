using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment_2
{
    class Product_Program

    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
    }

    class Program
    {
        static void Main()
        {
            {
                // Add 10 products
            List<Product_Program> products = new List<Product_Program>
        {
            new Product_Program { ProductId = 1, ProductName = "Aeroplane", Price = 800000 },
            new Product_Program { ProductId = 2, ProductName = "Phone", Price = 5000 },
            new Product_Program { ProductId = 3, ProductName = "Tablet", Price = 30000 },
            new Product_Program { ProductId = 4, ProductName = "Bike", Price = 45000 },
            new Product_Program { ProductId = 5, ProductName = "Laptop", Price = 56000},
            new Product_Program { ProductId = 6, ProductName = "Bicycle", Price = 7000},
            new Product_Program { ProductId = 7, ProductName = "Car", Price = 300000},
            new Product_Program { ProductId = 8, ProductName = "Samsung s22", Price = 26000},
            new Product_Program { ProductId = 9, ProductName = "Iphone", Price = 100000},
            new Product_Program { ProductId = 10, ProductName = "Nokia", Price = 13000},
         };

                // Sorting in ascending order of product price 
                var sortedProducts = products.OrderBy(p => p.Price).ToList();

                // Display product in ascending order of product price

                Console.WriteLine("Sorted Products by Price:");
                foreach (var product in sortedProducts)
                {
                    Console.WriteLine($"Product ID: {product.ProductId}, Name: {product.ProductName}, Price: {product.Price}");
                }
                Console.Read();

            }
        }
    }
}
