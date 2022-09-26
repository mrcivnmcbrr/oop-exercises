using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp2
{
    class SWITCH
    {
        static void Main(string[] args)
        {
            //Switch
            //Evaluate exp (ranging = 95 to 97) If else
            //Evaluate the corresponding description based on the inputted character
            //R = Red, B= Blue, Y= Yellow
           
            char color;

            choice:
            Console.Write("Enter Color Code (R,B,Y only): ");
            color = char.Parse(Console.ReadLine().ToUpper());

            switch(color)
            {
                case 'R':
                    Console.WriteLine("\nRed");
                    break;
                case 'B':
                    Console.WriteLine("\nBlue");
                    break;
                case 'Y':
                    Console.WriteLine("\nYellow");
                    break;
                default:
                    Console.WriteLine("\nUndefined color");
                    goto choice;
                    
            }


            
            Console.WriteLine("\nPlease enter any key to close the program...");
            Console.ReadKey();
        }
    }
}
