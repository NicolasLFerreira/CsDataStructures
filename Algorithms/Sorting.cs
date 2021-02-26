using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDataStructures.Algorithms
{
    class Sorting
    {
        public int[] MySort(int[] arr)
        {
            int left = 0;
            int right = left + 1;
            int item;

            for (int i = 0; i < arr.Length * arr.Length; i++)
            {
                if (arr[left] > arr[right])
                {
                    item = arr[right];
                    arr[right] = arr[left];
                    arr[left] = item;
                }

                left++;
                right++;

                if (right == arr.Length)
                {
                    left = 0;
                    right = 1;
                }
            }
            return arr;
        }
    }
}
