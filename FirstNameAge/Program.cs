using System;
using Parameter;

namespace FirstNameAge
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentDetails cabs = new StudentDetails();

            cabs.FirstName("Marc Ivan");

            Console.WriteLine("Your Age " + cabs.Age(18));
            Console.WriteLine("Your First Name " + cabs.FirstName("Marc Ivan"));

            Console.Read();
        }
    }
}
