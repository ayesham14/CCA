using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cc31
{
    public class cricket
    {
    public void Pointscalculation(int no_of_matches)
        {
            int[] scores = new int[no_of_matches];
            int totalSum = 0;

            for (int i = 0; i < no_of_matches; i++)   // each match input score
            {
                Console.Write($"Enter score for match {i + 1}: ");
                scores[i] = Convert.ToInt32(Console.ReadLine());
                totalSum += scores[i];
            }

            double average = (double)totalSum / no_of_matches; // Calculating average

           
            Console.WriteLine($"Total Sum of Scores: {totalSum}");  //results
            Console.WriteLine($"Average Score: {average}");
        }
    }

    class Program
    {
        static void Main()
        {
            cricket c = new cricket(); // Creating an instance of Cricket class
            Console.Write("Enter number of matches: "); // Input number of matches
            int no_of_matches = Convert.ToInt32(Console.ReadLine());

            // Call Pointscalculation method
            c.Pointscalculation(no_of_matches);
            Console.ReadLine();
        }
    }
}
