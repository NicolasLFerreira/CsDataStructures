using System;
using System.Collections.Generic;
using CSDataStructures.CLinkedList;
using CSDataStructures.HashTable;
using CSDataStructures.Graph;

using CSDataStructures.Algorithms;

namespace CSDataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Sorting s = new Sorting();
            Random r = new Random((int)(DateTime.Now.Ticks % int.MaxValue));

            int[] array = new int[100];
            int[] arr;
            int n;

            for (int i = 0; i < array.Length; i++)
            {
                n = r.Next(100);
                array[i] = n;
                Console.WriteLine(n);
            }

            Console.WriteLine();

            arr = s.MySort(array);

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Console.ReadKey();
        }
    }
}