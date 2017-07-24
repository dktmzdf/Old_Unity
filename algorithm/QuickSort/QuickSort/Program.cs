using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        //배열이 왜 스택이 됬지?..
        struct NumArray
        {
            public int[] NumData;
            private int top;
            public int get_Top()
            {
                return top;
            }
            public void fileToArray()
            {

            }
            public void init_Array(int size)
            {
                top = 0;
                NumData = new int[size];
                for (int i=0; i<size; i++)
                {
                    NumData[i] = int.MaxValue;
                }
            }
            public void insert_Array(int insertNum)
            {
                if (NumData[top] == int.MaxValue) NumData[top] = insertNum;
                else
                {
                    top++;
                    NumData[top] = insertNum;
                }
                top++;
            }
            public void delete_Array()
            {
                NumData[top] = int.MaxValue;
                top--;
            }
            public void delete_Array(int deleteLoc)
            {
                if (deleteLoc < top) {
                    if (NumData[deleteLoc] != int.MaxValue)
                    {
                        NumData[deleteLoc] = int.MaxValue;
                        for(int i =deleteLoc; i<=top; i++)
                        {
                            NumData[i] = NumData[i + 1];
                        }
                        top--;
                    }
                }
                
            }
        }

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
            NumArray Data;
            Data = new NumArray();
            Data.init_Array(8);
            Data.insert_Array(10);
            Data.insert_Array(11);
            Data.insert_Array(19);
            Data.insert_Array(1);
            Data.insert_Array(50);
            Data.insert_Array(31);
            Data.insert_Array(42);
            Data.insert_Array(7);

            QuickSort(Data.NumData,0,Data.get_Top());
            ArrayCheck(Data.NumData);
        }
    }
}
