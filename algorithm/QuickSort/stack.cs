using System;
//배열이 왜 스택이 됬지?..
namespace Stack
{
    private class intStack
    {
        private int[] NumData;
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
        public intStack(params int[] tempArray)
        {

            top = 0;
            ArrayLimit = tempArray.Length;
            NumData = new int[ArrayLimit];
            for (int i = 0; i < ArrayLimit; i++)
            {
                NumData[i] = tempArray[i];
            }
        }

        public int get_Top()
        {
            return top;
        }
       
        public int push(int insertNum)
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

        public int pop()
        {
            int temp = NumData[top];
            if (top >-1)
            {
                NumData[top] = int.MaxValue;
                top--;
            }
            else
            {
                Console.WriteLine("empty");
            }
            return temp;
        }

        public void resetStack(params int[] tempArray)
        {
            top = 0;
            ArrayLimit = tempArray.Length;
            for (int i = 0; i < ArrayLimit; i++)
            {
                NumData[i] = tempArray[i];
            }
        }

        public int[] returnStack()
        {
            return this.NumData;
        }
        public int[] returnStack_Size(int n)
        {
            int[] temp = new int[n];
            for (int i = 0; i < n; i++)
            {
                temp[i] = NumData[i];
            }
            return temp;
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