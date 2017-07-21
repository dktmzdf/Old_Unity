using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            //원래 모든 조건문 반복문은 한줄처ㅣ만 함 -수행하다
            do
            {//메모리 영역을 만들어줌 => 한개의 기능
                int a = 2 * i + 1;
                Console.WriteLine("값:" + a);//처리영역(기능수행영역 1줄)
                i++;
            } while (i < 8);


        }
    }
}
