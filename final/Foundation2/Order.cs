using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineOrderingSystem
{
    public class Order
    {
        private List<Product> products;
        private Customer customer;

        public Order(Customer customer)
        {
            this.customer = customer;
            products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public decimal GetTotalCost()
        {
            decimal totalCost = 0;
            foreach (var product in products)
            {
                totalCost += product.GetTotalCost();
            }

            totalCost += customer.IsInUSA() ? 5 : 35;
            return totalCost;
        }

        public string GetPackingLabel()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var product in products)
            {
                sb.AppendLine($"{product.Name} ({product.ProductId})");
            }
            return sb.ToString();
        }

        public string GetShippingLabel()
        {
            return $"{customer.Name}\n{customer.Address}";
        }

        public override string ToString()
        {
            return $"Order for {customer.Name}\nTotal Cost: ${GetTotalCost()}";
        }
    }
}
