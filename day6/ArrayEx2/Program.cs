using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayEx2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int[] arrdata = { 3, 2, 9, 8, 1};
            System.Array.Sort(arrdata);
            for (i = 0; i < arrdata.Length; i++)
                Console.Write(arrdata[i]);

           
            System.Array.Clear(arrdata,0,arrdata.Length);//배열 이름 시작 위치 갯수=>세팅된 영역 클리어

            for (i = 0; i < arrdata.Length; i++)
            {
                Console.Write(arrdata[i]);
            }
            Console.WriteLine();
            int[] tst = { 1, 3, 5, 7, 8 };
            int indexNum = System.Array.IndexOf(tst,7);
            
            Console.WriteLine("7이 잇는 값은 배열의 {0}번째 인덱스입니다.",indexNum);
        }
    }
}
