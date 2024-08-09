using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ.Models
{
    internal class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string City { get; set; }

        public List<Product> PurchasedProducts { get; set; }
        public override string ToString()
        {
            string products = string.Join("\n", PurchasedProducts.Select(p => p.ToString()));

            return $"Id: {Id}\n" +
                   $"Name: {Name}\n" +
                   $"Email: {Email}\n" +
                   $"Phone: {Phone}\n" +
                   $"City: {City}\n" +
                   $"Purchased Products:\n{products}";
        }
    }

}

