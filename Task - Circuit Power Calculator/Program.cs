namespace Task___Circuit_Power_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tCircuit Power Calculator");
            Console.WriteLine("The calculator takes voltage and current as inputs" +
                " and returns the calculated power.");

            Console.Write("Please write voltage here and press Enter: ");
            int intVoltage = GetVoltageInput();

            Console.Write("Please write current here and press Enter: ");
            int intCurrent = GetCurrentInput();

            int power = intVoltage * intCurrent;
            Console.WriteLine("Power = " + power);
            Console.ReadLine();
        }

        static int GetVoltageInput()
        {
            int voltage;
            Console.Write("Please enter the voltage: ");
            string input = Console.ReadLine();
            while (!int.TryParse(input, out voltage))
            {
                Console.WriteLine("Invalid input. Please enter a valid voltage value.");
                input = Console.ReadLine();
            }
            return voltage;
        }

        static int GetCurrentInput()
        {
            int current;
            Console.Write("Please enter the current: ");
            string input = Console.ReadLine();
            while (!int.TryParse(input, out current))
            {
                Console.WriteLine("Invalid input. Please enter a valid current value.");
                input = Console.ReadLine();
            }
            return current;
        }

    }
}