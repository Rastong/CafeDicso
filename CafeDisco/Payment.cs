using System;

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
            Console.WriteLine("Please enter the card number. ####-####-####-####");
            long cardNum = Validator.Validator.GetCardNumber(16);
            Console.WriteLine("Please enter the expirtaion date. ##/##/####");
            int ExpirationDate = Validator.Validator.GetExpirationDate(8);
            Console.WriteLine("Pleae enter the security number. ###");
            int CVV = Validator.Validator.GetInt(3);
            Console.WriteLine($"A total of ${total} has been charged to your account.");
        }

        public static void PayWithCheck(double total)
        {
            Console.WriteLine("Please enter the check number. ###");
            int checkNumber = Validator.Validator.GetInt(3);
            Console.WriteLine($"Thank you for the check {checkNumber} and total of ${total}.");
        }

        public static void PaymentWithCash(double total)
        {
            try
            {
                bool Repeat = true;
                while (Repeat)
                {
                    Console.WriteLine($"For a total of ${total}, how much cash will you be giving today?");
                    double cashGivin = double.Parse(Console.ReadLine());
                    if (cashGivin >= total)
                    {
                        double change = cashGivin - total;
                        Console.WriteLine($"Your change back is ${change}.");
                        Repeat = false;
                    }
                    else
                    {
                        Console.WriteLine($"Oops, You have not given me enough. Please try again");
                    }
                }
            }
            catch (FormatException e)
            {
                Console.Write("That was not a number. Enter a number. ");
            }
        }

        //Finds out how they want to pay
        public static string ToPay(double total)
        {
            string PaymentType = "";
            bool ValidPaymentOption = true;
            while (ValidPaymentOption)
            {
                //|Makes sure that it is a valid option| Makes sure they write something|
                PaymentType = GetString(total);
                ValidPaymentOption = WhichPayment(PaymentType, total);
            }
            return PaymentType;
        }

        //Checks to make sure nothing isnt typed in
        public static string GetString(double total)
        {

            Console.WriteLine($"Your total today is ${total}. Will you be paying with Cash, Card, or Check?");
            return Validator.Validator.GetString();

        }

        //Reference back to payment class to the paying option
        public static bool WhichPayment(string payment, double total)
        {
            bool result = true;
            if (payment == "cash")
            {
                CafeDisco.Payment.PaymentWithCash(total);
                result = false;
            }
            else if (payment == "card")
            {
                CafeDisco.Payment.PayWithCard(total);
                result = false;
            }
            else if (payment == "check")
            {
                CafeDisco.Payment.PayWithCheck(total);
                result = false;

            }
            else
            {
                Console.WriteLine("\nInvalid input. Try again.\n");
            }
            return result;
        }

    }
}
