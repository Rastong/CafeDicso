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
                        Console.WriteLine("\nIf you would like to add a tip, please enter a percentage amount from 0-100.");
                        double tip = Validator.Validator.GetDouble(0, 100);
                        Payment printTip = new Payment(tip);
                        double tipTotal = printTip.GetTip(tip, myCart);
                        Console.WriteLine($"\nThank you for shopping at Cafe Disco." +
                            $"{"\nSubtotal: ",-35} ${myCart.GetSubTotal():0.00}" +
                            $"{"\nTax: ",-35} ${myCart.GetTax():0.00}" +
                            $"{"\nTip: ",-35} ${tipTotal:0.00}" +
                            $"{"\nGrand Total: ",-35} ${(myCart.GrandTotal() + tipTotal):0.00}");

                        Payment total = new Payment(myCart.GrandTotal() + tipTotal);
                        
                        total.ToPay();
                        Console.WriteLine("Thank you have a nice day!");
                        Console.WriteLine("\nPress any key for new customer order.");
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("");
                        break;
                    }

                    else if (mainChoice == 3)
                    {
                        Console.Clear();
                        myCart.PrintCart();
                        Console.WriteLine($"{"Your cart subtotal is",-35} ${myCart.GetSubTotal():0.00}");
                    }

                    //secret options for admins
                    //close software
                    else if (mainChoice == 96)
                    {
                        Console.WriteLine("Shutting down PoS terminal. Great job today serving all of these grateful customers.");
                        Environment.Exit(0);
                    }

                    //add or remove items from menu
                    else if (mainChoice == 99)
                    {
                        menu.AddOrRemove();
                    }
                }
            }
        }
    }
}
