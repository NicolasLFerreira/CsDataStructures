using System;
using System.Collections.Generic;
using CSDataStructures.CLinkedList;
using CSDataStructures.HashTable;
using CSDataStructures.Graph;

using CSDataStructures.Algorithms.Search;

namespace CSDataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Search s = new Search();

            int[] arr = new int[24];
            int number = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                number += i;
                Console.WriteLine($"{number} : {i}");

                arr[i] = number;
            }

            Console.WriteLine(number);

            Console.WriteLine($"Jump search: {s.JumpSearch(arr, 78, arr.Length / 6)}");
            Console.WriteLine($"Binary search: {s.ImprovedLinearSearch(arr, 231)}");

            Console.ReadKey();
        }
    }
}