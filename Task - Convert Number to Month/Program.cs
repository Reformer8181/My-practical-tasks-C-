using System.Numerics;
using System;

namespace Task___Convert_Number_to_Month
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the month of the year from 1 to 12");
            string userInput = Console.ReadLine();
            ConvertNumberToMonth(userInput);
            Console.ReadLine();
        }

        static void ConvertNumberToMonth(string userInput) // Add a parameter to receive the user input
        {
            try
            {
                if (userInput == null)
                {
                    Console.WriteLine("Invalid input. Please enter the month of the year from 1 to 12");
                }
                else
                {
                    const int MONTH_IN_YEAR = 12;
                    int monthNumber = int.Parse(userInput);
                    try
                    {
                        checked
                        {
                            if (monthNumber == 0)
                            {
                                Console.WriteLine("The month number cannot be 0. " +
                                    "Please enter the month of the year from 1 to 12");
                            }
                            else if (monthNumber < 0)
                            {
                                Console.WriteLine("The month number cannot be < 0. " +
                                    "Please enter the month of the year from 1 to 12");
                            }
                            else if (monthNumber > MONTH_IN_YEAR) // Use > instead of <
                            {
                                Console.WriteLine($"The month number cannot be > {MONTH_IN_YEAR}. " +
                                    "Please enter the month of the year from 1 to 12");
                            }
                            else
                            {
                                switch (monthNumber)
                                {
                                    case 1: // Add a semicolon
                                        Console.WriteLine("The month is January.");
                                        break;
                                    case 2:
                                        Console.WriteLine("The month is February.");
                                        break;
                                    case 3:
                                        Console.WriteLine("The month is March.");
                                        break;
                                    case 4:
                                        Console.WriteLine("The month is April.");
                                        break;
                                    case 5:
                                        Console.WriteLine("The month is May.");
                                        break;
                                    case 6:
                                        Console.WriteLine("The month is June.");
                                        break;
                                    case 7:
                                        Console.WriteLine("The month is July.");
                                        break;
                                    case 8:
                                        Console.WriteLine("The month is August.");
                                        break;
                                    case 9:
                                        Console.WriteLine("The month is September.");
                                        break;
                                    case 10:
                                        Console.WriteLine("The month is October.");
                                        break;
                                    case 11:
                                        Console.WriteLine("The month is November.");
                                        break;
                                    case 12:
                                        Console.WriteLine("The month is December.");
                                        break;
                                    default: // Add a default case
                                        Console.WriteLine("Invalid input. Please enter the month of the year from 1 to 12");
                                        break;
                                }
                            }
                        }
                    }
                    catch (OverflowException e)
                    {
                        Console.WriteLine("The input number is too large to convert to a month.");
                        Console.WriteLine(e.Message);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid input. Please enter the month of the year from 1 to 12");
                Console.WriteLine(e.Message);
            }
        }
    }
}