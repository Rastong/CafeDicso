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
                //start new cart for new customer
                Cart myCart = new Cart();
                Console.WriteLine("Welcome to Cafe Disco! Peruse our menu below.");

                //print menus
                Console.WriteLine("___________________________________________________________\n");
                Console.WriteLine("DRINKS");
                Console.WriteLine("___________________________________________________________\n");
                Options.GetBeverageMenu(menu.DrinkMenu);
                Console.WriteLine("\n___________________________________________________________\n");
                Console.WriteLine("FOOD");
                Console.WriteLine("___________________________________________________________\n");
                Options.GetFoodMenu(menu.FoodMenu);

                while (true)
                {
                    //get main menu choice
                    int mainChoice = Options.GetMainChoice();
                    
                    //add/remove choice
                    if (mainChoice == 1)
                    {
                        int addRemove = Options.AddOrRemove(menu);

                        //add to cart
                        if (addRemove == 1)
                        {
                            //food/drink choice
                            int foodOrDrink = Options.GetFoodOrDrink();
                            int itemChoice = Options.GetItem(foodOrDrink, menu);
                            myCart.AddToCart(foodOrDrink, itemChoice);
                        }

                        //remove from cart
                        else
                        {
                            myCart.RemoveFromCart();
                        }

                        Console.Write("Press any key to continue: ");
                        Console.ReadKey();

                        Console.Clear();

                        //loop back to main choice
                        Console.WriteLine("\nThanks! Would you like to: ");
                    }

                    //checkout
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

                    //view cart
                    else if (mainChoice == 3)
                    {
                        Console.Clear();
                        myCart.PrintCart();
                        Console.WriteLine($"{"Your cart subtotal is",-35} ${myCart.GetSubTotal():0.00}");
                    }

                    //secret options for admins
                    //close software (CLOSE SHOP)
                    else if (mainChoice == 96)
                    {
                        Console.WriteLine("Shutting down PoS terminal. Great job today serving all of these grateful customers.");
                        Environment.Exit(0);
                    }

                    //add or remove items from menu
                    else if (mainChoice == 99)
                    {
                        //call on add or remove method
                        menu.AddOrRemove();
                    }
                }
            }
        }
    }
}
