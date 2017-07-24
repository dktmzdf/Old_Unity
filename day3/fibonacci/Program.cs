﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci
{
    class Program
    {
        
        static int Fibonacci(int n)
        {
            if(n<2)
            {
                return n;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }

        static void PrintProfile(string name,string phone)
        {
            if(name == "")
            {
                Console.WriteLine("이름을 입력해주세요");
                return ;

            }
            Console.WriteLine("Name:{0} phone:{1}",name,phone);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("10번째 피보나치 수: {0}",Fibonacci(10));

            PrintProfile("", "11");
            PrintProfile("박상현", "3456-44");
        }
    }
}
