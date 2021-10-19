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
                ("Add or remove from cart"),
                ("Checkout")
            };

        }
        public void AddOrRemove()
        {
            Console.WriteLine("Welcome to the Admin options.");

            bool repeat = true;

            while (repeat)
            {
                //Get admin input
                Console.Write("What would you like to do?\n" +
                           "\n1. Add an item to menu" +
                           "\n2. Remove an item from the menu" +
                           "\n3. Cancel and return to main menu");
                int answer = Validator.Validator.GetInt(1, 3);

                if (answer == 1)
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
                }

                //Removing Items
                else if (answer == 2)
                {
                    int choice = Options.GetFoodOrDrink();

                    if (choice == 1) //remove drink
                    {
                        Console.Write($"Which item would you like to remove? Enter a number 1 - {DrinkMenu.Count}: ");
                        int itemChoice = Validator.Validator.GetInt(1, DrinkMenu.Count);

                        //remove from cart and display item+price
                        DrinkMenu.Remove(DrinkMenu[itemChoice - 1]);
                        Console.WriteLine($"{DrinkMenu[itemChoice - 1].Name} is no longer on the menu.");
                    }
                    else if (choice == 2) //remove food
                    {
                        Console.Write($"Which item would you like to remove? Enter a number 1 - {FoodMenu.Count}: ");
                        int itemChoice = Validator.Validator.GetInt(1, FoodMenu.Count);

                        //remove from cart and display item+price
                        FoodMenu.Remove(FoodMenu[itemChoice - 1]);
                        Console.WriteLine($"{FoodMenu[itemChoice - 1].Name} is no longer on the menu.");
                    }
                }

                else
                {
                    Console.WriteLine("Returning to main main.");
                    break;
                }

                repeat = Validator.Validator.Repeat("Would you like to continue in admin mode?");

            }
        }
    }
}



