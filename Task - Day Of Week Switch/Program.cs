namespace Task___Day_Of_Week_Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get the current day of the week as an enum value
            DayOfWeek today = DateTime.Now.DayOfWeek;

            // Use a switch statement to print different messages based on the day of the week
            switch (today)
            {
                case DayOfWeek.Sunday:
                    Console.WriteLine("Have a relaxing Sunday!");
                    break;
                case DayOfWeek.Monday:
                    Console.WriteLine("Happy Monday!");
                    break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine("Have a terrific Tuesday");
                    break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine("Welcome to Wednesday");
                    break;
                case DayOfWeek.Thursday:
                    Console.WriteLine("It's a great day to be alive!");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("Finally, it's Friday!");
                    break;
                case DayOfWeek.Saturday:
                    Console.WriteLine("Enjoy your weekend!");
                    break;
                default:
                    Console.WriteLine("What day is it?");
                    break;
            }
        }
    }
}