using System;

namespace Array_and_Loops_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int mulArr1;

            Console.Write("Enter a number: ");
            mulArr1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("- - - - MULTIPLICATION TABLE - - - -");

            for (int mulArr2 = 0; mulArr2 < 6; mulArr2++)
            {
              
                Console.WriteLine("\n\t {0} x {1} = {2}", mulArr1, mulArr2, mulArr1 * mulArr2);

            }

            Console.ReadKey();
        }
    }
}
