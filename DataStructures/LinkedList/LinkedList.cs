using System;

namespace CSDataStructures.DataStructures.CLinkedList
{
    class LinkedList<T>
    {
        public LinkedList() { }

        public Node<T> Head { get; private set; }
        public Node<T> Tail { get; private set; }

        public void Add(T data)
        {
            if (Head == null)
            {
                Head = new Node<T>(data);
                Tail = Head;
            }
            else
            {
                Tail.Point = new Node<T>(data);
                Tail = Tail.Point;
            }
        }

        private Node<T> GetNode(int index)
        {
            Node<T> current = Head;
            for (int i = 0; i < index; i++)
            {
                if (current.Point == null) return default;
                current = current.Point;
            }
            return current;
        }

        public T Get(int index) => GetNode(index).Data;

        public void Delete(int index)
        {
            Node<T> current = GetNode(index - 1);
            current.Point = current.Point.Point;
        }
    }
}
