using System;

namespace OnlineOrderingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create customers
            Customer customer1 = new Customer("John Doe", new Address("123 Main St", "Springfield", "IL", "USA"));
            Customer customer2 = new Customer("Jane Smith", new Address("456 Maple Rd", "Toronto", "ON", "Canada"));

            // Create orders
            Order order1 = new Order(customer1);
            order1.AddProduct(new Product("Laptop", "P001", 999.99m, 1));
            order1.AddProduct(new Product("Mouse", "P002", 25.99m, 2));

            Order order2 = new Order(customer2);
            order2.AddProduct(new Product("Monitor", "P003", 199.99m, 1));
            order2.AddProduct(new Product("Keyboard", "P004", 49.99m, 1));

            // Display orders
            Console.WriteLine(order1);
            Console.WriteLine("Packing Label:");
            Console.WriteLine(order1.GetPackingLabel());
            Console.WriteLine("Shipping Label:");
            Console.WriteLine(order1.GetShippingLabel());

            Console.WriteLine();

            Console.WriteLine(order2);
            Console.WriteLine("Packing Label:");
            Console.WriteLine(order2.GetPackingLabel());
            Console.WriteLine("Shipping Label:");
            Console.WriteLine(order2.GetShippingLabel());
        }
    }
}
