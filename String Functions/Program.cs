﻿namespace String_Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string randString = "This is a string";
            Console.WriteLine("String Lenght : {0}", 
                randString.Length);
            Console.WriteLine("String Contains is : {0}", 
                randString.Contains("is"));
            Console.WriteLine("Index of 'is' : {0}", 
                randString.IndexOf("is"));
            Console.WriteLine("Remove string : {0}", 
                randString.Remove(10, 6));
            Console.WriteLine("Insert string : {0}", 
                randString.Insert(10, "short "));
            Console.WriteLine("Replace string : {0}", 
                randString.Replace("string", "sentance"));
            Console.WriteLine("Compare A to B : {0}",
                String.Compare("A", "B",
                StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("-------------------");

            Console.WriteLine("A = a : {0}",
                String.Equals("A", "a",
                StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("Pad Left : {0}",
                randString.PadLeft(20, '.'));
            Console.WriteLine("Pad Right : {0}",
                randString.PadRight(20, '.'));
            Console.WriteLine("Trim : {0}",
                randString.Trim());
            Console.WriteLine("Uppercase : {0}",
                randString.ToUpper());
            Console.WriteLine("Lowercase : {0}",
                randString.ToLower());
            string newString =
                String.Format("{0} saw a {1} {2} in the {3}",
                "Paul", "rabbit", "eating", "field");
            Console.Write(newString + "\n");
            Console.WriteLine(@"Exactly what I typed\n");
        }
    }
}