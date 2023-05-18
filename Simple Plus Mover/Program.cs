namespace Simple_Plus_Mover
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int position = 0;
            ConsoleKeyInfo keyInfo;
            do
            {
                Console.Clear();
                for (int i = 0; i < position; i++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("+");
                keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.LeftArrow) 
                {
                    position--;
                }
                else if (keyInfo.Key == ConsoleKey.RightArrow)
                {
                    position++;
                }
            }while (keyInfo.Key != ConsoleKey.Escape);
        }
    }
}