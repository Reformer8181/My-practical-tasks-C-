namespace Task___Smaller_String_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\nPlease write the first number, and press Enter: ");
            string firstNumber = Console.ReadLine();
            int firstNumberToInt = int.Parse(firstNumber);

            Console.Write("\nPlease write the second number, and press Enter: ");
            string secondNumber = Console.ReadLine();
            int secondNumberToInt = int.Parse(secondNumber);

            int smallerNumber = 0;

            if (firstNumberToInt <= secondNumberToInt)
            {
                smallerNumber = firstNumberToInt;
            }
            else
            {
                smallerNumber = secondNumberToInt;
            }

            string smallerNumberToString = Convert.ToString(smallerNumber);
            Console.WriteLine($"Smaller Number is {smallerNumberToString}");
            Console.ReadLine();
        }
    }
}