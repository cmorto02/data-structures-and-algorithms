using graph.classes;
using System;

namespace graph
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Graph<int> graph = new Graph<int>();

            var a = graph.AddVertex(7);
            var b = graph.AddVertex(8);
            var c = graph.AddVertex(9);

            graph.AddUndirectedEdge(a, b, 4);
            graph.AddUndirectedEdge(b, c, 5);
            graph.AddUndirectedEdge(a, c, 6);

            graph.Count();

            var vertexList = graph.GetVertices();

            foreach (var item in vertexList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
