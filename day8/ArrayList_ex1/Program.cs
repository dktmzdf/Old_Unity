using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList_ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            for (int i = 0; i<5; i++)
            {
                list.Add(i);
            }

            foreach (object obj in list)
            {
                Console.Write("{0} ", obj);
                
            }
            Console.WriteLine();

            list.RemoveAt(2);
            foreach (object obj in list)
            {
                Console.Write("{0} ", obj);

            }
            Console.WriteLine();
            list.Insert(2, 54398);
            foreach (object obj in list)
            {
                Console.Write("{0} ", obj);

            }
            Console.WriteLine();

            list.Add("abs");
            list.Add("def");
            for(int i=0; i<list.Count; i++)
            {
                Console.Write("{0} ",list[i]);
            }
            Console.WriteLine();

            Queue que = new Queue();
            que.Enqueue(1);
            que.Enqueue(2);
            que.Enqueue(3);
            que.Enqueue(4);
            que.Enqueue(5);
            while(que.Count>0)
            {
                Console.WriteLine(que.Dequeue());
            }

            Hashtable ht = new Hashtable();
            ht["하나"] = "one";
            ht["둘"] = "two";
            ht["셋"] = "three";
            ht["넷"] = "four";
            ht["다섯"] = "five";

            Console.WriteLine(ht["하나"]);
            Console.WriteLine(ht["둘"]);
            Console.WriteLine(ht["셋"]);
            Console.WriteLine(ht["넷"]);
            Console.WriteLine(ht["다섯"]);

        }
    }
}
