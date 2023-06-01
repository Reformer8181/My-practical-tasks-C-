namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* method - performs a section of code, whenever it's
             *          called "invoked".
             *          benefit = Let's us reuse code w/o writing it
             *                  multiple times.
             */

            String name = "Bro";
            int age = 21;

            singHappyBirthday(name, age);

            Console.ReadKey();
        }

        static void singHappyBirthday(String birthdayBOY, int yearsOld)
        {
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine("Happy birthday dear " + birthdayBOY);
            Console.WriteLine("You are " + yearsOld + " years old!");
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine();
        }
    }
}