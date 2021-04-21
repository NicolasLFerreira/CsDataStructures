using System;

namespace CSDataStructures.DataStructures.CLinkedList
{
    class Node<T>
    {
        public Node() { }
        public Node(T data)
        {
            Data = data;
            Point = null;
        }

        public T Data { get; set; }
        public Node<T> Point { get; set; }
    }
}
