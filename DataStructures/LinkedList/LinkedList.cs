using System;

namespace CSDataStructures.DataStructures.LinkedList
{
    class LinkedList<T>
    {
        public Node<T> Head { get; private set; }
        public Node<T> Tail { get; private set; }
        public int Count { get; private set; }

        public LinkedList()
        {
            Count = 0;
        }

        public void Add(T data)
        {
            if (Head == null)
            {
                Head = new Node<T>(data);
                Tail = Head;
            }
            else
            {
                Tail.Next = new Node<T>(data);
                Tail = Tail.Next;
            }
            Count++;
        }

        private Node<T> GetNode(int index)
        {
            Node<T> current = Head;
            for (int i = 0; i < index; i++)
            {
                if (current.Next == null) return default;
                current = current.Next;
            }
            return current;
        }

        public T Get(int index) => GetNode(index).Data;

        public void Delete(int index)
        {
            Node<T> current = GetNode(index - 1);
            current.Next = current.Next.Next;
            Count--;
        }
    }
}
