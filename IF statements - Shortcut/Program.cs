namespace IF_statements___Shortcut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * condition ? first_expression : second_expression;
             * condition has to be either true or false
             * The condition operator is right - associative.
             * The expression a ? b : c ? d : e
             * is evaluated as a ? b : (c ? d : e),
             * not as (a ? b : c) ? d : e.
             * The condition operator cannot be overloaded.*/

            // in celcius
            int temperature = -5;
            string stateOfMatter;

            if (temperature < 0 ) 
            {
                stateOfMatter = "solid";
            }
            else
            {
                stateOfMatter = "liquid";
            }

            Console.WriteLine("State of mater is {0}", stateOfMatter);

            temperature += 30;

            // in short:
            stateOfMatter = temperature < 0 ? "solid" : "liquid";
            Console.WriteLine("State of mater is {0}", stateOfMatter);

            temperature += 100;

            // challenge - add the gas state of matter to the options
            stateOfMatter = temperature > 100 ? "gas" : temperature < 0 ? "solid" : "liquid";
            Console.WriteLine("State of mater is {0}", stateOfMatter);

            Console.ReadKey();
        }
    }
}