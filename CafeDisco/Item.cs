using System;
using System.Collections.Generic;
using System.Text;

namespace CafeDisco
{
    class Item
    {
        public string Name;
        public double Price;
        

        public Item(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public Item (string name)
        {
            Name = name;
        }


        public override string ToString()
        {
            return string.Format("{0, -20}\t{1, -20:0.00}", Name, Price);
        }
    }
}
