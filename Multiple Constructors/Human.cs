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

        // default constructor
        public Human()
        {
            Console.WriteLine("Constructor caled. Object created");
        }

        // parameterized constructor firstName
        public Human(string firstName)
        {
            this.firstName = firstName;
        }

        // parameterized constructor firstName & lastName
        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        // parameterized constructor firstName, lastName & eyeColor
        public Human(string firstName, string lastName, string eyeColor)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
        }

        // parameterized constructor firstName, lastName & age
        public Human(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        // parameterized constructor with age
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
            if (firstName != null && lastName != null && eyeColor != null && age != 0)
            {
                Console.WriteLine("Hi, I'm {0} {1}. I'm {2} old. My eye color is {3}", firstName, lastName, age, eyeColor);
            }
            else if (firstName != null && lastName != null && eyeColor != null)
            {
                Console.WriteLine("Hi, I'm {0} {1}. My eye color is {2}", firstName, lastName, eyeColor);
            }
            else if (firstName != null && lastName != null && age != 0)
            {
                Console.WriteLine("Hi, I'm {0} {1}. I'm {2} old.", firstName, lastName, age);
            }
            else if (firstName != null && lastName != null)
            {
                Console.WriteLine("Hi, I'm {0} {1}.", firstName, lastName);
            }
            else if (firstName != null)
            {
                Console.WriteLine("Hi, I'm {0}", firstName);
            }
        }
    }
}