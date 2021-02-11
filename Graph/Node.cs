using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDataStructures.Graph
{
    class Node
    {
        public string Name { get; set; }
        public int Data { get; set; }
        public List<Node> Successors { get; set; }
        public List<Node> Predecessors { get; set; }

        public Node(string name, int data = 1)
        {
            Data = data;

            Successors = new List<Node>();
            Predecessors = new List<Node>();
        }

        public void Add(Node node)
        {
            Successors.Add(node);
            if (node.Predecessors.Contains(this)) node.Predecessors.Add(this);
        }
    }
}
