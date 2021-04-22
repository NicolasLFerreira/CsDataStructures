using System;

using CSDataStructures.DataStructures.Tree;
using CSDataStructures.DataStructures.HashTable;

namespace CSDataStructures
{
    class Program
    {
        public static void Main()
        {
            HashTable<int> age = new HashTable<int>(1);

            int amount = 15;

            for (int i = 0; i < amount; i++)
            {
                age[$"Person {i}"] = i;
            }

            for (int i = 0; i < amount; i++)
            {
                Console.WriteLine(age[$"Person {i}"]);
            }

            Console.ReadLine();
        }
    }
}