using System;
using System.Collections.Generic;
using CSDataStructures.CLinkedList;
using CSDataStructures.HashTable;
using CSDataStructures.Graph;

namespace CSDataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            CHashTable<int> h = new CHashTable<int>(2);
            CLinkedList<int> cll = new CLinkedList<int>();

            cll.Add(123);
            cll.Add(69);
            cll.Add(16);
            cll.Add(2048);
            cll.Add(1000);
            cll.Add(420);

            Console.WriteLine(cll.Get(2));
            cll.Delete(2);
            Console.WriteLine(cll.Get(2));

            //--------------------------------------//

            LinkedList<int> ll = new LinkedList<int>();
            List<int> l = new List<int>();

            Console.ReadKey();
        }
    }
}

