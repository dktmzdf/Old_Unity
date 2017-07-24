using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam1
{
    class Program
    {
        static int Sum(params int[] args)
        {
            Console.WriteLine("Summing");
            int sum = 0;
            for(int i=0; i<args.Length; i++)
            {
                if (i > 0) Console.Write(", ");

                Console.Write(args[i]);

                sum += args[i];
            }
            Console.WriteLine();
            return sum;
        }
        static void Main(string[] args)
        {
            int[] arrnum = { 3, 4, 5, 6, 7, 8, 9, 10, 11, 21 };
            int sum = Sum(arrnum);
            Console.WriteLine("Sum: {0}", sum);
            //이렇게도 할수 있다
            sum = 0;
            sum = Sum(3, 4, 5, 6, 7, 8, 9, 10, 11, 21);
            Console.WriteLine("Sum: {0}",sum);
        }
    }
}
