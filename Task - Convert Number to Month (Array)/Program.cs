namespace Task___Convert_Number_to_Month__Array_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the month of the year from 1 to 12");
            ConvertNumberToMonth();
        }

        static void ConvertNumberToMonth()
        {
            string[] months = new string[]
            {
                "January", "February", "March", "April", "May", "June",
                "July", "August", "September", "October", "November", "December"
            };

            const int MONTH_IN_YEAR = 12;

            while (true) 
            {
                string userInput = Console.ReadLine();

                if (userInput == null) 
                {
                    Console.WriteLine("Invalid input. Please enter the month of the year from 1 to 12");
                }
                else
                {
                    // Use int.TryParse to try to parse the user input as an int
                    bool success = int.TryParse(userInput, out int monthNumber);

                    if (success)
                    {
                        if (monthNumber >= 1 && monthNumber <= MONTH_IN_YEAR)
                        {
                            // Use the month number as the index of the array
                            // to get the name of the month
                            Console.WriteLine($"The month is {months[monthNumber - 1]}.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("The month number must be between 1 and 12. " +
                                "Please try again.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. " +
                            "Please enter the month of the year from 1 to 12");
                    }
                }
            }
        }
    }
}