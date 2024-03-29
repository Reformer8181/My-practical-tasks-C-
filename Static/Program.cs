﻿using System.ComponentModel.DataAnnotations;

namespace Static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // static = modifier to declare a static member, which belongs to the class itself
            //          rather than to any specific object

            Car car1 = new Car("Mustang");
            Car car2 = new Car("Corvette");
            Car car3 = new Car("Lambo");

            Console.WriteLine(Car.numberOfCars);

            Car.StartRace();

            Console.ReadKey();
        }
    }
}