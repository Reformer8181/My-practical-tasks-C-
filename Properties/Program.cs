namespace Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box(3,4,5);
            Console.WriteLine("Box s Width is " + box.Width);
            box.Width = 10;
            Console.WriteLine("Box s Width is " + box.Width);
            Console.WriteLine("Box s Volume is " + box.Volume);
            box.DisplayInfo();

            Console.ReadLine();
        }
    }
}