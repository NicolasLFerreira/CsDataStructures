using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDataStructures.Algorithms.Search
{
    class Search
    {
        public int JumpSearch(int[] array, int value, int step)
        {
            for (int i = 0; i < array.Length; i += step)
            {
                if (array[i] == value) return i;
                if (array[i] > value)
                {
                    i -= step;
                    for (int j = i; j < i + step; j++)
                    {
                        if (array[j] == value) return j;
                    }
                }
            }
            return -1;
        }

        public int ImprovedLinearSearch(int[] array, int value)
        {
            int length = array.Length;
            int right = -1;
            int left = length;

            for (int i = 0; i < length / 2; i++)
            {
                if (array[++right] == value) return right;
                if (array[--left] == value) return left;
            }
            return -1;
        }

        public int BinarySearch(int[] array, int value)
        {

        }
    }
}
