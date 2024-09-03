using System;

namespace CSDataStructures.DataStructures.LinkedList
{
    class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; }

        public Node(T data)
        {
            Data = data;
            Next = null;
        }

        public bool Equals(Node<T> o)
        {
            return Data.Equals(o.Data);
        }
    }
}
