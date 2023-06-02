namespace Classes___Array_of_objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // garage array with size
            Car[] garage = new Car[3];

            Car car1 = new Car("Mustang");
            Car car2 = new Car("Corvette");
            Car car3 = new Car("Lambo");

            garage[0] = car1;
            garage[1] = car2;
            garage[2] = car3;

            Console.WriteLine(garage[0].model);
            Console.WriteLine(garage[1].model);
            Console.WriteLine(garage[2].model);
            Console.WriteLine();

            Console.WriteLine("Foreach loop:");
            foreach (Car car in garage)
            {
                Console.WriteLine(car.model);
            }
            Console.WriteLine();

            Console.WriteLine("New garage array");
            Car[] garageArray = { new Car("Mustang"),
                                  new Car("Corvette"),
                                  new Car("Lambo") };

            foreach (Car car in garageArray)
            {
                Console.WriteLine(car.model);
            }

            Console.ReadKey();
        }
    }

    class Car
    {
        public String model;

        public Car(String model)
        {
            this.model = model;
        }
    }
}