namespace Code_Monkey_CS_BASICS___CS_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            //variables
            int i = 56;

            Console.WriteLine("Hello, World!" + i);

            TestFunction();
            bool b = SecondTestFunction(i);

            Console.ReadKey();
        }

        // return nothing
        static void TestFunction()
        {

        }

        static bool SecondTestFunction(int i)
        {
            return i < 100;
        }
    }
}