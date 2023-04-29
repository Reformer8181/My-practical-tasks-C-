namespace Creating_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an object of my class
            // an instance of Human
            Human niko = new Human();
            // access public variable from outside, and even change it
            niko.firstName = "Niko";
            // call methods of the class
            niko.IntroduceMyself();

            Human michael = new Human();
            michael.firstName = "Michael";
            michael.lastName = "Jackson";
            michael.IntroduceMyself();

            Human robbie = new Human();
            robbie.firstName = "Robbie";
            robbie.lastName = "Williams";
            robbie.IntroduceMyself();

            Console.ReadKey();
        }
    }
}