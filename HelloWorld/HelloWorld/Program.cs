using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld // 작업영역 //다른영역에 기능을 정의
{
    class Program
    {
        static void Main(string[] args)
        {
            //printf()
            //System.Out.println()
            //화면에 문자열 데이터 출력
            Console.Write("윤하");//문자열 출력
            //pringf("윤하");

            Console.WriteLine(133);//숫자 출력
            Console.WriteLine("비밀번호");
            //printf("윤하\n");
            //데이터와 문자열을 같이 출력하는 방법
            Console.WriteLine("비밀번호" + 1122);
            Console.WriteLine("비밀번호 {0} {1} {2} {20}", 4444888,2,3,4,5,6,7,8,6,6,5,4,33,2,7,8,5,7456,4,2,4,6,7,5,34,43,6,7,41,1);
            Console.WriteLine("abce" + (213 + 32 +43) +  " de4ds " + 156 );

            //절차지향언어 정의부, 연산부가 구분되어야 한다.

            //정의
            //연산,메서드

            //객체지향언어: 필요에 따라서 그때그때 데이터를 정의 할수 있다.
            int num = 333;
            Console.WriteLine(num);







        }
    }
}
