﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property_ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new { Name = "박상현", Age = 123 };
            Console.WriteLine("Name:{0}, Age = {1}, ",a.Name,a.Age);
            var b = new { Subject = "수학", Scores = new int[] { 90,80,70,60} };
            Console.Write("Subject :{0} ", b.Subject);
            foreach (var i in b.Scores)
                Console.Write("Scores = {0}, ", i);

            Console.WriteLine();
        }                                                                                                             
    }
}
