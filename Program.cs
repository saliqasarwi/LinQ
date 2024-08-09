using LinQ.Models;
namespace LinQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product()
            {
                Id = 1,
                ProductName = "Laptop",
                Category = "Electronics",
                Price = 999.99m,

            };
            Product product2 = new Product()
            {
                Id = 2,
                ProductName = "Smartphone",
                Category = "Electronics",
                Price = 499.99m,


            };
            Product product3 = new Product()
            {
                Id = 3,
                ProductName = "Desk Chair",
                Category = "Furniture",
                Price = 89.99m,


            };
            List<Customer> Customers = new List<Customer>() {
             new Customer(){
             Id = 1,
            Name = "John Doe",
            Email = "john.doe@example.com",
            Phone = "555-1234",
            City = "Nablus",
            PurchasedProducts = new List<Product> { product1, product2 }
             }   ,
             new Customer()
             {
                 Id = 2,
            Name = "Jane Smith",
            Email = "jane.smith@example.com",
            Phone = "555-5678",
            City = "Jenin",
            PurchasedProducts = new List<Product> { product3 }
             },
             new Customer()
             {

             Id = 3,
            Name = "Alice Johnson",
            Email = "alice.johnson@example.com",
            Phone = "555-8765",
            City = "Qalqilia",
            PurchasedProducts = new List<Product> { product1, product3 }
             }
            };
            var results = Customers.Where(customer => customer.City == "Nablus");
            Console.WriteLine("Customers living in Nablus");
            foreach (var item in results)
            {
                Console.WriteLine(item);
                Console.WriteLine("==========================");
            }
            var Names = Customers.Select(customer => customer.Name);
            Console.WriteLine("Customers Names");
            foreach (var item in Names)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("==========================");
            var names = Customers.OrderBy(customer => customer.Name);
            Console.WriteLine("Customers ordered by their names in ascending order:");
            foreach (var item in names)
            {
                Console.WriteLine(item);
                Console.WriteLine("==========================");
            }
            Console.WriteLine("The first customer in the list:");
            Console.WriteLine(Customers.FirstOrDefault());
            Console.WriteLine("Customer with Id=1");
            Console.WriteLine(Customers.ElementAt(0));

            var price = Customers.SelectMany(c => c.PurchasedProducts).Sum(p => p.Price);
            Console.WriteLine($"Sum of all products prices purchased by all customers={price}");
            var Qalqilia = Customers.Any(c => c.City == "Qalqilia");
            Console.WriteLine($"Is there any customer from Qalqilia? {Qalqilia}");
            Console.WriteLine("Customers grouped by their City:");
            var cities = Customers.GroupBy(c => c.City);
            foreach (var c in cities)
            {
                Console.WriteLine($"City:{c.Key}");
                foreach (var x in c)
                {
                    Console.WriteLine(x.Name);
                }
            }

            var res = Customers.Take(3).ToList();
            Console.WriteLine("First 3 Customers:");
            foreach (var x in res)
            {
                Console.WriteLine(x);

            }
        }

    }

}
