using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDataStructures.Algorithms
{
    class Sorting
    {
        public int[] BubbleSort(int[] arr)
        {
            int left = 0;
            int right = left + 1;
            int item;
            int cases = 0;

            for (int i = 0; i < arr.Length * arr.Length; i++)
            {
                if (arr[left] > arr[right])
                {
                    item = arr[right];
                    arr[right] = arr[left];
                    arr[left] = item;
                    cases++;
                }

                left++;
                right++;

                if (right == arr.Length)
                {
                    left = 0;
                    right = 1;
                    if (cases == 0) return arr;
                }
            }
            return arr;
        }

        public int[] InsertionSort(int[] arr)
        {
            int pivot;
            int current;
            int backward;
            int item;
            int length = arr.Length;

            for (pivot = 0; pivot < length; pivot++)
            {
                current = pivot;
                for (backward = pivot; backward >= 0; backward--)
                {
                    if (arr[backward] > arr[current])
                    {
                        item = arr[current];
                        arr[current] = arr[backward];
                        arr[backward] = item;
                        current = backward;
                    }
                }
            }
            return arr;
        }
    }
}
