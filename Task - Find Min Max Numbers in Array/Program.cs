namespace Task___Find_Min_Max_Numbers_in_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declare and initialize an array of numbers
            int[] arrayOfNumbers = { 1, 2, 3, 4, 5 };

            // use Linq methods to find the minimum and maximum value in the array
            var minValue = arrayOfNumbers.Min();
            var maxValue = arrayOfNumbers.Max();

            // print the results to the console
            Console.WriteLine("The minimum value in array is {0}", minValue);
            Console.WriteLine("The maximum value in array is {0}", maxValue);
        }
    }
}