using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DijkstrasAlgorithm.GraphAdt;
using DijkstrasAlgorithm.Map;

namespace DijkstrasAlgorithm.Pathfinding
{
    class Dijkstra
    {
        private readonly Graph<City, Highway> _graph;
        private readonly double[] _distances;
        private readonly int[] _predecessors;
        private City[] _cities;

        public Dijkstra(Graph<City, Highway> graph)
        {
            _graph = graph;
            var numberOfVertexes = graph.AllVertices.Length;

            _distances = new double[numberOfVertexes];
            _predecessors = new int[numberOfVertexes];

            Array.Fill(_distances, -1);
            Array.Fill(_predecessors, -1);
        }

        public string ShortestPath(string originName, string destinationName)
        {
            var pathTraveled = "";

            _cities = _graph.AllVertices;
            var origin = _cities.Single(city => city.Name.Equals(originName));
            var currentCity = origin;
            var highways = _graph.Edges(currentCity);

            pathTraveled = originName + " -> " + destinationName;

            return pathTraveled;
        }
    }
}
