using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace DijkstrasAlgorithm.GraphAdt
{
    public class Graph<TV, TE> : IGraph<TV, TE>
    {
        private readonly IList<IVertex<TV, TE>> _vertices = new List<IVertex<TV, TE>>();
        public bool Empty => _vertices.Count == 0;
        public TV[] AllVertices => _vertices.Select(vertex => vertex.Data).ToArray();
        public TV[] Vertices(bool areProcessed)
        {
            return _vertices.Where(vertex => vertex.Processed == areProcessed).Select(v => v.Data).ToArray();
        }

        public TE[] Edges(TV vertexData)
        {
           return _vertices.Single(vertex => vertex.Data.Equals(vertexData)).Edges;
        }

        public void AddVertex(TV vertexData)
        {
            _vertices.Add(new Vertex<TV, TE>(){Data = vertexData, Processed = false});
        }

        public void RemoveVertex(TV vertexData)
        {
            _vertices.Remove(new Vertex<TV, TE>() {Data = vertexData, Processed = false});
        }

        public void AddEdge(TV origin, TV destination, TE edgeData, double weight)
        {
            var originExists = _vertices.SingleOrDefault(vertex => vertex.Data.Equals(origin));
            var destinationExists = _vertices.SingleOrDefault(vertex => vertex.Data.Equals(destination));

            if (originExists == null) AddVertex(origin);
            if (destinationExists == null) AddVertex(destination);

            var originVertex = _vertices.Single(vertex => vertex.Data.Equals(origin));
            var destinationVertex = _vertices.Single(vertex => vertex.Data.Equals(destination));

            originVertex.AddEdge(edgeData, destinationVertex, weight);
        }

        public void RemoveEdge(TV origin, TV destination, TE edgeData)
        {
            var originExists = _vertices.SingleOrDefault(vertex => vertex.Data.Equals(origin));
            var destinationExists = _vertices.SingleOrDefault(vertex => vertex.Data.Equals(destination));

            if (originExists == null) AddVertex(origin);
            if (destinationExists == null) AddVertex(destination);

            var originVertex = _vertices.Single(vertex => vertex.Data.Equals(origin));
            var destinationVertex = _vertices.Single(vertex => vertex.Data.Equals(destination));
            
            originVertex.RemoveEdge(edgeData, destinationVertex);
        }

        public TE Edge(TV origin, TV destination)
        {
            var originVertex = _vertices.Single(vertex => vertex.Data.Equals(origin)).Edges;
            var destinationVertex = _vertices.Single(vertex => vertex.Data.Equals(destination)).Edges;
            var edge = originVertex[0];

            foreach (var t in originVertex)
            {
                if (destinationVertex.Contains(t))
                {
                    edge = t;
                }
            }

            return edge;
        }

        public void SetVertexProcessedState(TV vertexData, bool processed)
        {
            _vertices.SingleOrDefault(vertex => vertex.Data.Equals(vertexData)).Processed = processed;
        }

        public bool GetVertexProcessedState(TV vertexData)
        {
            return _vertices.SingleOrDefault(vertex => vertex.Data.Equals(vertexData)).Processed;
        }
    }
}