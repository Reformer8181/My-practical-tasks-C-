namespace Getters___Setters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // getters & setters = add security to fields by encapsulation
            //                      They're accessors found within properties

            //  properties = combine aspects of both fields and methods (share name with a field)
            //  get accessor = used to return the property value
            //  get accessor = used to assign a new value
            //  value keyword = defines the value being assigned by the set (parameter)

            Car car = new Car(400);

            car.Speed = 499;

            Console.WriteLine(car.Speed);

            Console.ReadKey();

        }
    }
    class Car
    {
        private int speed;

        public Car(int speed)
        {
            Speed = speed;
        }

        public int Speed
        {
            get
            {
                // Return the value of the speed field
                return speed;
            }
            set
            {
                // If the value being assigned is greater than 500
                if (value > 500)
                {
                    // Set the speed field to 500
                    speed = 500;
                }
                else
                {
                    // Otherwise, set the speed field to the value being assigned
                    speed = value;
                }
            }
        }
    }
}