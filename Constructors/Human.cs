using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Human
    {
        // member variable
        private string firstName;
        private string lastName;
        private string eyeColor;
        private int age;

        // parameterized constructor
        public Human(
            string firstName, 
            string lastName,
            string eyeColor,
            int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }
        public void IntroduceMyself()
        {
            Console.WriteLine("Hi, I'm {0} {1}. I'm {2} old. My eye color is {3}", firstName, lastName, age, eyeColor);
        }
    }
}
