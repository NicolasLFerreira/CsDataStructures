using System;

using CSDataStructures.DataStructures.LinkedList;
using CSDataStructures.DataStructures.Tree;
using CSDataStructures.DataStructures.HashTable;
using System.Collections.Specialized;

namespace CSDataStructures
{
    class Program
    {
        public static void Main()
        {
            SinglyLinkedList<int> ints = new SinglyLinkedList<int>();

            for (int i = 0; i < 10; i++)
            {
                ints.Add(i * 7);
            }

            foreach (var item in ints)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            ints.Remove(0);

            foreach (var item in ints)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}