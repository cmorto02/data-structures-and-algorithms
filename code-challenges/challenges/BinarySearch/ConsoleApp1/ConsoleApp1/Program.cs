using System;

namespace BinarySearchAlgorithm
{
    public class Program
    {
        static void Main(string[] args)
        {
          
        }
        /// <summary>
        /// This is a binary search algorithm, it finds the midpoint and compares the key to the midpoints value. If the value is the same it returns the midpoint, if it is greater or less than the mid point it redefines the start end and mid points to the greater or lesser half of the array respectively. It repeats this process until the key is found or it returns a negative 1. If the key is found it will return the index.
        /// </summary>
        /// <param name="array">The array to be searched</param>
        /// <param name="key">The int the method is searching for</param>
        /// <returns>Either -1 or the index of the key</returns>
        public static int BinarySearch(int[] array, int key)
        {
            int start = 0;
            int end = array.Length - 1;
            int mid = (array.Length - 1) / 2;
            if (array[mid] == key)
            {
                return mid;
            }
            while (end>start)
            {
                if (key == array[mid])
                {
                    return mid;
                }
                if (key > array[mid])
                {
                    start = mid+1;
                    mid = ((end - start) / 2) + start;
                }
                if (key < array[mid])
                {
                    end = mid-1;
                    mid = ((end - start) / 2) + start;
                }   
            }
                return -1;
            
        }
    }
}
