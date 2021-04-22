using System;

namespace CSDataStructures.DataStructures.LinkedList
{
    class Node<T>
    {
        public Node() { }
        public Node(T data)
        {
            Data = data;
            Next = null;
        }

        public T Data { get; set; }
        public Node<T> Next { get; set; }
    }
}
