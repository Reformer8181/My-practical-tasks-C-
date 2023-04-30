namespace Task___Absolute_Sum_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbersArray = { 2, -1, 4, 8, 10 };
            int absoluteSum = 0;

            for (int index = 0; index < numbersArray.Length; index++)
            {
                int positiveValue = numbersArray[index];
                positiveValue = Math.Abs(positiveValue);
                absoluteSum += positiveValue;
            }
            // Output Absolute Sum
            Console.WriteLine("Absolute sum array: {0}", absoluteSum);
        }
    }
}