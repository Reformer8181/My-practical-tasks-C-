namespace TryAndCatch___Cathing_Errors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number!");
            string userInput = Console.ReadLine();

            int num1 = 5;
            int num2 = 0;

            try
            {
                int divide = num1 / num2;
            }
            catch (DivideByZeroException) 
            {
                Console.WriteLine("Divide By Zero Exception");
            }

            try
            {
                int userInputAsInt = int.Parse(userInput);
            }
            catch (FormatException)
            {
                Console.WriteLine("Format exeption, please enter the correct type next time");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow exception, the number was too long or too short for an int32");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Argument Null exception, the value was empty(null)");
            }
            finally
            {
                Console.WriteLine("This is called anyways!");
            }

            

            Console.ReadKey();
        }
    }
}