using System;

namespace Array_and_Loops_4
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] names = {"Marc", "Ivan", "Malonhao", "Cabrera", "Michael", "Jay", "Sevilla", "Yvette", 
                "Michelle", "Michele", "Ivy", "Ingrid", "Michaela", "Ireen", "Melyzza"};

            Array.Sort(names);

            foreach (var list in names)
                Console.WriteLine("\n\t"+ list);
        }
    }
}
