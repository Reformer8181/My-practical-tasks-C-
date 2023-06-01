namespace Arrays_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // array = a variable that can store multiple values. fixed size

            String[] cars = { "BMW", "Mustang", "Corvette" };

            cars[0] = "Tesla";

            Console.WriteLine(cars[0]);
            Console.WriteLine(cars[1]);

            Console.WriteLine("\t Output all values in array - for loop");

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }

            // Array - Example 2

            Console.WriteLine("\tNew Array  - smartphones");

            String[] smartphones = new string[3];
            smartphones[0] = "Apple";
            smartphones[1] = "Samsung";
            smartphones[2] = "Xiaomi";

            for (int i = 0;i < smartphones.Length; i++)
            {
                Console.WriteLine(smartphones[i]);
            }

            Console.ReadKey();
        }
    }
}