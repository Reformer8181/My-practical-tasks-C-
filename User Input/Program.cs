namespace User_Input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, write you message here: ");
            string input = Console.ReadLine();
            Console.WriteLine("You message: " + input);

            Add();
            Console.Read();
        }

        public static void Add()
        {
            Console.WriteLine("Please, write you first number here: ");
            string number1Input = Console.ReadLine();
            Console.WriteLine("Please, write you second number here: ");
            string number2Input = Console.ReadLine();

            int num1 = int.Parse(number1Input);
            int num2 = int.Parse(number2Input);
            int sum = num1 + num2;

            Console.WriteLine($"{num1} + {num2} = {sum}");
        }
    }
}