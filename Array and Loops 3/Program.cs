using Microsoft.VisualBasic;
using System;

namespace Array_and_Loops_3
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphaBet = { 'A', 'B', 'C', 'D' };
            string[] nbaPlayer = { "Kobe", "Jordan", "James", "Rose" };

            foreach(char a in alphaBet)
            {
                Console.WriteLine("\t"+ a);
            }

            foreach(string b in nbaPlayer)
            {
                Console.WriteLine("\n\t"+ b);
            }

            Console.ReadKey();

        }
    }
}
