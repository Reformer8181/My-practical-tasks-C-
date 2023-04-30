namespace Task___Return_the_Next_Number
{
    internal class Program
    {
        // --- Functions starts ---

        // A function that reads an integer from the console
        static void ReadAndIncrementNumberFromConsole()
        {
            try
            {
                string input = Console.ReadLine();

                if (input == null)
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
                else
                {
                    int number = int.Parse(input);
                    try
                    {
                        checked
                        {
                            Console.WriteLine($"Increment number of {number} is {++number}");
                        }
                    }
                    catch (OverflowException e)
                    {
                        Console.WriteLine("The input number is too large to increment.");
                        Console.WriteLine(e.Message);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                Console.WriteLine(e.Message);
            }
        }
        // --- Functions end ---


        static void Main(string[] args)
        {
            Console.Write("Please write the number, and press Enter: ");
            ReadAndIncrementNumberFromConsole();
            Console.ReadLine();
        }
    }
}