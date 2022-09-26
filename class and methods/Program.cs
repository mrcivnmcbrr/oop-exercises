using System;

namespace class_and_methods //namespace
{
    //Payroll System
    //Employee Name
    //Employee ID
    //Position

    public class EmployeeDetails //class
    {
        //Properties
        public string EmployeeName;
        public string EmployeeID;
        public string Position;

        //Methods
        public void EmployeeN()
        {

            Console.Write("Enter Employee Name: ");
            EmployeeName = Console.ReadLine();

          
        }
        public void EmployeeIdentity()
        {

            Console.Write("Enter Employee ID: ");
            EmployeeID = Console.ReadLine();

        }

        public void EmployeePosition()
        {

            Console.Write("Enter Employee ID: ");
            Position = Console.ReadLine();

        }


    }



    public class ComputeSalary
    {
        //properties
        public int Rate;
        public double Hours;

        //methods
        public void PrintSalary()
        {
            double computedSalary;

            EmployeeDetails emp = new EmployeeDetails();

            Console.WriteLine("Enter Rate: ");
            Rate = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter Hours: ");
            Hours = Double.Parse(Console.ReadLine());


            computedSalary = Rate * Hours;

            emp.EmployeeIdentity();

            Console.WriteLine("Employee ID is " + emp.EmployeeID);
            Console.WriteLine("Your Computed Salary is {0}", computedSalary);


        }
    }



    class Program //mainprogram
    {

        static void Main(string[] args)
        {
            
            EmployeeDetails nard = new EmployeeDetails();  //instantiate
            ComputeSalary salary = new ComputeSalary();

            nard.EmployeeN();

            salary.PrintSalary();

            Console.Read();

        }
    }
}
