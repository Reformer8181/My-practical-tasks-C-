namespace Convert_Minutes_into_Seconds
{
    internal class Program
    {

        // A function that reads an integer from the console
        static int ReadMinutesFromConsole()
        {
            string input = Console.ReadLine();

            int minutes;

            bool isValid = int.TryParse(input, out minutes);

            if (isValid)
            {
                return minutes;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                return ReadMinutesFromConsole();
            }
        }

        static int ConvertMinutesToSeconds(int minutes)
        {

            const int SECONDS_IN_MINUTE = 60;

            if (minutes < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            return minutes * SECONDS_IN_MINUTE;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Plese write the minutes to convert in seconds and press Enter: ");
            int userMinutes = ReadMinutesFromConsole();

            int secondsInMinutes = ConvertMinutesToSeconds(userMinutes);
            Console.WriteLine($"In {userMinutes} minutes -> {secondsInMinutes} seconds");
        }
    }
}