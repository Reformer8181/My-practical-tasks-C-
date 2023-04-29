namespace Loops___FOR_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For loop - example 1:");
            for (int counter = 0; counter < 10; counter++)
            {
                Console.WriteLine(counter);
            }

            Console.WriteLine("For loop - example 2:");
            for (int counter = 0;counter < 50; counter+=5) 
            {
                Console.WriteLine(counter + " is lower than 50");
            }

            Console.ReadKey();
        }
    }
}