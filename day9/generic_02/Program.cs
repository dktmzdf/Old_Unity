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
class A
{
    public int m_x;
    public int m_y;

}

class A <G>//<> 안에 단어는 중요하지 않음
{
    public G m_x;
    public G m_y;
}

namespace generic_02
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
