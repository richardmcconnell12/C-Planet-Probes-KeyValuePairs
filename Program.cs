using System;
using System.Collections.Generic;
using System.Linq;

namespace planets_and_probes
{
    class Program
    {
        static void Main(string[] args)
        {
            var planetList = new List<string>() { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune" };

            var probePlanets = new List<KeyValuePair<string, string>>();
            // Add some planet/probe combinations to the list

            probePlanets.Add(new KeyValuePair<string, string>("Viking 1", "Venus"));
            probePlanets.Add(new KeyValuePair<string, string>("Mariner 1", "Earth"));
            probePlanets.Add(new KeyValuePair<string, string>("Voyager 1", "Saturn"));
            probePlanets.Add(new KeyValuePair<string, string>("Voyager 1", "Jupiter"));
            probePlanets.Add(new KeyValuePair<string, string>("Mariner 1", "Mercury"));
            probePlanets.Add(new KeyValuePair<string, string>("Vanera 1", "Earth"));

            // Iterate over the planets

            foreach (string planet in planetList)
            {
                // List to store probes that visited the planet
                var matchingProbes = new List<string>();

                // Iterate probeDestinations
                foreach (KeyValuePair<string, string> probes in probePlanets)
                {
                    string probe = probes.Key;
                    string destination = probes.Value;

                    if (destination == planet)
                    {
                        matchingProbes.Add(probe);
                    }
                }

                bool anyProbes = !matchingProbes.Any();

                if (anyProbes)
                {
                    Console.WriteLine($"{planet}: No probes... yet");
                }
                else
                {
                    Console.WriteLine($"{planet}: {String.Join(", ", matchingProbes)}; take me to your leader!");
                }
            }
        }
    }
}
