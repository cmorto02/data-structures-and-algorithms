using System;
using System.Collections.Generic;
using System.Text;

namespace graph.classes
{
    class Graph<T>
    {
        public Dictionary<Vertex<T>, List<Edge<T>>> AdjacencyList { get; set; }
        private int _size = 0;
        public Graph()
        {
            AdjacencyList = new Dictionary<Vertex<T>, List<Edge<T>>>();
        }

        public Vertex<T> AddVertex(T value)
        {
            Vertex<T> vertex = new Vertex<T>(value);

            AdjacencyList.Add(vertex, new List<Edge<T>>());
            _size++;
            return vertex;
        }

        public void AddDirectedEdge(Vertex<T> a, Vertex<T> b, int weight)
        {
            AdjacencyList[a].Add(
                new Edge<T>
                {
                    Weight = weight,
                    Vertex = b
                }
        );
        }

        public void AddUndirectedEdge(Vertex<T> a, Vertex<T> b, int weight)
        {
            AddDirectedEdge(a, b, weight);
            AddDirectedEdge(b, a, weight);
        }

        public void Print()
        {
            foreach (var vertex in AdjacencyList)
            {
                Console.WriteLine($"|Vertex: {vertex.Key.Value} | -> ");
                foreach (var edge in vertex.Value)
                {
                    Console.WriteLine($" -- {edge.Vertex.Value}, {edge.Weight} -- ->");
                }
                Console.WriteLine("null");
            }
        }
        public void Count()
        {
            int count = 0;
            foreach (var vertex in AdjacencyList)
            {
                count++;
            }
            Console.WriteLine(count);
        }

        public List<Vertex<T>> GetVertices()
        {
            List<Vertex<T>> list = new List<Vertex<T>>();
            foreach (var vertex in AdjacencyList)
            {
                list.Add(vertex.Key);
            }
            return list;
        }

        //public List<Vertex<T>> GetNeighbors(Vertex<T> vertex)
        //{
        //    List<Vertex<T>> list = new List<Vertex<T>>();
        //    while ()
        //    {

        //    }
        //}
    }
}
