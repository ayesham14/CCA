using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cc43
{
    class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string DOB { get; set; }  // Date of Birth as string
        public string DOJ { get; set; }  // Date of Joining as string
        public string City { get; set; }
    }

    class Program
    {
        static void Main()
        {
            List<Employee> empList = new List<Employee>();

            empList.Add(new Employee
            {
                EmployeeID = 1001,
                FirstName = "Malcolm",
                LastName = "Daruwalla",
                Title = "Manager",
                DOB = "16/11/1984",
                DOJ = "8/6/2011",
                City = "Mumbai"
            });

            empList.Add(new Employee
            {
                EmployeeID = 1002,
                FirstName = "Asdin",
                LastName = "Dhalla",
                Title = "AsstManager",
                DOB = "20/08/1984",
                DOJ = "7/7/2012",
                City = "Mumbai"
            });

            empList.Add(new Employee
            {
                EmployeeID = 1003,
                FirstName = "Madhavi",
                LastName = "Oza",
                Title = "Consultant",
                DOB = "14/11/1987",
                DOJ = "12/4/2015",
                City = "Pune"
            });

            empList.Add(new Employee
            {
                EmployeeID = 1004,
                FirstName = "Saba",
                LastName = "Shaikh",
                Title = "SE",
                DOB = "3/6/1990",
                DOJ = "2/2/2016",
                City = "Pune"
            });

            empList.Add(new Employee
            {
                EmployeeID = 1005,
                FirstName = "Nazia",
                LastName = "Shaikh",
                Title = "SE",
                DOB = "8/3/1991",
                DOJ = "2/2/2016",
                City = "Mumbai"
            });

            empList.Add(new Employee
            {
                EmployeeID = 1006,
                FirstName = "Amit",
                LastName = "Pathak",
                Title = "Consultant",
                DOB = "7/11/1989",
                DOJ = "8/8/2014",
                City = "Chennai"
            });

            empList.Add(new Employee
            {
                EmployeeID = 1007,
                FirstName = "Vijay",
                LastName = "Natrajan",
                Title = "Consultant",
                DOB = "2/12/1989",
                DOJ = "1/6/2015",
                City = "Mumbai"
            });

            empList.Add(new Employee
            {
                EmployeeID = 1008,
                FirstName = "Rahul",
                LastName = "Dubey",
                Title = "Associate",
                DOB = "11/11/1993",
                DOJ = "6/11/2014",
                City = "Chennai"
            });

            empList.Add(new Employee
            {
                EmployeeID = 1009,
                FirstName = "Suresh",
                LastName = "Mistry",
                Title = "Associate",
                DOB = "12/8/1992",
                DOJ = "3/12/2014",
                City = "Chennai"
            });

            empList.Add(new Employee
            {
                EmployeeID = 1010,
                FirstName = "Sumit",
                LastName = "Shah",
                Title = "Manager",
                DOB = "12/4/1991",
                DOJ = "2/1/2016",
                City = "Pune"
            });

            DisplayAllEmployees(empList);
            DisplayEmployeesNotInMumbai(empList);
            DisplayAsstManagers(empList);
            DisplayEmployeesWithLastNameStartingWithS(empList);

            Console.ReadKey();
        }

        //display all employees
        static void DisplayAllEmployees(List<Employee> employees)
        {
            Console.WriteLine("\nAll Employees:");
            foreach (var emp in employees)
            {
                Console.WriteLine($"{emp.EmployeeID} - {emp.FirstName} {emp.LastName}, {emp.Title}, DOB: {emp.DOB}, DOJ: {emp.DOJ}, City: {emp.City}");
            }
        }

        //employees whose location is not Mumbai
        static void DisplayEmployeesNotInMumbai(List<Employee> employees)
        {
            var result = employees.Where(emp => emp.City != "Mumbai").ToList();
            Console.WriteLine("\nEmployees Not in Mumbai:");
            foreach (var emp in result)
            {
                Console.WriteLine($"{emp.EmployeeID} - {emp.FirstName} {emp.LastName}, {emp.Title}, DOB: {emp.DOB}, DOJ: {emp.DOJ}, City: {emp.City}");
            }
        }

        //employees title is AsstManager
        static void DisplayAsstManagers(List<Employee> employees)
        {
            var result = employees.Where(emp => emp.Title == "AsstManager").ToList();
            Console.WriteLine("\nAsstManagers:");
            foreach (var emp in result)
            {
                Console.WriteLine($"{emp.EmployeeID} - {emp.FirstName} {emp.LastName}, {emp.Title}, DOB: {emp.DOB}, DOJ: {emp.DOJ}, City: {emp.City}");
            }
        }

        //employees Last Name starts with S
        static void DisplayEmployeesWithLastNameStartingWithS(List<Employee> employees)
        {
            var result = employees.Where(emp => emp.LastName.StartsWith("S")).ToList();
            Console.WriteLine("\nEmployees with Last Name starting with S:");
            foreach (var emp in result)
            {
                Console.WriteLine($"{emp.EmployeeID} - {emp.FirstName} {emp.LastName}, {emp.Title}, DOB: {emp.DOB}, DOJ: {emp.DOJ}, City: {emp.City}");
            }
        }
    }

}