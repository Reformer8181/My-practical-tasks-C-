namespace Task___Shuffle_The_Name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare a constant name
            const string fullName = "Eve Wilson";

            // Split the name by space into an array
            var names = fullName.Split(' ');

            // Get the first and last names from the array
            var firstName = names[0];
            var lastName = names[1];

            // Swap the first and last names using string interpolation
            var swappedName = $"{lastName} {firstName}";

            Console.WriteLine($"{fullName} -> {swappedName}");

        }
    }
}