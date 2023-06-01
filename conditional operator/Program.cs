namespace conditional_operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // conditional operator = used in conditional assignment if condition is true/false

            // (condition) ? x : y

            double temperature = 20;
            String message;

            message = (temperature >= 15) ? "It's warm outside!" : "It's cold outside!";

            Console.WriteLine(message);

            Console.ReadKey();
        }
    }
}