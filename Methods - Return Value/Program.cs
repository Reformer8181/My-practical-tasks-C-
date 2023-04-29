namespace Methods___Return_Value
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multiply method: " + Multiplay(25, 25));
            Console.WriteLine("Add method: " + Add(Add(1, 2), Add(3, 4)));
            Console.WriteLine("Add method: " + Add(31, 25));
            Console.WriteLine("Devide method: " + Devide(25, 13));
            Console.Read();
        }

        public static int Add(int parameter1, int parameter2)
        {
            return parameter1 + parameter2;
        }

        public static int Multiplay(int num1, int num2)
        {
            return num1 * num2;
        }

        public static double Devide(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}