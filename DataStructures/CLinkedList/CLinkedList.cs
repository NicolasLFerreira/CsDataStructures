using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDataStructures.DataStructures.CLinkedList
{
    class CLinkedList<T>
    {
        public CLinkedList() { }

        public LLNode<T> Head { get; private set; }
        public LLNode<T> Tail { get; private set; }

        public void Add(T data)
        {
            if (Head == null)
            {
                Head = new LLNode<T>(data);
                Tail = Head;
            }
            else
            {
                Tail.Point = new LLNode<T>(data);
                Tail = Tail.Point;
            }
        }

        private LLNode<T> GetNode(int index)
        {
            LLNode<T> current = Head;
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
            LLNode<T> current = GetNode(index - 1);
            current.Point = current.Point.Point;
        }
    }
}
