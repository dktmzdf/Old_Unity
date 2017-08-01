using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//일반화(java,c#) 클래스 - 템플릿(c++) 클래스
//클래스 내부의 멤버 자료형이 일반화 자료형으로 만들어진 클래스
//자료형의 구체적인 형태는 객체 성성시에 지정함
//형식
/*
*   class 클래스명<T>
*   {
*       //T 멤버 생성;
*   }
* 
*/
class connector<T>
{
    public string connect(T a, T b)
    {

        return a.ToString() + b.ToString();
    }
}

class A
{
    public int m_x;
    public int m_y;
    public float m_z;
    public float m_t;

}

class A <G,S>//<> 안에 단어는 중요하지 않음 그리고 일반 자료형은 1개 이상 올수 있음 구분을 위해 ','을 사용
{
    public G m_x;
    public G m_y;
    //public float m_z; //보통 변수가 옴
    public S m_z;
    public S m_t;
}
/*
 * 사용
 * 클래스형<일반화 키워드> 변수 = new 생성자
 * A<int,float> = new A<int,float>();
 */ 
namespace generic_02
{
    class Program
    {
        static void Main(string[] args)
        {
            A<int, float> a = new A<int, float>();
            a.m_x = 1;
            a.m_t = 3.14f;

            connector<int> c = new connector<int>();
            Console.WriteLine(c.connect(123,456));
        }
    }
}
