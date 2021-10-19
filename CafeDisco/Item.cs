using System;
using System.Collections.Generic;
using System.Text;

namespace CafeDisco
{
    class Item
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }


        public Item(string name, string description, double price)
        {
            Name = name;
            Price = price;            
            Description = description;
            Price = price;
        }
        public Item (string name)
        {
            Name = name;
        }


        public override string ToString()
        {
            return string.Format($"{Name, -50} ${Price:0.00}");
        }
    }
}
