namespace _2D_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declare 2D array
            string[,] matrix;

            // declare 3D array
            int[,,] threeD;

            // two dimensional array
            int[,] array2D = new int[,]
            {
                {1, 2, 3}, //row 0
                {4, 5, 6}, //row 1
                {7, 8, 9}  //row 2
            };

            Console.WriteLine("Central value is {0}", array2D[1, 1]);

            string[,,] array3D = new string[,,]
            {
                {
                    {"000", "001"},
                    {"010", "011"},
                    {"Hi there", "What's up"}
                },
                {
                    {"100", "100"},
                    {"110", "111"},
                    {"Another one", "Last entry"}
                }
            };

            string[,] array2DString = new string[3, 2]
            {
                {"one", "two"},
                {"three", "four"},
                {"five", "six"}
            };

            array2DString[1, 1] = "chicken";

            // Rank returns the amount of dimensions
            int dimensions = array2DString.Rank;

            int[,] array2D2 = { { 1, 2 }, { 3, 4 } };

            Console.WriteLine("The value is {0}", array3D[0, 2, 0]);
            Console.WriteLine("The last entry is {0}", array3D[1, 2, 1]);
            Console.WriteLine("The value in array2DString is {0}", array2DString[1, 1]);
            Console.WriteLine("The dimensions array2DString is {0}", dimensions);

            Console.ReadKey();
        }
    }
}