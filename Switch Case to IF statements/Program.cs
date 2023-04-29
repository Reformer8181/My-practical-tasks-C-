namespace Switch_Case_to_IF_statements
{
    internal class Program
    {
        const int ADULT_AGE = 18;
        static void Main(string[] args)
        {
            int age = 18;

            if (age < ADULT_AGE)
            {
                Console.WriteLine("Too young to party in the club!");
            }
            else if (age >= ADULT_AGE) 
            {
                Console.WriteLine("Good to go!");
            }
            else 
            { 
                Console.WriteLine("How old are you then?"); 
            }
            Console.ReadKey();
        }
    }
}