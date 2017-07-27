﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayEx1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[3];//1차원
            int[,] b = new int[2, 3] { { 10, 20, 30 }, { 40, 50, 60 } };//2차원
            int[][] c = new int[3][];//재그배열
            
            c[0] = new int[3] { 10, 20, 30 };
            c[1] = new int[2] { 40, 50 };
            c[2] = new int[1] { 60 };

            Console.WriteLine("{0},{1},{2}", c[0][0], c[0][1], c[0][2]);
            Console.WriteLine("{0},{1}", c[1][0], c[1][1]);
            Console.WriteLine("{0}", c[2][0]);
            //생성과 동시에 초기화
            int[][] d = new int[][]
            {
                new int[]{ 10,20,30 },
                new int[]{ 40,50 },
                new int[]{ 60 }


            };
            //총갯수
            Console.WriteLine("{0} {1}", a.Length, b.Length);

            int[] array1 = new int[4];
            int[,] array2 = new int[2,3];
            int[,,] array3 = new int[2, 4, 3];
            Console.WriteLine("1번째 배열"+ array1.Rank);
            Console.WriteLine("2번째 배열" + array2.Rank);
            Console.WriteLine("3번째 배열" + array3.Rank);
        }
    }
}