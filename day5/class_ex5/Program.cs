using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//this: 현재 활성화된 내 내클래스을 의미
class employee
{
    string a;//클래스 내의 멤버변수
    void SetData(string a)
    //내 클래스내의 함수에서 사용할 파라미터변수
    //호출되면 생성되고 함수가 끝나며 파기 클래스영ㅇ역 내부 함수영역->만들어지는 영역이 다르다
    //==>이름이 같아도 문제없음
    {
        //모호성이 발생함 어떤게 멤버고 어떤게 파라미터인가?
        this.a = a;
    }
}

namespace class_ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            //변수의 우선순위
            int a = 5;
            {
                //int a = 7;
                int b;
                Console.WriteLine(a);
                {
                    Console.WriteLine(a); ;
                }
            }
        }
    }
}
