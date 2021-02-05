using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDataStructures.CLinkedList
{
    class CNode<T>
    {
        public CNode() { }
        public CNode(T data)
        {
            Data = data;
            Point = null;
        }

        public T Data { get; set; }
        public CNode<T> Point { get; set; }
    }
}
