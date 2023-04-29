namespace Task___Reverses_String
{
    internal class Program
    {
        // --------- START FUNCTIONS ---------

        private static string ReadStringFromConsole()
        {
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Invalid input. Please enter a valid string.");
                return ReadStringFromConsole();
            }
            else
            {
                return input;
            }
        }

        private static string ReverseString(string input)
        {
            string reversed = "";
            if (!string.IsNullOrEmpty(input))
            {
                for (int i = input.Length - 1; i >= 0; i--)
                {
                    reversed += input[i];
                }
            }
            return reversed;
        }

        // ---------- END FUNCTIONS ----------

        static void Main(string[] args)
        {
            Console.WriteLine("Please write the string " +
                "what do you have reverse and press Enter");
            string UserString = ReadStringFromConsole();
            string ReverseUserString = ReverseString(UserString);

            Console.WriteLine("The reversed string is: " + ReverseUserString);
            
        }
    }
}