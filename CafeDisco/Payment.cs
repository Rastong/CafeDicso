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
        public void PayWithCard()
        {
            Console.WriteLine("Please enter the card number. ####-####-####-####");
            long cardNum = Validator.Validator.GetCardNumber(16);
            Console.WriteLine("Please enter the expirtaion date. ##/##/####");
            int ExpirationDate = Validator.Validator.GetExpirationDate(8);
            Console.WriteLine("Pleae enter the security number. ###");
            int CVV = Validator.Validator.GetInt(3);
            Console.WriteLine($"A total of ${Total} has been charged to your account.");
        }
        public void PayWithCheck()
        {
            Console.WriteLine("Please enter the check number. ###");
            int checkNumber = Validator.Validator.GetInt(3);
            Console.WriteLine($"Thank you for the check {checkNumber} and total of ${Total}.");
        }

        public void PaymentWithCash()

        {
            try
            {
                bool Repeat = true;
                while (Repeat)
                {
                    Console.WriteLine($"For a total of ${Total}, how much cash will you be giving today?");
                    double cashGivin = double.Parse(Console.ReadLine());
                    if (cashGivin >= Total)
                    {
                        double change = cashGivin - Total;
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
        public string ToPay()
        {
            string PaymentType = "";
            bool ValidPaymentOption = true;
            while (ValidPaymentOption)
            {
                //|Makes sure that it is a valid option| Makes sure they write something|
                PaymentType = GetString();
                ValidPaymentOption = WhichPayment(PaymentType);
            }
            return PaymentType;
        }

        //Checks to make sure nothing isnt typed in
        public string GetString()
        {

            Console.WriteLine($"Your total today is ${Total}. Will you be paying with Cash, Card, or Check?");
            return Validator.Validator.GetString();

        }

        //Reference back to payment class to the paying option
        public bool WhichPayment(string payment)
        {
            bool result = true;
            if (payment == "cash")
            {
                PaymentWithCash();
                result = false;
            }
            else if (payment == "card")
            {
                PayWithCard();
                result = false;
            }
            else if (payment == "check")
            {
                PayWithCheck();
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
