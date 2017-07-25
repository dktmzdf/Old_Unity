using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stack;

namespace MergeSort
{
    class Program
    {
        

        
        public static void printArray(params int[] array)
        {
            foreach (int element in array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }

        public static void merge(int[] array, int start, int mid, int end)
        {
        }
        public static void mergeSort(int[] array, int start, int end)
        {

        }
        static void Main(string[] args)
        {
            int[] array = new int[] { 14, 7, 3, 12, 9, 11, 6, 2 };
            mergeSort(array, 0, array.Length - 1);
            printArray(array);
            
        }
    }
}
