namespace Return_Keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // return - returns data back to the place where a method is invoked


            double x;
            double y;

            Console.WriteLine("Enter in number 1: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter in number 2: ");
            y = Convert.ToDouble(Console.ReadLine());

            double result = Multiply(x, y);

            Console.WriteLine(result);

            Console.ReadKey();
        }

        static double Multiply(double x, double y)
        {
            return x * y;
        }
    }
}