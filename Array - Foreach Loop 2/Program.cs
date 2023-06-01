namespace Array___Foreach_Loop_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // foreach loop - a simpler way to iterate over an array,
            //                  but it's less flexible.

            String[] cars = { "BMW", "Mustang", "Corvette" };

            Console.WriteLine("\tFor loop:");
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }

            Console.WriteLine("\tForeach loop:");
            foreach (String car in cars)
            {
                Console.WriteLine(car);
            }

            Console.ReadKey();
        }
    }
}