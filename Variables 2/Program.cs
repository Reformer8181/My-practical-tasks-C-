namespace Variables_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;                  // declaration
            x = 123;                // initialization

            int y = 321;            // declaration + initialization

            int z = x + y;

            int age = 21;           // whole integer
            double height = 300.5;  // decimal number
            bool alive = true;      // true or false
            char symbol = '@';
            String name = "Bro";

            Console.WriteLine("Hello " + name);
            Console.WriteLine("Your age is " + age);
            Console.WriteLine("You height is " + height + "cm");
            Console.WriteLine("Are you alive? " + alive);
            Console.WriteLine("Your symbol is " + symbol);

            String userName = symbol + name;
            Console.WriteLine("Your username is " + userName);

            Console.ReadLine();
        }
    }
}

/*
 * In C#, `string` is an alias for the `System.String` class. 
 * So, `string name = "Bro";` and `String name = "Bro";` are equivalent. 
 * The only difference is that `String` requires the `System` namespace to be specified 
 * or imported, while `string` does not. 
 * It's a matter of style and convention which one you use.
 */