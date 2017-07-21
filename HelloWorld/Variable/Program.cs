using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable
{
    //\n \t
    class Program
    {
        static void Main(string[] args)
        {
            byte bytevalue = 127;//바이트 자료형은 원해 양의 정수타입
            sbyte bytevalue2 = -120;
            
            int intvalue = 123456789;
            uint usignedintvalue = 1122345687;
            long longvalue = 12345678987654;
            Console.WriteLine("값은 \n " + bytevalue + " " + intvalue + " "+ usignedintvalue + " "+ longvalue);
            Console.WriteLine("값은 \n " + bytevalue2);
            //cf) int uint
            //byte sbyte

            float fvalue = 3.1415f;
            double dvalue = 3.1415;
            decimal dmvalue = 3.1415m;
            Console.WriteLine("값은 \n " + fvalue + " " + dvalue + " " + dmvalue + " ");

            //int maxvalue = 240000000;
            int maxvalue = int.MinValue;
            maxvalue--;
            Console.WriteLine(maxvalue);

            bool a;
            
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(uint.MaxValue);
            Console.WriteLine(char.MaxValue);
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(ulong.MaxValue);
            Console.WriteLine(byte.MaxValue);
            Console.WriteLine(sbyte.MaxValue);
            Console.WriteLine(float.MaxValue);
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(decimal.MaxValue);
            
            
        }
    }
}
//자료형 
//var num = "asga";
//Console.WriteLine(num);
//var num2 = 333;
//Console.WriteLine(num2);

//정수                          C       C#
//int -(2^31) ~ (2^(32-1) -1)   4       "
//long                          4       8
//short                         2       2
//char                          1       "
//long long                     8       X
//byte                          1       "
//unsighed int                          uint
//unsighed long                         ulong
//실수
//float                        소수점 3째자리수  정밀도
//double                        소수점 8째자리수 정밀도
//(C#) decimal                  double보다 훨씬 정밀함
//user -> float?
//computer -> double
//실수 자료형타입을 표시
//3.14159f 해야 ->float
//3.14159 ->double
//3.14159m ->decimal