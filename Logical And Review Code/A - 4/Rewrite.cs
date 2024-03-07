using System;
using System.Collections.Generic;

namespace MemoryLeakExample
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var myList = new List<Product>(); // Create a new list for each iteration
                // populate list with 1000 integers
                for (int i = 0; i < 1000; i++)
                {
                    // Using statement to ensure proper disposal of Product objects
                    using (var product = new Product(Guid.NewGuid().ToString(), i))
                    {
                        myList.Add(product);
                    }
                }
                // do something with the list object
                Console.WriteLine(myList.Count);
            }
        }
    }

    class Product : IDisposable
    {
        public Product(string sku, decimal price)
        {
            SKU = sku;
            Price = price;
        }
        public string SKU { get; set; }
        public decimal Price { get; set; }

        // Dispose method to release any resources
        public void Dispose()
        {
            // Implement IDisposable pattern if necessary
        }
    }
}
