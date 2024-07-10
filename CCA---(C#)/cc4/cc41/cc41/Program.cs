using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cc41
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"D:\GitHub\CCA\text.txt";

            string textToAdd = "This is the new line of text to append."; //text to add
            Console.WriteLine("Enter the text to append: ");
            Console.ReadLine();

            try
            {
                using (StreamWriter sw = File.AppendText(filePath)) //appending text to file
                {
                    Console.WriteLine(textToAdd);
                    Console.ReadLine();
                }

                Console.WriteLine("The given text has been appended to the file.");
                Console.ReadLine();
            }
            catch (Exception exep)
            {
                Console.WriteLine("An error occurred: " + exep.Message);
                Console.ReadLine();
            }

            Console.ReadKey(); // To keep the console window open
        
         }
    }
}
