namespace Task___How_Many_Vowels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write you text and press Enter: ");
            string userInput = Console.ReadLine();

            int vowelCount = CountVowels(userInput);
            Console.WriteLine("Number of vowels: " + vowelCount);
            Console.ReadLine();

        }

        static int CountVowels(string input)
        {
            int vowelCount = 0;
            char[] vowels = new char[]
            {
                'a', 'e', 'i', 'o', 'u'
            };
            for (int i = 0; i < input.Length; i++)
            {
                if (vowels.Contains(Char.ToLower(input[i])))
                {
                    vowelCount++;
                }
            }
            return vowelCount;
        }

    }
}