using System;

namespace LabExerciseParameter
{
    public class NumberInput
    {
        public void EnterNumber(double num1, double num2)
        {
            Console.WriteLine("----INPUT NUMBER");

            Console.Write("\n\tEnter First Number: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("\n\tEnter Second Number: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n\n----OPERATIONS");
            double sum = num1 + num2;
            Console.WriteLine("\n\tAddition (+) = " + sum);

            double diff = num1 - num2;
            Console.WriteLine("\n\tSubtraction (-) = " + diff);

            double prod = num1 * num2;
            Console.WriteLine("\n\tMultiplication (*) = " + prod);

            double quotient = num1 / num2;
            Console.WriteLine("\n\tDivision (/) = " + Math.Round(quotient,2));

            double modulus = num1 % num2;
            Console.WriteLine("\n\tModulus (%) = " + modulus);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            NumberInput cabs = new NumberInput();
            cabs.EnterNumber(0, 0);
           
            Console.Read();
        }
    }
}
