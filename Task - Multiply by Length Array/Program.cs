namespace Task___Multiply_by_Length_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intsArray = { 2, 3, 1, 0 };

            // Get the length of the array
            int ammountOfValuesInArray = intsArray.Length;

            // Loop through each element of the array
            for (int i = 0; i < ammountOfValuesInArray; i++)
            {
                intsArray[i] = intsArray[i] * ammountOfValuesInArray;
            }

            string output = "";

            foreach (int i in intsArray)
            {
                output += i + ", ";
            }

            output = output.Substring(0, output.Length - 2);
            Console.WriteLine(output);
        }
    }
}