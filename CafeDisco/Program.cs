using System;
using System.Collections.Generic;

namespace CafeDisco
{
    class Program
    {
        List<Item> menu = new List<Item>();
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Hello World!");
            Payment.PaymentWithCash(30);
            Payment.PayWithCheck(60);
            Payment.PayWithCard(60);
            */
            
            // Start of Payment
            Payment.ToPay(60);
        }

    }
}
