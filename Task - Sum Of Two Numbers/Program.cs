using System;

namespace Task___Sum_Of_Two_Numbers
{
    internal class Program
    {
        // --------- START FUNCTIONS ---------

        // A function that reads an integer from the console
        static int ReadIntegerFromConsole()
        {
            // Read user input
            string? input = Console.ReadLine();

            // Declare a variable to store the parsed integer
            int number;

            // Try to parse the input as an integer
            bool isValid = int.TryParse(input, out number);

            // If the input is valid, return the number
            if (isValid)
            {
                return number;
            }
            // Otherwise, display an error message and ask for another input
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                return ReadIntegerFromConsole();
            }
        }

        // A function that adds two integers and returns the result
        static int AddTwoIntegers(int number1, int number2)
        {
            int result = number1 + number2;
            return result;
        }

        // ---------- END FUNCTIONS ----------
        static void Main(string[] args)
        {
            Console.WriteLine("Please input two numbers");

            // Read the first number from the console
            Console.Write("Input first number and press Enter: ");
            var number1 = ReadIntegerFromConsole();

            // Read the second number from the console
            Console.Write("Input second number and press Enter: ");
            var number2 = ReadIntegerFromConsole();

            // Add the two numbers and store the result
            var sum = AddTwoIntegers(number1, number2);

            // Display the result using string interpolation
            Console.WriteLine($"{number1} + {number2} = {sum}");

            Console.ReadKey();
        }
    }
}