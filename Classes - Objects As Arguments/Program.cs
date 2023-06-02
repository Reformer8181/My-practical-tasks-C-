using System.Runtime.ConstrainedExecution;

namespace Classes___Objects_As_Arguments
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Car car1 = new Car("Mustang", "red");
            Console.WriteLine(car1.color + " " + car1.model);

            ChangeColor(car1, "black");

            Car car2 = Copy(car1);
            Console.WriteLine(car2.color + " " + car2.model);

            Console.ReadKey();
        }

        public static void ChangeColor(Car car, String color)
        {
            car.color = color;
        }

        public static Car Copy(Car car)
        {
            return new Car(car.model,car.color);
        }
    }

    class Car
    {
        public String model;
        public String color;

        public Car(String model, String color)
        {
            this.model = model;
            this.color = color;
        }
    }
}