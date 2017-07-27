using System;
//배열이 왜 스택이 됬지?..
namespace Stack
{
    class Stacks<T>
    {
        protected T[] Data;
        protected int ArrayLimit;
        protected int top;

        public Stacks(int size)
        {
            top = 0;
            ArrayLimit = size;
            Data = new T[size];
            for (int i = 0; i < size; i++)
            {
                Data[i] = default(T);
            }
        }
        public Stacks(Stacks<T> temp)
        {
            this.top = temp.top;
            this.ArrayLimit = temp.ArrayLimit;
            this.Data = new T[temp.ArrayLimit];
            for (int i = 0; i < temp.ArrayLimit; i++)
            {
                this.Data[i] = temp.Data[i];
            }
        }
        public Stacks(params T[] tempArray)
        {

            top = 0;
            ArrayLimit = tempArray.Length;
            Data = new T[ArrayLimit];
            for (int i = 0; i < ArrayLimit; i++)
            {
                Data[i] = tempArray[i];
            }
        }

        public int Get_Top()
        {
            return top;
        }
        public void Push(T insertNum)
        {
            if (top != ArrayLimit && top < ArrayLimit)
            {
                Data[top] = insertNum;
                top++;
            }
            else
            {
                Console.WriteLine("full stack");
            }
        }

        public T Pop()
        {
            T temp = Data[top];
            if (top > -1)
            {
                Data[top] = default(T);
                top--;
            }
            else
            {
                Console.WriteLine("empty");
            }
            return temp;
        }
        public T ResetStack(params T[] tempArray)
        {
            top = 0;
            ArrayLimit = tempArray.Length;
            for (int i = 0; i < ArrayLimit; i++)
            {
                Data[i] = tempArray[i];
            }
            return default(T);
        }
        public void ReturnStack(ref T[] temp)
        {
            for (int i=0; i<ArrayLimit; i++)
            {
                temp[i] = Data[i];
            }
            

        }

        public T[] ReturnStack_Size(int n)
        {
            T[] temp = new T[n];
            for (int i = 0; i < n; i++)
            {
                temp[i] = Data[i];
            }
            return temp;
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
    /*
    public class intStack: Basic_Stack
    {
        private int[] NumData;
        
        
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

        public override int Get_Top()
        {
            return top;
        }
       
        public void Push(int insertNum)
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

        public int Pop()
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

        public void ResetStack(params int[] tempArray)
        {
            top = 0;
            ArrayLimit = tempArray.Length;
            for (int i = 0; i < ArrayLimit; i++)
            {
                NumData[i] = tempArray[i];
            }
        }

        public int[] ReturnStack()
        {
            return this.NumData;
        }
        public int[] ReturnStack_Size(int n)
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
            
        }
    }*/
}
