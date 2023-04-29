namespace Switch_Case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 33;

            switch(age)
            {
                case 15:
                    Console.WriteLine("Too young to party in the club!");
                    break;
                case 33:
                    Console.WriteLine("Good to go!");
                    break;
                default:
                    Console.WriteLine("How old are you then?");
                    break;
            }

            Console.ReadKey();
        }
    }
}