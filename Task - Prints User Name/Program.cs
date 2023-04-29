namespace Task___Prints_User_Name
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

        // ---------- END FUNCTIONS ----------
        static void Main(string[] args)
        {
            Console.WriteLine("Please input your name and press Enter: ");
            string userName = ReadStringFromConsole();

            // Output user name
            Console.WriteLine("Hello, {0}", userName);

            Console.ReadLine();
        }
    }
}