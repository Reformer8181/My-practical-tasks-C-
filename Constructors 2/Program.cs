namespace Constructors_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Human Class
            Human human1 = new Human("Rick", 65);
            Human human2 = new Human("Morty", 16);

            human1.Eat();
            human1.Sleep();

            human2.Eat();
            human2.Sleep();

            // Car Class
            Car car1 = new Car("Ford", "Mustang", 2022, "red");
            Car car2 = new Car("Chevy", "Corvette", 2021, "blue");

            car1.Drive();
            car2.Drive();

            Console.ReadKey();
        }
    }
}