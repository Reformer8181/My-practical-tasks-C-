﻿namespace Loops___DO_WHILE_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lenghtOfText = 0;
            string wholeText = "";
            do
            {
                Console.WriteLine("Please enter the name of a friend");
                string nameOfAFriend = Console.ReadLine();
                int currentLenght = nameOfAFriend.Length;
                lenghtOfText += currentLenght;
                wholeText += nameOfAFriend;

            }while (lenghtOfText < 20);
            Console.WriteLine("Thanks, thats was enough! " + wholeText);
            Console.ReadKey();
        }
    }
}