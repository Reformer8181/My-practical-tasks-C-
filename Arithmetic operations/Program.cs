// Оголошення простору імен
using System;

// Оголошення класу Program
class Program
{
    // Оголошення методу Main
    static void Main()
    {
        double num1, num2;

        // Використання блоку try-catch для обробки можливих винятків
        try
        {
            
            Console.Write("Enter the first number: ");
            // Зчитування першого числа з консолі та перетворення його на десяткове число
            num1 = double.Parse(Console.ReadLine().Trim());

            Console.Write("Enter the second number: ");
            // Зчитування другого числа з консолі та перетворення його на десяткове число
            num2 = double.Parse(Console.ReadLine().Trim());

            // Обчислення суми, різниці, добутку та частки двох чисел
            double sum = num1 + num2;
            double difference = num1 - num2;
            double multiplication = num1 * num2;
            double division = num1 / num2;

            // Виведення результатів на консоль за допомогою інтерполяції рядків
            Console.WriteLine($"The sum of {num1} and {num2} is {sum}");
            Console.WriteLine($"The difference of {num1} and {num2} is {difference}");
            Console.WriteLine($"The multiplication of {num1} and {num2} is {multiplication}");
            Console.WriteLine($"The division of {num1} and {num2} is {division}");
        }
        catch (FormatException) // Якщо введений рядок не є десятковим числом
        {
            Console.WriteLine("Invalid input format. Please enter a valid number.");
        }
        catch (DivideByZeroException) // Якщо друге число дорівнює нулю
        {
            Console.WriteLine("Cannot divide by zero. Please enter a non-zero number.");
        }
        catch (Exception ex) // Якщо сталася будь-яка інша помилка
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}
