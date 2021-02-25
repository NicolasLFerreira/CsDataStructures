using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDataStructures.Graph
{
    class GNode<T>
    {
        public string Name { get; set; }
        public T Data { get; set; }
        public List<GNode<T>> Successors { get; set; }
        public List<GNode<T>> Predecessors { get; set; }

        public GNode(string name, T data = default)
        {
            Data = data;

            Successors = new List<GNode<T>>();
            Predecessors = new List<GNode<T>>();
        }

        public void Add(GNode<T> node)
        {
            Successors.Add(node);
            if (!node.Predecessors.Contains(this)) node.Predecessors.Add(this);
        }
    }
}
