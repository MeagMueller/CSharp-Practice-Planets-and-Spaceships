using System;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>(){"Mercury", "Mars"};

            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            // planetList.ForEach(planet => Console.WriteLine(planet));

            List<string> morePlanets = new List<string>(){"Uranus", "Neptune"};

            planetList.AddRange(morePlanets);

            planetList.ForEach(planet => Console.WriteLine(planet));
        }
    }
}
