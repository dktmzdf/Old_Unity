using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stack;

namespace QuickSort
{
    class Program
    {
        //배열이 왜 스택이 됬지?..
        
        static void QuickSort(int []Data, int left,int right)
        {
            //pivot 선정
            int pivot = left;
            
            //비교 시작
            if (left < right)
            {
                int i = left + 1;
                int j = left;
                for (; i < right; i++)
                {
                    
                    if (Data[left] > Data[i])
                    {
                        j++;
                        Swap(ref Data[j], ref Data[i]);
                        
                    }
                }
                Swap(ref Data[left], ref Data[j]);
                left = j;
                QuickSort(Data, 0, left - 1);
                QuickSort(Data, left + 1, right);
            }


        }
        static void Swap(ref int x, ref int y)
        {
            int temp = 0;
            temp = x;
            x = y;
            y = temp;
        }
        static bool ArrayCheck(int[] Data)
        {
         
            for (int i =0; i< Data.Length-1; i++)
            {
                if (Data[i] > Data[i + 1])
                {
                    Console.WriteLine("정렬실패");
                    
                    return false;
                }
                
            }
            for (int i = 0; i < Data.Length; i++)
            {
                Console.Write(Data[i] + " ");
            }

            Console.WriteLine("");
            Console.WriteLine("정렬성공");
            return true;
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

           
            Console.WriteLine(SortData[3]);
           
            //QuickSort(Data.NumData,0,Data.get_Top());
            //ArrayCheck(Data.NumData);
        }
    }
}
