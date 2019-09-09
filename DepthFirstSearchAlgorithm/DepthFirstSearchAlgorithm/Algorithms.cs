using System;
using System.Collections.Generic;
using System.Text;

namespace DepthFirstSearchAlgorithm
{
    public class Algorithms
    {
        public HashSet<char> DFS(Graph graph, char start)
        {
            var visited = new HashSet<char>();

            var stack = new Stack<char>();
            stack.Push(start);

            while (stack.Count > 0)
            {
                var vertex = stack.Pop();
                if (visited.Contains(vertex))
                    continue;

                visited.Add(vertex);

                foreach (var neighbor in graph.AdjacencyList[vertex])
                    if (!visited.Contains(neighbor))
                        stack.Push(neighbor);
            }
            return visited;
          
        }
    }
}
