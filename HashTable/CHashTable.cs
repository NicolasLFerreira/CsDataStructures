﻿using System;
using CSDataStructures.LinkedList;

namespace CSDataStructures.HashTable
{
    class CHashTable<T>
    {
        // Constructor. Creates an array with certain size
        public CHashTable(int size)
        {
            Table = new CLinkedList<CContent<T>>[size];
        }

        // Array of buckets
        private CLinkedList<CContent<T>>[] Table { get; set; }

        // Hashing algorithm
        public int Hashing(string key)
        {
            int index = 0;
            for (int i = 0; i < key.Length; i++)
            {
                index += key[0];
            }
            return index % (Table.Length * 13);
        }

        // Adds a new item to a bucket
        public void Add(string key, T data)
        {
            int hash = Hashing(key);
            if (Table[hash] == null) Table[hash] = new CLinkedList<CContent<T>>();
            Table[hash].Add(new CContent<T>(key, data));
        }

        // Returns the data of a bucket
        public T Get(string key)
        {
            CNode<CContent<T>> currentNode;
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
