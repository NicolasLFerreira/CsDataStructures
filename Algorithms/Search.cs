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
            int length = array.Length;
            for (int i = 0; i < length; i += step)
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
            int length = array.Length;
            int mid;
            int left = 0;
            int right = length - 1;
            while (left <= right)
            {
                mid = (left + right) / 2;

                if (array[mid] == value) return mid;

                if (array[mid] > value) right = mid - 1;
                if (array[mid] < value) left = mid + 1;
            }
            return -1;
        }
    }
}
