//
// Type Casting in C#
//

// Converting data after it has been assigned at compilation
// Implicit & Explicit

namespace Casting___TryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string value = "df4545548";
            int result = 0;

            if(int.TryParse(value, out result))
            {
                Console.WriteLine("Success: " + result);
            }
            else
            {
                Console.WriteLine("Failure.");
            }
        }
    }
}