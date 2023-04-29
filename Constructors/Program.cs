namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human robbieWilliams = new Human(
                "Robbie", 
                "Williams", 
                "green", 49);
            robbieWilliams.IntroduceMyself();

            Human michaelJackson = new Human(
                "Michael",
                "Jackson",
                "dark brown", 50);
            michaelJackson.IntroduceMyself();

            Console.ReadLine();
        }
        
    }
}