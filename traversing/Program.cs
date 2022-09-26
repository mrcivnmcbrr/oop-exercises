using System;

namespace traversing
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] planets = { "Mercury", "Venus", "Mars",
                "Earth", "Jupiter",  "Saturn", "Uranus", "Neptune", "Pluto" };

            

            foreach (string planet in planets)
            {
                Console.WriteLine(planet);
            }
        }
    }
}
