using System;
using System.Collections.Generic;
using System.Text;

namespace Validator
{
    class Validator
    {
        public static double GetDouble()
        {
            while (true)
            {
                try
                {
                    double result = double.Parse(Console.ReadLine());
                    return result;
                }
                catch(FormatException e)
                {
                    Console.WriteLine("That was not a number. Try again: ");
                }
            }
        }

        public static double GetDouble(double min, double max)
        {
            while (true)
            {
                double result = GetDouble();

                if (result < min || result > max)
                {
                    Console.WriteLine($"This number is out of range. Please enter a number from {min} to {max}: ");
                }
                else
                {
                    return result;
                }
            }
        }

        public static int GetInt()
        {
            while (true)
            {
                try
                {
                    int result = int.Parse(Console.ReadLine());
                    return result;
                }
                catch (FormatException e)
                {
                    Console.Write("That was not a number. Enter an integer: ");
                }
            }
        }

        public static int GetInt(int min, int max)
        {
            while (true)
            {
                int result = GetInt();

                if (result < min || result > max)
                {
                    Console.Write($"\nThis number is out of range. Please enter a number from {min} to {max}: ");
                }
                else
                {
                    return result;
                }
            }
        }

        public static int GetInt(int numOfDigits)
        {
            while (true)
            {
                int result = GetInt();
                int count = result.ToString().Trim().Length;

                if (count > numOfDigits)
                {
                    Console.WriteLine($"Invalid input. Please only enter {numOfDigits} digits.");
                }
                else
                {
                    return result;
                }
            }
        }

        public static bool Repeat()
        {
            while (true)
            {
                Console.Write("\nWould you like to run the program again? (y/n): ");
                string answer = Console.ReadLine().ToLower().Trim();

                if (answer == "n")
                {
                    Console.WriteLine("\nGoodbye!");
                    return false;
                }
                else if (answer == "y")
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("\nInvalid input. Try again.\n");
                }
            }
        }

        public static bool Repeat(string repeatMessage)
        {
            while (true)
            {
                Console.Write($"\n{repeatMessage} (y/n): ");
                string answer = GetString("y/n").ToLower().Trim();

                if (answer == "n")
                {
                    return false;
                }
                else if (answer == "y")
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("\nInvalid input. Try again.\n");
                }
            }
        }

        public static string GetString()
        {
            while (true)
            {
                string result = Console.ReadLine();

                if (result == null)
                {
                    Console.WriteLine("\nYour input is blank. Please enter valid input.");
                }
                else
                {
                    return result;
                }
            }
        }

        public static string GetString(string validInput)
        {
            while (true)
            {
                string result = Console.ReadLine();

                if (result == "")
                {
                    Console.Write($"\nYour input is blank. Please enter {validInput}. ");
                }
                else
                {
                    return result;
                }
            }
        }

        public static int GetCheckNumber(int numOfDigits)
        {
            while (true)
            {
                int result = GetCheckNumber();
                int count = result.ToString().Trim().Length;

                if (count > numOfDigits + 2 || count < numOfDigits)
                {
                    Console.WriteLine($"Invalid input. Please only enter {numOfDigits}-{numOfDigits + 2} digits.");
                }
                else
                {
                    return result;
                }
            }
        }

        public static int GetCheckNumber()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Please enter the check number");
                    int result = int.Parse(Console.ReadLine());
                    return result;
                }
                catch (FormatException e)
                {
                    Console.Write("That was not a number. Enter an integer: ");
                }
            }
        }

        public static long GetCardNumber(int numOfDigits)
        {
            while (true)
            {
                long result = GetCardNumber();
                long count = result.ToString().Trim().Length;

                if (count != numOfDigits)
                {
                    Console.WriteLine($"Invalid input. Please only enter {numOfDigits} digits.");
                }
                else
                {
                    return result;
                }
            }
        }

        public static long GetCardNumber()
        {
            long cardNum = 0;
            while (true)
            {
                try
                {
                    Console.WriteLine("Please enter the card number. ####-####-####-####");
                    string input = Console.ReadLine();
                    input = input.Replace("-", string.Empty);
                    Console.WriteLine(input);
                    cardNum = long.Parse(input);
                    return cardNum;

                }
                catch (FormatException e)
                {
                    Console.Write("That was not a number. Enter an integer: ");
                }
            }
        }
    }
}
