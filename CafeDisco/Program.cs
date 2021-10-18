using System;
using System.Collections.Generic;
namespace CafeDisco
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            Cart myCart = new Cart();
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
                        myCart.AddToCart(foodOrDrink, itemChoice);
                    }
                    else
                    {
                        myCart.RemoveFromCart();
                    }

                    Console.Write("Press any key to continue: ");
                    Console.ReadKey();

                    Console.Clear();

                    Console.WriteLine("\nThanks! Would you like to: ");
                }

                else if (mainChoice == 2)
                {

                    Console.Clear();
                    myCart.PrintCart();
                    Console.WriteLine($"\nThank you for shopping at Cafe Disco." + 
                        $"{"\nSubtotal: ",-35} ${myCart.GetSubTotal():0.00}" + 
                        $"{"\nTax: ",-35} ${myCart.GetTax():0.00}" + 
                        $"{"\nGrand Total: ",-35} ${myCart.GrandTotal():0.00}");
                    break;
                }

                else if (mainChoice == 3)
                {
                    Console.Clear();
                    myCart.PrintCart();
                    Console.WriteLine($"{"Your cart subtotal is", -35} ${myCart.GetSubTotal():0.00}");
                }

                else if (mainChoice == 99)
                {
                    menu.AddOrRemove();
                }
            }
        }
    }
}
