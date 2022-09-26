using System;

namespace Array_and_Loops_1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("\t\tEnter 10 different Cities around the World");
         
            string[] ArrCities = new string[10];

            
             
            for (int i = 0; i < ArrCities.Length; i++)
            {
                Console.Write("\n\tEnter a City: ");
                ArrCities[i] = Console.ReadLine();
            }

            Console.WriteLine();
            Console.WriteLine("\t-------------------------------");

            for (int i = 0; i < ArrCities.Length; i++)
            {
                Console.WriteLine("\n\tYou entered " + ArrCities[i]);
            }
               


            Console.ReadKey();
        }

    }
}   
