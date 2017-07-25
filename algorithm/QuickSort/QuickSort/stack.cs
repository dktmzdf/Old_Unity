using System;
//배열이 왜 스택이 됬지?..
namespace Stack
{
    class intStack
    {
        public int[] NumData;
        private int ArrayLimit;
        private int top;
        public intStack(int size)
        {
            top = 0;
            ArrayLimit = size;
            NumData = new int[size];
            for (int i = 0; i < size; i++)
            {
                NumData[i] = int.MaxValue;
            }
        }
        public intStack(intStack temp)
        {
            this.top = temp.top;
            this.ArrayLimit = temp.ArrayLimit;
            this.NumData = new int[temp.ArrayLimit];
            for (int i = 0; i < temp.ArrayLimit; i++)
            {
                this.NumData[i] = temp.NumData[i];
            }
        }
        public int get_Top()
        {
            return top;
        }
        public void fileToArray()
        {

        }

        public void insert_Stack(int insertNum)
        {
            if (top != ArrayLimit && top < ArrayLimit)
            {
                NumData[top] = insertNum;
                top++;
            }
            else
            {
                Console.WriteLine("full stack");
            }
           
        }
        public void delete_Stack()
        {
            if (top >-1)
            {
                NumData[top] = int.MaxValue;
                top--;
            }
            else
            {
                Console.WriteLine("empty");
            }
        }

        /*public void delete_Array(int deleteLoc)
        {
            if (deleteLoc < top)
            {
                if (NumData[deleteLoc] != int.MaxValue)
                {
                    NumData[deleteLoc] = int.MaxValue;
                    for (int i = deleteLoc; i <= top; i++)
                    {
                        NumData[i] = NumData[i + 1];
                    }
                    top--;
                }
            }
            
        }*/
    }
}