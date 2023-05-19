namespace Number_Guessing_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random randomNumber = new Random();
            bool playAgain = true;
            int minRandomeNumber = 1;
            int maxRandomeNumber = 100;
            int guessNumber;
            int guesses;
            int userNumber;
            String response;

            while (playAgain)
            {

                guessNumber = randomNumber.Next(minRandomeNumber, maxRandomeNumber + 1);
                userNumber = 0;
                guesses = 0;
                response = "";

                while (guessNumber != userNumber)
                {
                    Console.WriteLine("Guess a number between 1 - 100 : ");
                    userNumber = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Guess: " + userNumber);

                    if (userNumber < guessNumber)
                    {
                        Console.WriteLine(userNumber + " is to low!");
                    }
                    else if (userNumber > guessNumber)
                    {
                        Console.WriteLine(userNumber + " is to high!");
                    }
                    guesses++;
                }
                Console.WriteLine("Number: " + userNumber);
                Console.WriteLine("YOU WIN!");
                Console.WriteLine("Guesses: " + guesses);
                Console.WriteLine("Would you like to play again (Y/N): ");
                response = Console.ReadLine();
                response = response.ToUpper();

                if (response == "Y")
                {
                    playAgain = true;
                }
                else if (response == "N")
                {
                    playAgain = false;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Thanks for playing! ... I guess");
            Console.ReadLine();

        }
    }
}