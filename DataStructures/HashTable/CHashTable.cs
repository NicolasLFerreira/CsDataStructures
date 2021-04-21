using System;

using CSDataStructures.DataStructures.CLinkedList;

namespace CSDataStructures.DataStructures.HashTable
{
    class CHashTable<T>
    {
        // Constructor. Creates an array with certain size
        public CHashTable(int size)
        {
            Table = new LinkedList<CContent<T>>[size];
        }

        // Array of buckets
        private LinkedList<CContent<T>>[] Table { get; set; }

        // Hashing algorithm
        public int Hashing(string key)
        {
            int index = 0;
            for (int i = 0; i < key.Length; i++)
            {
                index += key[0];
            }
            return (index * 13) % Table.Length;
        }

        // Adds a new item to a bucket
        public void Add(string key, T data)
        {
            int hash = Hashing(key);
            if (Table[hash] == null) Table[hash] = new LinkedList<CContent<T>>();
            Table[hash].Add(new CContent<T>(key, data));
        }

        public T this[string key]
        {
            get
            {
                return Get(key);
            }
            set 
            {
                Add(key, (T)value);
            }
        }

        // Returns the data of a bucket
        public T Get(string key)
        {
            Node<CContent<T>> currentNode;
            int hash = Hashing(key);

            if (Table[hash] == null) return default;

            currentNode = Table[hash].Head;

            for (int i = 0; i < i + 1; i++)
            {
                if (currentNode.Data.Key == key) return currentNode.Data.Data;
                else if (currentNode.Point != null) currentNode = currentNode.Point;
                else return default;
            }
            return default;
        }
    }
}
