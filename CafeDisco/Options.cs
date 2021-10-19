using System;
using System.Collections.Generic;
using System.Text;

namespace CafeDisco
{
    class Options
    {

        public static Menu menuItems = new Menu();

        public static int GetMainChoice()
        {
            Console.WriteLine("");
            for (int i = 0; i < menuItems.MainMenu.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {menuItems.MainMenu[i]}");
            }

            int mainChoice = Validator.Validator.GetInt(1, menuItems.MainMenu.Count, 96, 99);

            return mainChoice;
        }
        public static int AddOrRemove(Menu menuItems)
        {
            Console.WriteLine("Would you like to add or remove anything from your cart?\n Select '1' for add or '2' for remove.");
            int choice = Validator.Validator.GetInt(1, 2);
            return choice;
        }
        public static int GetFoodOrDrink()
        {
            Console.WriteLine("Would you to add food or drinks?\n Select '1' for drinks or '2' for food.");
            int itemChoice = Validator.Validator.GetInt(1, 2);
            return itemChoice;

        }
        public static int GetItem(int foodOrDrink, Menu menuItems)
        {
            int itemChoice = 0;
            //beverageMenu
            if (foodOrDrink == 1)
            {
                Console.WriteLine("What drinks would you like to add to your cart?");
                GetBeverageMenu(menuItems.DrinkMenu);
                itemChoice = GetChoice(menuItems.DrinkMenu);
            }
            //foodMenu
            else if (foodOrDrink == 2)
            {
                Console.WriteLine("Which food items would you like to add to your cart?");
                GetFoodMenu(menuItems.FoodMenu);
                itemChoice = GetChoice(menuItems.FoodMenu);
            }
            return itemChoice;
        }
        public static int GetChoice(List<Item> items)
        {

            int choice = 0;

            Console.WriteLine("Please select an option");
            choice = Validator.Validator.GetInt(1, items.Count + 1);

            return choice;
        }
        public static void GetBeverageMenu(List<Item> bevMenu)
        {
            for (int i = 0; i < bevMenu.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {bevMenu[i]}");
                Console.WriteLine($"\t{bevMenu[i].Descriptiion}");
            }
        }
        public static void GetFoodMenu(List<Item> foodMenu)
        {
            for (int i = 0; i < foodMenu.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {foodMenu[i]}");
                Console.WriteLine($"\t{foodMenu[i].Descriptiion}");
            }
        }

    }
}
