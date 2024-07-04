using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cc21
{
    public class Passenger  // Passenger class with Name and Age properties
    {
        public string Name { get; set; }
        public int Age { get; set; }

        // Method to book tickets
        public void TicketBooking(int no_of_tickets)
        {
            if (no_of_tickets > 2)
            {
                throw new TicketBookingException("Cannot book more than 2 tickets.");
            }
            else
            {
                Console.WriteLine("Ticket Booked Successfully");
            }
        }
    }

    public class TicketBookingException : Exception  // Custom exception class for ticket booking
    {
        public TicketBookingException(string message) : base(message)
        {
        }
    }

    internal class Program // Test class to interact with Passenger class and handle user input
    {
        static void Main(string[] args)
        {
            Passenger passenger = new Passenger();

            try
            {
                Console.Write("Enter Passenger Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter Passenger Age: ");
                int age = Convert.ToInt32(Console.ReadLine());

                passenger.Name = name;
                passenger.Age = age;

                Console.Write("Enter number of tickets to book: ");
                int no_of_tickets = Convert.ToInt32(Console.ReadLine());

                passenger.TicketBooking(no_of_tickets);
                Console.ReadLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            catch (TicketBookingException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                Console.ReadLine();
            }
        }
    }
}

