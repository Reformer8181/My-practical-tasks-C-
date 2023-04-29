namespace Casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool boolFromString = bool.Parse("true");
            int intFromString = int.Parse("100");
            double doubleFromString = double.Parse("1.234");

            string stringValue = doubleFromString.ToString();
            Console.WriteLine($"Data type : {stringValue.GetType()}");
            double doubleNumber = 12.345;
            Console.WriteLine($"Integer : {(int)doubleNumber}");
            int intNumber = 10;
            long longNumber = intNumber;
        }
    }
}