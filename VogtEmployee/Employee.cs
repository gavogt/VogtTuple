using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VogtEmployee
{
    class Employee
    {
        // Propfull
        private int empNumber;

        public int EmpNumber
        {
            get { return empNumber; }
            set { empNumber = value; }
        }

        private string empFirstName;

        // Propfull
        public string EmpFirstName
        {
            get { return empFirstName; }
            set { empFirstName = value; }
        }

        // Propfull
        private string empLastName;

        public string EmpLastName
        {
            get { return empLastName; }
            set { empLastName = value; }
        }
    }
}
