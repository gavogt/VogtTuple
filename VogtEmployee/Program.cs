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
            bool quit = false;

            DisplayHeader();

            Employee emp = new Employee();

            var listOfEmployees = new List<(int empNo, string empFName, string empLName)>();

            while (quit == false)
            {
                Console.WriteLine("What is the number of the employee?");
                emp.EmpNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("What is the first name of the employee?");
                emp.EmpFirstName = Console.ReadLine();

                Console.WriteLine("What is the last name of the employee?");
                emp.EmpLastName = Console.ReadLine();

                listOfEmployees.Add((emp.EmpNumber, emp.EmpFirstName, emp.EmpLastName));

                Console.WriteLine("Would you like to add another employee?");
                Console.WriteLine("1. Yes");
                Console.WriteLine("2. No");

                choice = Convert.ToInt32(Console.ReadLine());

                if (choice > 2 || choice < 1)
                {
                    DisplayError();
                }

                if (choice == 2)
                {
                    quit = true;
                }
            }

            DisplayInformation(listOfEmployees);

        }

        #region DisplayEmpInformation
        /// <summary>
        /// Display information on the employee list
        /// </summary>
        /// <param name="list">Add in a tuple of employee number, employee first name and employee string</param>
        public static void DisplayInformation(List<(int empNo, string empFName, string empLName)> list)
        {
            foreach (var employee in list)
            {
                Console.WriteLine($"Employee number is: {employee.empNo}");
                Console.WriteLine($"Employee name is: {employee.empFName} {employee.empLName}");
            }
        }
        #endregion

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

        #region DisplayError
        /// <summary>
        /// Display an error for the selected choice in dark red
        /// </summary>
        public static void DisplayError()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;

            Console.WriteLine("Error!");

            Console.ResetColor();
        }
        #endregion

    }
}
