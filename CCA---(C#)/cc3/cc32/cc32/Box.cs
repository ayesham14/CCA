using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cc32
{
    class Box
    {
        
        public double Length { get; set; } // Properties land b
        public double Breadth { get; set; }

        public Box(double length, double breadth)
        // Constructor
        {
            Length = length;
            Breadth = breadth;
        }

        // Method to add two Box objects and store the result in a third Box object
        public static Box AddBoxes(Box box1, Box box2)
        {
            double sumLength = box1.Length + box2.Length;
            double sumBreadth = box1.Breadth + box2.Breadth;

            return new Box(sumLength, sumBreadth);
        }

        // Method to display the details of a Box object
        public void DisplayBoxDetails()
        {
            Console.WriteLine($"Length: {Length}");
            Console.WriteLine($"Breadth: {Breadth}");
            Console.WriteLine();
        }
    }

    class Test
    {
        static void Main()
        {
            Box box1 = new Box(3.5, 2.5); // Creating the two Box objects
            Box box2 = new Box(2.0, 3.5);

            
            Box box3 = Box.AddBoxes(box1, box2); // Adding the two Box objects and store the result in a third Box object


            Console.WriteLine("Details of the Third Box:");  // Displaying details of the third Box object
            box3.DisplayBoxDetails();

            Console.ReadLine(); 

        }

    }
}
