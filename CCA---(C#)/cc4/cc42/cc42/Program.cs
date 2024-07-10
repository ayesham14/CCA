using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cc42
{
    delegate int Calculate(int x, int y);
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Calculator Program");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("Enter your choice (1/2/3):");

            char choice = Console.ReadKey().KeyChar;
            Console.WriteLine();

            Calculate operation = null;

            switch (choice)
            {
                case '1':
                    operation = Add;
                    break;
                case '2':
                    operation = Subtract;
                    break;
                case '3':
                    operation = Multiply;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter either 1, 2, or 3.");
                    return;
            }

            Console.WriteLine("Enter the first integer:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second integer:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            
            int result = operation(num1, num2); 

            Console.WriteLine($"Result of the operation: {result}");
            Console.ReadLine();
        }

        // Methods for calculator operations
        static int Add(int x, int y)
        {
            return x + y;
        }

        static int Subtract(int x, int y)
        {
            return x - y;
        }

        static int Multiply(int x, int y)
        {
            return x * y;
        }

    }

}



       
