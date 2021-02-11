using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDataStructures.Graph
{
    class GNode
    {
        public string Name { get; set; }
        public int Data { get; set; }
        public List<GNode> Successors { get; set; }
        public List<GNode> Predecessors { get; set; }

        public GNode(string name, int data = 1)
        {
            Data = data;

            Successors = new List<GNode>();
            Predecessors = new List<GNode>();
        }

        public void Add(GNode node)
        {
            Successors.Add(node);
            if (!node.Predecessors.Contains(this)) node.Predecessors.Add(this);
        }
    }
}
