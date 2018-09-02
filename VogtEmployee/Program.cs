using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VogtEmployee
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = default;

            DisplayHeader();

            Employee emp = new Employee();

            while(choice != 1)
                Console.WriteLine("What is the number of the employee?");
                emp.EmpNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("What is the first name of the employee?");
                emp.EmpFirstName = Console.ReadLine();

                Console.WriteLine("What is the last name of the employee?");
                emp.EmpLastName = Console.ReadLine();

            var listOfEmployees = new List<(int empNo, string empFName, string empLName)>();

            listOfEmployees.Add((emp.EmpNumber, emp.EmpFirstName, emp.EmpLastName));

            foreach (var employee in listOfEmployees)
            {
                Console.WriteLine($"Employee number is: {employee.empNo}");
                Console.WriteLine($"Employee name is: {employee.empFName} {employee.empLName}");
            }

        }

        #region DisplayHeader
        /// <summary>
        /// Displays a welcome screen to the user
        /// </summary>
        public static void DisplayHeader()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            Console.WriteLine("Welcome to the Employee List program!\n");

            Console.ResetColor();

        }
        #endregion
    }
}
