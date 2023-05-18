//
// Type Casting in C#
//

// Converting data after it has been assigned at compilation
// Implicit & Explicit

namespace Casting_Example_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 1234.7;
            int a;
            // Cast double to int. EXPLICIT CONVERSION
            a = (int)x;
            Console.WriteLine(a);
        }
    }
}