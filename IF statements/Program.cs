namespace IF_statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter temperature in the other side: ");
            string userInput = Console.ReadLine();
            int temperature;
            int number;
            bool userEnteredANumber = int.TryParse(userInput, out number);

            if(userEnteredANumber)
            {
                temperature = number;
            }
            else
            {
                temperature = 0;
                Console.WriteLine("Value entered, was no number. 0 set as temperature");
            }

            if (temperature < 20)
            {
                Console.WriteLine("Take the coat");
            }
            else if (temperature == 20)
            {
                Console.WriteLine("Pant and Pull Over should be fine");
            }
            else if (temperature > 30) 
            {
                Console.WriteLine("It's super Hot!");
            }
            else 
            { 
                Console.WriteLine("Shorts are enought today"); 
            }

            Console.ReadKey();
        }
    }
}