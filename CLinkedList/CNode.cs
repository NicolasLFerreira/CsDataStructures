using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDataStructures.CLinkedList
{
    class LLNode<T>
    {
        public LLNode() { }
        public LLNode(T data)
        {
            Data = data;
            Point = null;
        }

        public T Data { get; set; }
        public LLNode<T> Point { get; set; }
    }
}
