namespace Task___User_Age
{
    internal class Program
    {

        // --------- START FUNCTIONS ---------

        // A function that reads an integer from the console
        static int ReadIntegerFromConsole()
        {
            try
            {
                var input = Console.ReadLine();
                return int.Parse(input);
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                Console.WriteLine(e.Message);
                return 0;
            }
        }

        private static void OutputAgeStatus(int age)
        {
            const int MIN_AGE = 0;
            switch (age)
            {
                case <= MIN_AGE:
                    Console.WriteLine("Invalid age.");
                    break;
                case < 18: 
                    Console.WriteLine($"You are {age} years old. You are child.");
                    break;
                case >= 18 and < 60:
                    Console.WriteLine($"You are {age} years old. You are adult.");
                    break;
                case >= 60:
                    Console.WriteLine($"You are {age} years old. You are elder.");
                    break;
                default:
                    Console.WriteLine($"Unexpected value for {nameof(age)}.");
                    break;
            }
        }

        // ---------- END FUNCTIONS ----------

        static void Main(string[] args)
        {
            Console.WriteLine("How old are you?" + 
                Environment.NewLine);
            var age = ReadIntegerFromConsole();

            OutputAgeStatus (age);

            Console.ReadLine();
        }
    }
}