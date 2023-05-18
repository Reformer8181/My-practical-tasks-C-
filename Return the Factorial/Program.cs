using System.Linq.Expressions;

namespace Return_the_Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, write positive number and press Enter: ");
            string userInput = Console.ReadLine();
            int userNumber = int.Parse(userInput);

            int factorialNumber = 1;

            if (userNumber < 0)
            {
                Console.WriteLine("Invalid input. Please write positive number!");
            }
            else if (userNumber == 0) 
                {
                factorialNumber = 1;
            }
            else
            {
                
                while (userNumber != 1)
                {
                    factorialNumber = factorialNumber * userNumber;
                    userNumber = userNumber - 1;
                }
            }
            Console.WriteLine(factorialNumber);
            Console.ReadLine();
        }
    }
}