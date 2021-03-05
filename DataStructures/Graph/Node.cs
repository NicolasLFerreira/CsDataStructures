using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDataStructures.DataStructures.Graph
{
    class Node<T>
    {
        public T Data { get; set; }
        public bool Visited { get; private set; }
        public List<Node<T>> Neighbors { get; set; }

        public Node(T data)
        {
            Data = data;
            Visited = false;
        }

        public Node(T data, List<Node<T>> neighbors)
        {
            Data = data;
            Neighbors = neighbors;
            Visited = false;
        }

        public void AddNeighbor(Node<T> vertex)
        {
            Neighbors.Add(vertex);
        }

        public void AddNeighbor(List<Node<T>> vertices)
        {
            Neighbors.AddRange(vertices);
        }

        public void RemoveNeighbor(Node<T> vertex)
        {
            if (Neighbors.Contains(vertex)) Neighbors.Remove(vertex);
            else throw new Exception();
        }

        public void Visit()
        {
            Visited = true;
        }
    }
}