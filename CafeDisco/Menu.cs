using System;
using System.Collections.Generic;
using System.Text;

namespace CafeDisco
{
    class Menu
    {
        //property
        public List<Item> DrinkMenu { get; set; }
        public List<Item> FoodMenu { get; set; }
        public List<string> MainMenu { get; set; }

        //constructor
        public Menu()
        {
            DrinkMenu = new List<Item>
            {
                new Item("Chai Latte", 3.25),
                new Item("Steamer", 2.75),
                new Item("Iced Coffee", 1.99),
                new Item("BullShot", 4.29),
                new Item("Cuban Coffee", 2.99),
                new Item("Cafe con leche", 2.59),
                new Item("Nitro Cold Brew", 4.79),
                new Item("Lavendar Latte", 4.50),
                new Item("Chappuccino", 3.95),
                new Item("Reese Mocha", 4.95),
                new Item("Peppermint Patty", 4.95),
                new Item("Americano", 2.85),
            };

            FoodMenu = new List<Item>
            {
                new Item("Bagel", 3.99),
                new Item("Corn Dog", 1.99),
                new Item("Parmesan Leek Pastry", 4.25),
                new Item("The Godfather", 6.69),
            };

            MainMenu = new List<string>
            {
                "Add or remove from cart",
                "Checkout",
                "View Cart"
            };
        }
       



    }
}
