using System;
using System.IO;
using System.Reflection.Metadata.Ecma335;
using DijkstrasAlgorithm.GraphAdt;
using DijkstrasAlgorithm.Map;
using DijkstrasAlgorithm.Pathfinding;
using static System.Console;

namespace DijkstrasAlgorithm
{
    public class Program
    {
        private static Graph<City, Highway> GraphFactory(string filename)
        {
            var graph = new Graph<City, Highway>();
            var lines = File.ReadAllLines(filename);

            foreach (var line in lines)
            {
                var lineData = line.Split(',');
                graph.AddEdge(new City {Name = lineData[0]},
                    new City { Name = lineData[1]},
                    new Highway
                    {
                        Name = lineData[2],
                        Distance = Convert.ToDouble(lineData[3]),
                        AverageSpeedLimit = Convert.ToDouble(lineData[4])
                    },
                    Convert.ToDouble(lineData[4]));
            }


            return graph;
        }

        public static void Main(string[] args)
        {
            var graph = GraphFactory(@"Map\MapData.txt");

            var origin = "Portland";
            var destination = "Salem";

            var dijkstra = new Dijkstra(graph);
            var shortestPath = dijkstra.ShortestPath(origin, destination);

            Console.WriteLine(shortestPath);

            WriteLine("Program ending press ENTER to exit the program...");
            ReadLine();
        }
    }
}
