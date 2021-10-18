using System;
using System.Collections.Generic;
namespace CafeDisco
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            bool newCustomerOrder = true;
            while (newCustomerOrder == true)
            {
                Console.WriteLine("Welcome to Cafe Disco! Here is our menu.");
                Console.WriteLine("DRINKS");
                menu.DrinkMenu.ForEach(item => Console.WriteLine($"{item}"));
                Console.WriteLine("\nFOOD");
                menu.FoodMenu.ForEach(item => Console.WriteLine($"{item}"));
                while (true)
                {
                    //get main menu choice
                    int mainChoice = Options.GetMainChoice();
                    //add/remove choice

                    if (mainChoice == 1)
                    {
                        int addRemove = Options.AddOrRemove(menu);

                        if (addRemove == 1)
                        {
                            //food/drink choice
                            int foodOrDrink = Options.GetFoodOrDrink();
                            int itemChoice = Options.GetItem(foodOrDrink, menu);
                            //AddToCart(foodOrDrink, itemChoice)
                        }
                        else
                        {
                            //RemoveFromCart();
                        }
                    }
                    else if (mainChoice == 2)
                    {
                        //PrintCart();
                        Console.WriteLine("Thank you for shopping at Cafe Disco.\n Your total is: ");
                        //int total = GetTotal();
                        //ToPay(total);
                        break;
                    }





                    //secret option for admin to close software
                    else if (mainChoice == 96)
                    {
                        Console.WriteLine("Shutting down PoS terminal. Great job today serving all of these grateful customers.");
                        Environment.Exit(0);
                    }
                }
            }
        }
    }
}
