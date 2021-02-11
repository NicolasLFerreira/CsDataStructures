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
            //CHashTable<int> h = new CHashTable<int>(2);
            //CLinkedList.CLinkedList<int> cll = new CLinkedList.CLinkedList<int>();

            //cll.Add(123);
            //cll.Add(69);
            //cll.Add(16);
            //cll.Add(2048);
            //cll.Add(1000);
            //cll.Add(420);

            //Console.WriteLine(cll.Get(2));
            //cll.Delete(2);
            //Console.WriteLine(cll.Get(2));

            //--------------------------------------//

            GNode test1 = new GNode("Node1", 1);
            GNode test2 = new GNode("Node1", 2);
            GNode test3 = new GNode("Node1", 3);
            GNode test4 = new GNode("Node1", 4);
            GNode test5 = new GNode("Node1", 5);

            test1.Add(test2);

            Console.WriteLine(test2.Predecessors[0].Data);

            Console.ReadKey();
        }
    }
}

