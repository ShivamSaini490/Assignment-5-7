using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main()
    {
        bool validInput = false;
        int numerator = 0;
        int denominator = 0;
        int result = 0;

        while (!validInput)
        {
            try
            {
                Console.Write("Enter the numerator: ");
                numerator = int.Parse(Console.ReadLine());

                Console.Write("Enter the denominator: ");
                denominator = int.Parse(Console.ReadLine());

                if (denominator == 0)
                {
                    throw new DivideByZeroException("Cannot divide by zero. Please enter a non-zero denominator.");
                }

                result = DivideNumbers(numerator, denominator);
                Console.WriteLine("Result of division: " + result);

                validInput = true; 
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter valid integers.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        Console.WriteLine("Program continues...");    }

    static int DivideNumbers(int numerator, int denominator)
    {
        return numerator / denominator;
    }
}
