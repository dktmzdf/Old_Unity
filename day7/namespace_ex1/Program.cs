using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//namespace:
//다중작업을 통해 프로젝트 것ㅇ시
//클래스의 중복이 생기수 있다.
//해당 클래스의 소속을 명시한다.
//즉 중복이나 모호성을 해소할수있다.>namespace
//같은 이름의 클래스가 있어도 충돌안나게
/*
 * 형식
 * //선언
 * namespace 이름(영역 이름)
 * {
 *      클래스를 구현
 * }
 * 
 * 사용
 * 영역이름.클래스명 변수 = new 영역이름의 클래스명;
 * //namespace 를 이용한 객체는 해당 namespace(영역이름)을 명시해야만 한다.
 * => 네임스페이스내에 정의된 클래스를 참조할때 '.'연산자를 이용한다
 */
//서로 다른 namespace 1:1
namespace AA
{
    class carddata
    {
        public int m_a;
    }
}
namespace BB
{
    namespace BBB
    {
        class carddata
        {
            public int m_a;
        }
    }
}

//namespace 내에 namespace가 들어갈 수 있는가?//o
//중첩해서 사용할수 있다.
//사용은 ?
//
namespace namespace_ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            AA.carddata a = new AA.carddata();
            BB.BBB.carddata b = new BB.BBB.carddata();
            //사용은 기존과 동일
            Console.WriteLine("{0} {1}",a.m_a,b.m_a);
        }
    }
}
