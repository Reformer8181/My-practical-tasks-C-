namespace Task___Calculate_Exponent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int baseNumberInput = ReadIntegerFromConsole("Please, write a base number, and press Enter: ");
            int exponentNumberInput = ReadIntegerFromConsole("Please, write an exponent number, and press Enter: ");

            double result = Math.Pow(baseNumberInput, exponentNumberInput);
            Console.WriteLine($"Calculation of base number: {baseNumberInput} and exponent number {exponentNumberInput}, returns {result}");
        }

        static int ReadIntegerFromConsole(string prompt)
        {
            while (true)
            {
                Console.WriteLine(prompt);
                try
                {
                    string? input = Console.ReadLine();
                    if (input != null && int.TryParse(input, out int number))
                    {
                        return number;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid integer.");
                    }
                }
                catch (IOException e)
                {
                    Console.WriteLine($"An error occurred while reading input: {e.Message}");
                }
                catch (OutOfMemoryException e)
                {
                    Console.WriteLine($"An error occurred while reading input: {e.Message}");
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine($"An error occurred while reading input: {e.Message}");
                }
            }
        }
    }
}