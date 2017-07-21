using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            //for문을 이용한 객체데이터 접근및 정보 취득;
            //컬렉션: 객체 1개이상의 데이터를 가진 자료형, 클래스
            //배열    배열 index, 리스트 현재위치
            //foreach(데이터타입 변수명 in 배열이나 컬렉션 객체)
            //=>해당객체가 가진 모든 데이터를 ()안에 선언된 변수에 차례로 넣어줌.
            int[] num = { 1, 2, 3, 4, 5 };
            foreach (int readdata in num)//하나씩 넣어주면서 반복-> 값이 없을떄까지
            {
                Console.WriteLine(readdata);
            }
            string[] str = { "sword","shield","tank","AXE"};
            string[] tmp = new string[4];
            int count = 0;
            foreach(string readdata in str)
            {

                Console.WriteLine(readdata);
                tmp[count] = readdata;
                count++;
            }
            for (int j=0;j<4;j++)
            {
                Console.WriteLine(tmp[j]);

            }



        }
    }
}
