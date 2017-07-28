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
        public static void merge(int[] array, int start, int mid, int end)
        {
            int[] resultArray = new int[array.Length];
            int low = start;
            int high = mid + 1;
            int key = start;

            // 나눠서 비교해서 정렬
            while (low <= mid && high <= end)
            {
                if (array[low] < array[high])
                {
                    resultArray[key] = array[low];
                    low++;
                }
                else
                {
                    resultArray[key] = array[high];
                    high++;
                }
                key++;
            }
            // 오른쪽(high) array 값이 다 처리 안됫을 경우
            if (low > mid)
            {
                for (; high <= end; high++)
                {
                    resultArray[key] = array[high];
                    key++;
                }
                // 왼쪽(low) array 값이 다 처리 안됫을 경우
            }
            else
            {
                for (; low <= mid; low++)
                {
                    resultArray[key] = array[low];
                    key++;
                }
            }
            // 임시로 만든 array를 정렬할 array에 복사
            for (int i = start; i <= end; i++)
            {
                array[i] = resultArray[i];
            }
            printArray(array);
        }

        
        
        public static void printArray(params int[] array)
        {
            foreach (int element in array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
        
        public static void mergeSort(int[] array, int start, int end)
        {
            if (start < end)
            {
                int mid = ((start + end) / 2);
                mergeSort(array,start,mid);
                mergeSort(array, mid+1, end);
                merge(array,start,mid,end);
            }
        }
        static void Main(string[] args)
        {
            Stacks<int> Datas;
            Datas = new Stacks<int>(8);

            Datas.Push(10);
            Datas.Push(11);
            Datas.Push(19);
            Datas.Push(1);
            Datas.Push(50);
            Datas.Push(31);
            Datas.Push(42);
            Datas.Push(7);
            
            int[] SortData;
            SortData = new int[Datas.Get_Top()];
            Datas.ReturnStack(ref SortData);

            printArray(SortData);
            Console.WriteLine(SortData[3]);
            mergeSort(SortData,0,SortData.Length-1);
            
            printArray(SortData);
            //ArrayCheck(Data.NumData);

        }
    }
}
/*
        public static void merge(int[] array, int start, int mid, int end)
        {
            int[] arr = new int[array.Length];
            int key = start;
            int left = start;
            int right = mid + 1;

            while(left <= mid && right <=end)
            {
                if(array[left] < array[right])
                {
                    arr[key] = array[left];
                    left++;
                    
                }
                else
                {
                    arr[key] = array[right];
                    right++;
                }
                key++;
            }
            if (left > mid)
            {
                while (true)
                {
                    if (right <= end)
                    {
                        break;
                    }
                    arr[key] = array[right];
                    key++;
                    right++;

                }
            }
           else
            {
                while (true)
                {
                    if (left <= mid)
                    {
                        break;
                    }
                    arr[key] = array[left];
                    key++;
                    left++;


                }
            }
            for (int i = start; i <= end; i++)
            {
                array[i] = arr[i];
            }
            printArray(array);

        }*/
