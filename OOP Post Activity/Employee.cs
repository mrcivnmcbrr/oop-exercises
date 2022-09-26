using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Post_Activity
{
    public class Employee
    {
        private string EmployeeName;
        private string PositionTitle;
        private string Company;

        public string name
        {
            get
            {
                return EmployeeName;
            }
            set
            {
                EmployeeName = value;
            }
        }

        public string position
        {
            get
            {
                return PositionTitle;
            }
            set
            {
               PositionTitle = value;
            }
        }

        public string company
        {
            get
            {
                return Company;
            }
            set
            {
               Company = value;
            }
        }

        public void EmployeeDetails()
        {
            Console.WriteLine("\n  ----- EMPLOYEE DETAILS -----");

            Console.WriteLine("\n  Employee Name: " + name);
            Console.WriteLine("\n  Position/Title: " + position);
            Console.WriteLine("\n  Company: " + company);
        }


    }
}
