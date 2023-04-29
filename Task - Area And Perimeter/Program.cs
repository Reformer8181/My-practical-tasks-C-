namespace Task___Area_And_Perimeter
{
    internal class Program
    {

        // --- Start functions ---

        // A function that reads an integer from the console
        static int ReadIntegerFromConsole()
        {
            // Read user input
            string input = Console.ReadLine();

            // Declare a variable to store the parsed integer
            int number;

            // Try to parse the input as an integer
            bool isValid = int.TryParse(input, out number);

            // If the input is valid, return the number
            if (isValid)
            {
                return number;
            }
            // Otherwise, display an error message and ask for another input
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                return ReadIntegerFromConsole();
            }
        }

        static int CalculateAreaOfRectangle(int length, int width)
        {
            return length * width;
        }

        static int CalculatePerimeterOfRectangle(int length, int width)
        {
            return 2 * (length + width);
        }

        // --- End functions ---

        static void Main(string[] args)
        {
            

            Console.WriteLine("Program calculates the area and perimeter");
            Console.WriteLine("Please write length of rectangle");
            int RectangleLength = ReadIntegerFromConsole();
            Console.WriteLine("Please write width of rectangle");
            int RectangleWidth = ReadIntegerFromConsole();

            int RectangleArea = CalculateAreaOfRectangle(RectangleLength, RectangleWidth);
            int RectanglePerimeter = CalculatePerimeterOfRectangle(RectangleLength, RectangleWidth);

            Console.WriteLine($"The area of rectangle = {RectangleArea}");
            Console.WriteLine($"The perimeter of rectangle = {RectanglePerimeter}");
        }
    }
}