namespace Arrays___Jagged_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // index                       0    1    2   3
            // normal array of type int: [15],[21],[23],[13]

            // index                                0                           1                   2
            // jagged array of type int: [array1([15],[21],[23],[13])],[array1([7],[8],[2])],[array1([2],[4])]

            // declare jaggedArray
            int[][] jaggedArray = new int[3][];

            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[3];
            jaggedArray[2] = new int[2];

            jaggedArray[0] = new int[] { 2, 3, 5, 7, 11 };
            jaggedArray[1] = new int[] { 1, 2, 3 };
            jaggedArray[2] = new int[] { 13, 12 };

            // alternative way:
            int[][] jaggedArray2 = new int[][]
            {
                new int[] { 2, 3, 5, 7, 11 },
                new int[] { 1, 2, 3 }
            };

            Console.WriteLine("The value in the middle of first entry is {0}", jaggedArray2[0][2]);

            // output all num in console
            for (int i = 0; i < jaggedArray2.Length; i++)
            {
                Console.WriteLine("\nElement {0}", i);
                for (int j = 0; j < jaggedArray2[i].Length; j++)
                {
                    Console.Write(jaggedArray2[i][j] + " ");
                }
            }

            Console.ReadKey();
        }
    }
}