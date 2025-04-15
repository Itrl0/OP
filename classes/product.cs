using OP.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  OP
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public DateTime ExpiryDate { get; set; }

        public Product(string name, int quantity)
        {
            Name = name;
            Quantity = quantity;
            ExpiryDate = DateTime.Now.AddDays(7);
        }

        public override string ToString()
        {
            return $"{Name} - {Quantity} шт.";
        }
    }

}
