namespace Loops___BREAK___CONTINUE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Break example:");
            for (int counter = 0; counter < 10; counter ++)
            {
                if (counter == 3) 
                {
                    Console.WriteLine("At 3 we stop!");
                    break;
                }
                Console.WriteLine(counter);
            }

            Console.WriteLine();

            Console.WriteLine("Continue example 1:");
            for (int counter = 0; counter < 10; counter++)
            {
                if (counter == 3)
                {
                    Console.WriteLine("We skip number 3!");
                    continue;
                }
                Console.WriteLine(counter);
            }

            Console.WriteLine();

            Console.WriteLine("Continue example 2:");
            for (int counter = 0; counter < 10; counter++)
            {
                if (counter % 2 == 0)
                {
                    Console.WriteLine("Now comes an odd number!");
                    continue;
                }
                Console.WriteLine(counter);
            }

            Console.Read();
        }
    }
}