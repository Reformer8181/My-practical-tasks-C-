using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task___Represent_Person_With_Properties
{
    internal class Person
    {
        private string firstName;
        private string lastName;
        private string occupation;
        private int age;

        // parameterized constructor
        public Person(
            string firstName,
            string lastName,
            string occupation,
            int age) 
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.occupation = occupation;
            this.age = age;
        }

        public void IntroduceMyself()
        {
            Console.WriteLine($"Hi! My name is {firstName} {lastName}. " +
                $"I'm {age} years old. I work as a {occupation}");
        }
    }
}
