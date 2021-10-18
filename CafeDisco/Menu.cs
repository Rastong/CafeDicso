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

    
        public void AddOrRemove()
        {

            Console.Write("Would you like to add an item to the list? (y/n): ");
           
            while (true)
            {
                string answer = Validator.Validator.GetString("y/n");

                if (answer == "y")
                {
                    //food or drink
                    int choice = Options.GetFoodOrDrink();
                    Console.Write($"What is the name of item would you like to add?");
                    string name = Validator.Validator.GetString("name");
                    Console.Write("What is the price of the item you want to add?");
                    double price = Validator.Validator.GetDouble(0, 10000000000);
                    Item item = new Item(name, price);
                    if (choice == 1)
                    {
                        FoodMenu.Add(item);
                    }
                    else if (choice == 2)
                    {
                        DrinkMenu.Add(item);
                    }



                    //for (int i = 0; i < list.Count; i++)
                    //{
                    //    //display list
                    //    Console.WriteLine("{0}.{1}", i, list[i]);
                    //}


                    //Console.WriteLine();

                    //Console.WriteLine("Choose from the list to remove an item: ");

                    //answer = Console.ReadLine();
                    //answer = answer.ToLower();






                }
            }
        }
    }
}



