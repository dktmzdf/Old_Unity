using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trycatch_ex2
{
    
    class Program
    {
        static void DoSomething(int arg)
        {
            if (arg < 10) Console.WriteLine("arg : {0}", arg);
            else throw new Exception("10보다 크네");
        }

        static void Main(string[] args)
        {
            try
            {
                DoSomething(1);
                DoSomething(2);
                DoSomething(6);
                DoSomething(11);
                DoSomething(21);
                DoSomething(4);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
