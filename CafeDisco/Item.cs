using System;
using System.Collections.Generic;
using System.Text;

namespace CafeDisco
{
    class Item
    {
<<<<<<< HEAD
        public string Name;
        public double Price;
        
        
=======
        public string Name { get; set; }
        public string Descriptiion { get; set; }
        public double Price { get; set; }
>>>>>>> 30e1fb5c7e4e76a915ed30cfc57ae8aaca074671


        public Item(string name, string description, double price)
        {
            Name = name;
<<<<<<< HEAD
            Price = price;            
=======
            Descriptiion = description;
            Price = price;
>>>>>>> 30e1fb5c7e4e76a915ed30cfc57ae8aaca074671
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
