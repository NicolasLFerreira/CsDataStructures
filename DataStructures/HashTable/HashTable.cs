using System;

using CSDataStructures.DataStructures.LinkedList;

namespace CSDataStructures.DataStructures.HashTable
{
    class HashTable<T>
    {
        // Array of buckets
        private SinglyLinkedList<Content<T>>[] Table { get; set; }
        public int Count { get; private set; }
        public readonly int Size;

        // Constructor. Creates an array with certain size
        public HashTable(int size)
        {
            Table = new SinglyLinkedList<Content<T>>[size];
            Size = size;

            for (int i = 0; i < size; i++)
            {
                Table[i] = new SinglyLinkedList<Content<T>>();
            }
        }
        
        public T this[string key]
        {
            get => Get(key);
            set => Add(key, value);
        }

        // Hashing algorithm
        public int Hashing(string key)
        {
            int sum = 0;
            for (int i = 0; i < key.Length; i++)
            {
                sum += key[i];
            }
            return (sum * 13) % Table.Length;
        }

        // Adds a new item to a bucket
        public void Add(string key, T data)
        {
            int hash = Hashing(key);
            Table[hash].Add(new Content<T>(key, data));
            Count++;
        }

        // Returns the data of a bucket
        public T Get(string key)
        {
            Node<Content<T>> currentNode;
            int hash = Hashing(key);

            if (Table[hash].Head == null) return default;

            currentNode = Table[hash].Head;

            for (int i = 0; i < i + 1; i++)
            {
                if (currentNode.Data.Key == key) return currentNode.Data.Data;
                else if (currentNode.Next != null) currentNode = currentNode.Next;
            }
            throw new IndexOutOfRangeException();
        }

        public int GetItemPosition(string key)
        {
            int hash = Hashing(key);
            SinglyLinkedList<Content<T>> list = Table[hash];
            Node<Content<T>> node = list.Head;

            // Runs through the list to get the index of the item of the certain key
            for (int i = 0; i < list.Count; i++)
            {
                if (node.Data.Key == key)
                {
                    return i;
                }
                node = node.Next;
            }
            return -1;
        }

        // Removes the item of a certain key
        public void Remove(string key)
        {
            int hash = Hashing(key);
            int position = GetItemPosition(key);
            SinglyLinkedList<Content<T>> list = Table[hash];

            // If theres no item with this key, returns
            if (position == -1) return;

            //list.Delete(position);
            Count++;
        }
    }
}
