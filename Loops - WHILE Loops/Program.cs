﻿namespace Loops___WHILE_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            string enteredText = "";

            while (enteredText.Equals(""))
            {
                Console.WriteLine("Please press enter to increase amount by one and anything else" +
                   "enter if yot want to finish counting" );
                enteredText = Console.ReadLine();

                counter++;
                Console.WriteLine("Current people count is {0}", counter);
            }
            Console.WriteLine("{0} people are inside the bus", counter);
            Console.WriteLine("Press enter to close the program.");
            Console.Read();
        }
    }
}