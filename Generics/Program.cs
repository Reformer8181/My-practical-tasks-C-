namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  generic =   "not specific to a particular data type"
            //              add <T> to classes, methods, fields, etc.
            //              allows for code reusabilyty for different dsts types

            int[] intArray = { 1, 2, 3, 4, 5 };
            double[] doubleArray = { 1.0, 2.0, 3.0, 4.0, 5.0 };
            String[] stringArray = { "1", "2", "3", "4", "5" };

            displayElements(intArray);
            displayElements(doubleArray);
            displayElements(stringArray);


            Console.ReadKey();
        }
        public static void displayElements<T>(T[] array)
        {
            foreach (T element in array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
    }
}