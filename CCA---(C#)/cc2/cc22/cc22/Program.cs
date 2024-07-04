using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cc22
{
    // Define the interface IStudent
    public interface IStudent
    {
        // Properties
        int StudentId { get; set; }
        string Name { get; set; }
        decimal Fees { get; set; }

        // Method
        void ShowDetails();
    }

    // Class for Day Scholar students
    public class Dayscholar : IStudent
    {
        // Implementing properties from IStudent interface
        public int StudentId { get; set; }
        public string Name { get; set; }
        public decimal Fees { get; set; }

        public Dayscholar(int studentId, string name, decimal fees) // Constructor
        {
            StudentId = studentId;
            Name = name;
            Fees = fees;
        }

        public void ShowDetails() // Implementing method from IStudent interface
        {
            Console.WriteLine($"Student ID: {StudentId}, Name: {Name}, Fees: {Fees}");
        }
    }

    public class Resident : IStudent // Class for Resident students
    {
        public int StudentId { get; set; } // Implementing properties from IStudent interface
        public string Name { get; set; }
        public decimal Fees { get; set; }

        // Constructor
        public Resident(int studentId, string name, decimal dayscholarFees)
        {
            StudentId = studentId;
            Name = name;
            Fees = dayscholarFees * 1.6m; // Resident fees are 60% more than Dayscholar fees
        }

        public void ShowDetails()  // Implementing method from IStudent interface
        {
            Console.WriteLine($"Student ID: {StudentId}, Name: {Name}, Fees: {Fees}");
        }
    }

    internal class Program // Test class to demonstrate the usage
    {
        static void Main(string[] args)
        {
            Dayscholar dayscholar = new Dayscholar(1, "Ayesha", 1000);  // Create a Dayscholar student
            Console.WriteLine("Details of Dayscholar:");
            dayscholar.ShowDetails();
            Console.WriteLine();
            Console.ReadLine();
            Resident resident = new Resident(2, "Bob", dayscholar.Fees); // Create a Resident student 
            Console.WriteLine("Details of Resident:");
            Console.ReadLine();
            resident.ShowDetails();
            Console.ReadLine();
        }
    }
}

