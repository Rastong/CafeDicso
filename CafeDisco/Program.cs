using System;

namespace CafeDisco
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
            Payment.PaymentWithCash(30);
            Payment.PayWithCheck();
            Payment.PayWithCard();
        }
    }
}
