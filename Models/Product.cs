using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinQ.Models
{
    internal class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }

        public string Category { get; set; }

        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"Name: {ProductName}\n" +
                       $"Category: {Category}\n" +
                       $"Price: {Price}\n"
                      ;

        }
    }
}
