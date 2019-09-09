using System;
using System.Collections.Generic;

namespace DepthFirstSearchAlgorithm
{
    public class Graph
    {
        public Graph(char[] vertices, Tuple<char, char>[] edges)
        {
            foreach (var vertex in vertices)
            {
                AddVertix(vertex);
            }

            foreach (var edge in edges)
                AddEdge(edge);
        }
        public Dictionary<char , HashSet<char>> AdjacencyList { get; } = new Dictionary<char, HashSet<char>>();

        public void AddVertix(char vertix)
        {
            AdjacencyList[vertix] = new HashSet<char>();
        }
        public void AddEdge(Tuple<char, char> edge)
        {
            if (AdjacencyList.ContainsKey(edge.Item1) && AdjacencyList.ContainsKey(edge.Item2))
            {
                AdjacencyList[edge.Item1].Add(edge.Item2);
                AdjacencyList[edge.Item2].Add(edge.Item1);
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

            var vertices = new[] { 'A', 'B', 'C', 'D', 'E' };
            var edges = new[] {Tuple.Create('A', 'B'), Tuple.Create('A','C'),
                Tuple.Create('B','D'), Tuple.Create('C', 'E'),
                 Tuple.Create('D','A'), Tuple.Create('E', 'D')};
            var algorithms = new Algorithms();
            var graph = new Graph(vertices, edges);
            Console.WriteLine(string.Join(",", algorithms.DFS(graph, 'A')));
            //    List<String> names = new List<String>();
            //    names.Add("Bruce");
            //    names.Add("Alfred");
            //    names.Add("Tim");
            //    names.Add("Richard");

            //    // Display the contents of the list using the Print method.
            //    //names.ForEach(Print);

            //    // The following demonstrates the anonymous method feature of C#
            //    // to display the contents of the list to the console.
            //    names.ForEach((name) =>  { Console.WriteLine(name); });
            //}
            //private static void Print(string s)
            //{
            //    Console.WriteLine(s);
            //}
        }
    }
}
