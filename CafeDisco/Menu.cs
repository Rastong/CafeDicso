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
                new Item("Chai Latte", "Black tea with spices topped with steamed milk", 3.25),
                new Item("Steamer", "Steamed milk, honey, cinnamon, and vanilla", 2.75),
                new Item("Iced Coffee", "Served chilled and sweetened over ice", 1.99),
                new Item("BullShot", "Redbull w. espresso  and honey served chilled", 4.29),
                new Item("Cuban Coffee", "Served with a layer of sweet whipped crema", 2.99),
                new Item("Cafe con leche", "Equal parts espresso and scalded milk", 2.59),
                new Item("Nitro Cold Brew", "Slow-steeped and infused with nitrogen", 4.79),
                new Item("Lavendar Latte", "Brewed with Lavender, simple syrup, espresso", 4.50),
                new Item("Cappuccino", "Single espresso shot topped with milk and foam", 3.95),
                new Item("Reese's Mocha", "With whipped cream and chocolate drizzle", 4.95),
                new Item("Peppermint Patty", "Espresso, cocoa, peppermint - Christmas in a mug", 4.95),
                new Item("Americano", "Espresso poured over hot water", 2.85)
            };

            FoodMenu = new List<Item>
            {
                new Item("Bagel", "Toasted and served with butter", 3.99),
                new Item("Corn Dog", "Stuffed with cheese and served with honey mustard", 1.99),
                new Item("Parmesan Leek Pastry", "Flaky layers fresh from the bakery", 4.25),
                new Item("The Godfather", "Spiced ham, hard salami, provolone cheese, \n" +
                            "\tleaf lettuce, tomatoes, onions, Italian dressing", 6.69)
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
            Console.WriteLine("Welcome to the Admin options.");

            bool repeat = true;

            while (repeat)
            {
                //Get admin input
                Console.Clear();
                Console.WriteLine("What would you like to do?\n" +
                           "\n1. Add an item to menu" +
                           "\n2. Remove an item from the menu" +
                           "\n3. Cancel and return to main menu");
                int answer = Validator.Validator.GetInt(1, 3);

                if (answer == 1)
                {
                    //ask admin if they want to add food or drink
                    int choice = Options.GetFoodOrDrink();

                    //get item properties - name, description, price
                    Console.Write($"What is the name of item would you like to add? ");
                    string name = Validator.Validator.GetString("a name");
                    Console.Write("What is the description of the item you want to add? ");
                    string description = Validator.Validator.GetString("a description");
                    Console.Write("What is the price of the item you want to add? ");
                    double price = Validator.Validator.GetDouble(0, 10000000000);

                    //instantiate new Item with given properties
                    Item item = new Item(name, description, price);
                    
                    if (choice == 1)
                    {
                        DrinkMenu.Add(item);
                    }
                    else if (choice == 2)
                    {
                        FoodMenu.Add(item);
                    }

                    Console.WriteLine($"You have successfully added {item.Name} to the menu.");
                }

                //Removing Items
                else if (answer == 2)
                {
                    int choice = Options.GetFoodOrDrink();

                    if (choice == 1) //remove drink
                    {
                        Options.GetBeverageMenu(DrinkMenu);
                        Console.Write($"Which item would you like to remove? Enter a number 1 - {DrinkMenu.Count}: ");
                        int itemChoice = Validator.Validator.GetInt(1, DrinkMenu.Count);

                        //remove from cart and display item+price
                        Console.WriteLine($"{DrinkMenu[itemChoice - 1].Name} is no longer on the menu.");
                        DrinkMenu.Remove(DrinkMenu[itemChoice - 1]);                       
                    }
                    else if (choice == 2) //remove food
                    {
                        Options.GetFoodMenu(FoodMenu);
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



