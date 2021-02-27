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

            int size = 10;
            int n;
            int[] array = new int[size];
            int[] arr;

            for (int i = 0; i < size; i++)
            {
                n = r.Next(size * 2);
                array[i] = n;
                Console.WriteLine(n);
            }

            Console.WriteLine("\n");

            arr = s.InsertionSort(array);

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("-> " + arr[i]);
            }

            Console.ReadKey();
        }
    }
}