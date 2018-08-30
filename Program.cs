using System;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };
            List<string> planetListNew = new List<string>() { "Uranus", "Neptune" };

            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            planetList.AddRange(planetListNew);

            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");

            planetList.Add("Pluto");

            List<string> rockyPlanets = planetList.GetRange(0, 4);

            planetList.Remove("Pluto");

            foreach (string itemTaco in planetList)
            {
                Console.WriteLine(itemTaco);

            }

            //Create another list containing dictionaries. Each dictionary will hold the name of a spacecraft that we have launched, and the name of the planet that it has visited. If it visited more than one planet, just pick one.
            List<Dictionary<string, string>> probes = new List<Dictionary<string, string>>();

            Dictionary<string, string> viking = new Dictionary<string, string>() {
                { "Mars", "Viking" }
            };
            Dictionary<string, string> pioneer = new Dictionary<string, string>(){
                {"Venus", "Pioneer Venus Multiprobe"}
            };

            Dictionary<string, string> voyager1 = new Dictionary<string, string>(){
                {"Saturn", "Voyager 1"}
            };

            Dictionary<string, string> voyager2 = new Dictionary<string, string>(){
                {"Uranus", "Voyager 2"}
            };

            probes.Add(viking);
            probes.Add(pioneer);
            probes.Add(voyager1);
            probes.Add(voyager2);

            //Iterate over your list of planets from above, and inside that loop, iterate over the list of dictionaries. Write to the console, for each planet, which satellites have visited which planet.
            foreach (string itemPlanet in planetList)
            {
                List<string> probesVisited = new List<string>();

                foreach (Dictionary<string, string> itemProbe in probes)
                {
                    if (itemProbe.ContainsKey(itemPlanet))
                    {
                        probesVisited.Add(itemProbe[itemPlanet]);
                    }

                }
                if (probesVisited.Count != 0)
                {
                System.Console.WriteLine($"{itemPlanet} has been visited by: {String.Join(", ", probesVisited)}");
                }
                // else 
                // {
                //     System.Console.WriteLine($"{itemPlanet} hasn't been visited by ANYONE");
                // }
                
            }
        }
    }
}
