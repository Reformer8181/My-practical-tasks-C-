using System.Runtime.InteropServices;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Boolean
            bool canIVoteTrue = true;
            bool canIVoteFalse = false;

            // Integer
            Console.WriteLine("Biggest Integer : {0}", int.MaxValue);
            Console.WriteLine("Smallest Integer : {0}", int.MinValue);

            // Long
            Console.WriteLine("\nBiggest Long : {0}", long.MaxValue);
            Console.WriteLine("Smallest Long : {0}", long.MinValue);

            // Decimal
            Console.WriteLine("\nBiggest Decimal : {0}", Decimal.MaxValue);
            Console.WriteLine("Smallest Decimal : {0}", Decimal.MinValue);

            decimal decPiVal = 3.1415936535897932384626433832M;
            decimal decBigNum = 3.00000000000000000000000000011M;
            Console.WriteLine("DEC : PI + bigNum = {0}", decPiVal + decBigNum);

            // Double
            Console.WriteLine("\nBiggest Double : {0}", Double.MaxValue);
            Console.WriteLine("Smallest Double : {0}", Double.MinValue);

            double dblPiVal = 3.14159365358979;
            double dblBigNum = 3.000000000000002;
            Console.WriteLine("DBL : PI + bigNum = {0}", dblPiVal + dblBigNum);

            // Float
            Console.WriteLine("\nBiggest Float : {0}", float.MaxValue);
            Console.WriteLine("Smallest Float : {0}", float.MinValue);

            float fltPiVal = 3.141592F;
            float fltBigNum = 3.000002F;
            Console.WriteLine("FLT : PI + bigNum = {0}", fltPiVal + fltBigNum);

            Console.ReadKey();
        }
    }
}