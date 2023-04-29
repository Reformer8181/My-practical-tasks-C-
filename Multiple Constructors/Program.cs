using Constructors;

namespace Multiple_Constructors
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
                "dark brown");
            michaelJackson.IntroduceMyself();

            Human basicHuman = new Human();
            basicHuman.IntroduceMyself();

            Human natalie = new Human("Natalie");
            natalie.IntroduceMyself();

            Human michaelMiller = new Human("Michael", "Miller");
            michaelMiller.IntroduceMyself();

            Human frank = new Human("Frank", "Walter", 39);
            frank.IntroduceMyself();

            Console.ReadLine();
        }
    }
}