using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cc2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(test("abcd"));
            Console.WriteLine(test("a"));
            Console.WriteLine(test("xy"));
            Console.ReadLine();
        }
        public static string test(string str)
        {
            if (str.Length <= 1)
            {
                return str;
                Console.WriteLine("Invalid");
                Console.Read();
            }
            char firstChar = str[0];
            char lastChar = str[str.Length - 1];
            char[] charArray = str.ToCharArray();

            
            charArray[0] = lastChar; //swap first and last char
            charArray[str.Length - 1] = firstChar;

            return new string(charArray);
        }
    }
}
