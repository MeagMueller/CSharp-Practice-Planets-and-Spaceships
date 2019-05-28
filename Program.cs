using System;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>(){"Mercury", "Mars"};

            // 1. Add() Jupiter and Saturn at the end of the list.

            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            // planetList.ForEach(planet => Console.WriteLine(planet));

            // 2.Create another List that contains that last two planet of our solar system.

            List<string> morePlanets = new List<string>(){"Uranus", "Neptune"};

            // 3. Combine the two lists by using AddRange()

            planetList.AddRange(morePlanets);

            // planetList.ForEach(planet => Console.WriteLine(planet));

            // 4. Use Insert() to add Earth, and Venus in the correct order.


            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");

            // planetList.ForEach(planet => Console.WriteLine(planet));

            // 5. Use Add() again to add Pluto to the end of the list.

            planetList.Add("Pluto");

            planetList.ForEach(planet => Console.WriteLine(planet));

            Console.WriteLine();

            // 6. Now that all the planets are in the list, slice the list using GetRange() in order to extract the rocky planets into a new list called rockyPlanets. The rocky planets will remain in the original planets list.

            List<string> rockyPlanets = new List<string>();

            var rockyPlanetsList = planetList.GetRange(0, 4);

            rockyPlanets.AddRange(rockyPlanetsList);

            // rockyPlanets.ForEach(planet => Console.WriteLine(planet));

            // 7. Being good amateur astronomers, we know that Pluto is now a dwarf planet, so use the Remove() method to eliminate it from the end of planetList.

            planetList.Remove("Pluto");

            planetList.ForEach(planet => Console.WriteLine(planet));

        }
    }
}
