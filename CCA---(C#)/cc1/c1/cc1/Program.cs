using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cc1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine(test("Python", 1));  //Pyton
            Console.WriteLine(test("Python", 0));  // ython
            Console.WriteLine(test("Python", 4));  //Pytho
            Console.ReadLine();                   
        }

        public static string test(string str, int n)
        {
            return str.Remove(n, 1); 
        }
    }
}
