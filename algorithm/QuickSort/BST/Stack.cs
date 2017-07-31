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
            for (int i = 0; i < ArrayLimit; i++)
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

}
