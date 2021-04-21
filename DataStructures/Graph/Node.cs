using System;
using System.Collections.Generic;

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
            Neighbors = new List<Node<T>>();
        }

        public Node(T data, List<Node<T>> neighbors)
        {
            Data = data;
            Neighbors = neighbors;
            Visited = false;
        }

        public void AddNeighbor(Node<T> node)
        {
            if (!Neighbors.Contains(node)) Neighbors.Add(node);
            if (!node.Neighbors.Contains(this)) node.Neighbors.Add(this);
        }

        public void AddNeighbor(List<Node<T>> nodes)
        {
            Neighbors.AddRange(nodes);
        }

        public void RemoveNeighbor(Node<T> node)
        {
            if (Neighbors.Contains(node)) Neighbors.Remove(node);
            else throw new Exception();
        }

        public void Visit()
        {
            Visited = true;
        }
    }
}