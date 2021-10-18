using System;
using System.Collections.Generic;
using System.Text;

namespace CafeDisco
{
    class Payment
    {
        //Properties
        public double Total { get; set; }

        //Constructor
        public Payment(double total)
        {
            Total = total;
        }

        //Methods
        public static void PayWithCard(double total)
        {
            long cardNum = Validator.Validator.GetCardNumber(16);
            int ExpirationDate = Validator.Validator.GetExpirationDate(8);
            int CVV = Validator.Validator.GetCVV(3);
            Console.WriteLine($"A total of ${total} has been charged to your account.");
        }

        public static void PayWithCheck(double total)
        {
            int checkNumber = Validator.Validator.GetCheckNumber(3);
            Console.WriteLine($"Thank you for the check {checkNumber} and total of ${total}.");
        }

        public static double PaymentWithCash(double total)
        {
            while (true)
            {
                double cashGivin = 0;
                try
                {
                    while (true)
                    {
                        Console.WriteLine($"For a total of ${total}, how much cash will you be giving today?");
                        cashGivin += double.Parse(Console.ReadLine());
                        if (cashGivin >= total)
                        {
                            double change = cashGivin - total;
                            return change;
                        }
                        else
                        {
                            Console.WriteLine($"Oops, You have only givin me ${cashGivin} out of ${total}. You still owe another {total - cashGivin} dollars");
                        }
                    }
                }
                catch (FormatException e)
                {
                    Console.Write("That was not a number. Enter a number. ");
                }
            }
        }

        //Finds out how they want to pay
        public static string ToPay(double total)
        {
            string PaymentType = "";
            bool ValidPaymentOption = true;
            while (ValidPaymentOption)
            {
                //                   |Makes sure that it is a valid option| Makes sure they write something|
                PaymentType = Validator.Validator.GetString(total);
                ValidPaymentOption = Validator.Validator.WhichPayment(PaymentType, total);
            }
            return PaymentType;
        }
    }
}
