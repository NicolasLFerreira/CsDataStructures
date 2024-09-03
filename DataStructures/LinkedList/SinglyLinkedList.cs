using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Policy;

namespace CSDataStructures.DataStructures.LinkedList
{
    class SinglyLinkedList<T> : ICollection<T>, ICollection, IEnumerable<T>, IEnumerable
    {
        public Node<T> Head { get; private set; }
        public Node<T> Tail { get; private set; }
        public int Count { get; private set; }
        public bool IsReadOnly => true;
        public object SyncRoot => false;
        public bool IsSynchronized => false;

        public SinglyLinkedList()
        {
            Count = 0;
        }

        public void AddHead(T item)
        {
            Node<T> newNode = new Node<T>(item);
            if (Head == null)
            {
                Head = newNode;
                Tail = Head;
            }
            else
            {
                newNode.Next = Head;
                Head = newNode;
            }
        }

        public void Add(T item)
        {
            Node<T> newNode = new Node<T>(item);

            if (Head == null)
            {
                Head = newNode;
                Tail = Head;
                Count++;
            }
            else
            {
                Tail.Next = newNode;
                Tail = Tail.Next;
                Count++;
            }
        }

        public void Clear()
        {
            Head = null;
            Count = 0;
        }

        public bool Contains(T item)
        {
            Node<T> current = Head;

            while (current != null)
            {
                if (current.Data.Equals(item)) return true;
                current = current.Next;
            }
            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            int count = arrayIndex;
            foreach (T item in this)
            {
                if (count >= array.Length) break;
                array[count++] = item;
            }
        }

        public bool Remove(T item)
        {
            Node<T> current = Head;

            if (Head.Data.Equals(item))
            {
                Head = Head.Next;
                Count--;
                return true;
            }

            while (current.Next != null)
            {
                if (current.Next.Data.Equals(item))
                {
                    current.Next = current.Next.Next;
                    Count--;
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> current = Head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }
    }
}
