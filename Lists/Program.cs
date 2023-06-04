namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // List = data structure that represents a list of objects that can be accessed by index.
            //          Similar to array, but can dynamically increase/decrease in size
            //          using System.Collections.Generic;

            List<String> food = new List<String>();

            food.Add("fries");
            food.Add("pizza");
            food.Add("hamburger");
            food.Add("hotdog");
            food.Add("fries");

            //food.Remove("fries");
            //food.Insert(0, "sushi");
            //Console.WriteLine("Food list count: " + food.Count);
            //Console.WriteLine("Index of 'pizza': " + food.IndexOf("pizza"));
            //Console.WriteLine("Index of 'hamburger': " + food.IndexOf("hamburger"));
            //Console.WriteLine("Last index of list is: " + food.LastIndexOf("fries"));
            //Console.WriteLine("Foods list is contains 'pizza':" + food.Contains("pizza"));
            //food.Sort();
            //food.Reverse();
            //food.Clear();
            String[] foodArray = food.ToArray();

            foreach (String item in foodArray)
            {
                Console.WriteLine(item);
            }


            Console.ReadKey();
        }
    }
}