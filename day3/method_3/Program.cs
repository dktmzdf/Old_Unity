using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_3
{
    class Program
    {
        //재귀 메서드
        //메서드 내에서 메서드를 호출(자기자신을 호출)
        //끝이 있어야한다. 없으면 무한루프됨
        static uint factorial(uint number)
        {
            uint value;
            if (number == 1)
            {
                value = 1;
            }
            else
            {
                value = number * factorial(number - 1);
            }
            return value;
        }
        static void Main(string[] args)
        {
            uint result;
            result = factorial(6);
            Console.WriteLine("6! = 6*5*4*3*2*1 =>" + result);
        }
    }
}
