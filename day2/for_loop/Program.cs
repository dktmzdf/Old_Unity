using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_loop
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //Console.WriteLine(i); <= 문제가 생김
            int i=3;
            for (i = 1; i < 9; i++)//해다 세팅부는 필요에따라 생략이 가능하다
                                   //초기값, 조건식(반복문탈출을 위하여),증감식(반복탈출을 위한 값의 변경)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.WriteLine((i+1) + " * " + (j+1) + " = " + ((i+1)*(j + 1)));
                }

            }
            //객체지향 언어에서 잘형은 필요할때 생성해서 사용한다
            //자료형의 적용범위는 선언 이후부터 해당 영역이 끝날때까지.
            for (i = 1; i <= 9; i+=2) 
            {
                for (int k = 0; k < 5 - i / 2; k++) 
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i; j++) 
                {
                    
                        Console.Write("*");
                   
                   
                }
                for (int k = 0; k < 5 - i / 2; k++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("");

            }


            /*
             */
        }
    }
}
