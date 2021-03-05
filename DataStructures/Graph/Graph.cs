using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDataStructures.DataStructures.Graph
{
    class Graph<T>
    {
        private List<Node<T>> Nodes { get; set; }
        public int Size { get; set; }

        public Node<T> this[int index]
        {
            get
            {
                return Nodes[index];
            }
            set 
            {
                Nodes.Insert(index, value);
            }
        }

        public Graph(int size)
        {
            Size = size;
            Nodes = new List<Node<T>>(size);
        }

        public Graph(List<Node<T>> nodes)
        {
            Size = nodes.Count();
            Nodes = nodes;
        }

        public void AddVertex(Node<T> node)
        {
            Nodes.Add(node);
        }

        public void RemoveVertex(Node<T> node)
        {
            Nodes.Remove(node);
        }

        public void DepthFirstSearch(Node<T> root)
        {
            if (!root.Visited)
            {
                Console.WriteLine($"{root.Data} -> ");
                root.Visit();
                foreach (Node<T> neighbor in root.Neighbors)
                {
                    DepthFirstSearch(neighbor);
                }
            }
        }

        public void BreadthFirstSearch(Node<T> root)
        {
            Queue<Node<T>> queue = new Queue<Node<T>>();

            root.Visit();

            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                Node<T> current = queue.Dequeue();

                foreach (Node<T> neighbor in current.Neighbors)
                {
                    Console.WriteLine(neighbor.Data);
                    neighbor.Visit();
                    queue.Enqueue(neighbor);
                }
            }
        }
    }
}
