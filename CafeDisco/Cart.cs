using System;
using System.Collections.Generic;
using System.Text;

namespace CafeDisco
{
    class Cart
    {
        public Menu cafeMenu = new Menu();
        // List to hold all items customer purchases. Of class Menu and will hold items of Child class
        public List<Item> customerCart { get; set; }

        public Cart()
        {
            customerCart = new List<Item>();
        }

        //methods
        // Add menu item to cart
        public void AddToCart(int mainChoice, int itemChoice)
        {
            //add to cart and display item+price
            if (mainChoice == 1)
            {
                customerCart.Add(cafeMenu.DrinkMenu[itemChoice - 1]);
                Console.WriteLine($"You have added {cafeMenu.DrinkMenu[itemChoice - 1].Name} to your cart for ${cafeMenu.DrinkMenu[itemChoice - 1].Price:0.00}");
            }
            else
            {
                customerCart.Add(cafeMenu.FoodMenu[itemChoice - 1]);
                Console.WriteLine($"You have added {cafeMenu.FoodMenu[itemChoice - 1].Name} to your cart for ${cafeMenu.FoodMenu[itemChoice - 1].Price:0.00}");
            }
        }

        //remove menu item from cart
        public void RemoveFromCart()
        {
            if (customerCart.Count == 0)
            {
                Console.WriteLine("\nYour cart is empty. Try adding an item.\n");
            }

            else
            {
                //print cart
                PrintCart();

                //get customer input
                Console.Write($"\nWhich item would you like to remove? Enter a number 1 - {customerCart.Count}: ");
                int itemChoice = Validator.Validator.GetInt(1, customerCart.Count);

                //remove from cart and display item+price
                Console.WriteLine($"You have removed {customerCart[itemChoice - 1].Name} from your cart.");
                customerCart.Remove(customerCart[itemChoice - 1]);
            }
        }

        public void PrintCart()
        {
            int i = 1;
            Console.WriteLine("\nYour cart currently includes: ");
            customerCart.ForEach(item => Console.WriteLine($"{i++}. {item.Name,-35} ${item.Price:0.00}"));
        }

        public double GetSubTotal()
        {
            double cartSum = 0;
            customerCart.ForEach(item => cartSum += item.Price);

            return cartSum;
        }

        public double GetTax()
        {
            return GetSubTotal() * 0.06;
        }

        public double GrandTotal()
        {
            return GetSubTotal() + GetTax();
        }


       

    }
}
