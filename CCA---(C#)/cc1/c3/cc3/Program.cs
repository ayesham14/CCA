using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cc3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;

            Console.Write("Enter the First number: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            num2 = int.Parse(Console.ReadLine());

            Console.Write("Enter the third number: ");
            num3 = int.Parse(Console.ReadLine());

            
            int LargetNumb = num1;

            if (num3 > LargetNumb && num3 > num2)
            {
                LargetNumb = num2;
            }
            if (num3 > LargetNumb && num3 > num2)
            {
                LargetNumb = num3;
            }

            Console.WriteLine($"The largest number among {num1}, {num2}, and {num3} is: {LargetNumb}");
            Console.ReadLine();
        }

    }
}


  

