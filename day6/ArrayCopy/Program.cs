using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCopy
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] origin = new long[4] { 1, 2, 3, 4 };
            long[] copy = origin;//클래스라서 간접참조라 주소카피
            copy[2] = 123;
            Console.WriteLine("1: " + origin[2]);
            Console.WriteLine("2: " + copy[2]);

            int[] a = { 5, 4, 3, 2, 1 };
            int[] clone = (int[])a.Clone();
            clone[2] = 41298;
            for (int i=0; i<a.Length; i++)
            {
                Console.WriteLine("a 값: "+a[i]);
            }

            for (int i = 0; i < clone.Length; i++)
            {
                Console.WriteLine("clone 값: "+clone[i]);
            }
        }
    }
}
