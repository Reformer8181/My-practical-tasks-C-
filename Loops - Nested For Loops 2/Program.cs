namespace Loops___Nested_For_Loops_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // nested loops = loops inside of other loops
            //                Uses vary. Used a lot in sorting algorithms.

            Console.Write("How many rows?: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("How many colums?: ");
            int columns = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What symbol: ");
            String symbol = Console.ReadLine();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}