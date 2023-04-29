using System.Threading.Channels;

namespace IF_statements___nested_if_statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isAdmin = false;
            bool isRegistered = true;
            string userName = "";
            Console.WriteLine("Please enter your username:");

            userName = Console.ReadLine();
            if (isRegistered && userName != "" && userName.Equals("admin"))
            {
                Console.WriteLine("Hi there, register user");

                Console.WriteLine("Hi there, " + userName);

                Console.WriteLine("Hi there, Admin");

            }

            if (isAdmin || isRegistered)
            {
                Console.WriteLine("You are logged in");
            }
            Console.ReadKey();
        }
    }
}