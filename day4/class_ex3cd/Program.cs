using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//생성자 소멸자
//객체를 만들면 메모리 공간 할당
//c - malloc => 공간을 할당이 되지만 내부에는 쓰레기 값으로 가득참
//생성자 -> 객체의 생성 이후에 내부의 데이터를 초기화를 하기위해 필요한 호출되는 메서드
//자동 혹은 수동으로 호출됨(객체를 만들때만 쓸수 있음)
//객체가 만들어진 이후에는 생성자는 호출이 안된다.
//생성자 -> 초기화 메서드
//형식=> 리턴타입(x) 메서드명(클래스이름) 파라미터;
class A
{
    public int m_a;
    public A(int a)//메서드인데 리턴타입이 없는
    //권한   메서드이름
    {
        m_a=a;
    }//생성과 초기화는 클래스 외부에서 접근 가능하도록 권한 public
    public A()
    {
        m_a = 10;
    }
    ~A()
    {

    }

    public void showdata()
    {
        Console.WriteLine("m_a : " + m_a);
    }
}
namespace class_ex3cd
{
    class Program
    {
        static void Main(string[] args)
        {
            A ma;//객체 변수 선언(주소를 받는 변수)
            ma = new A();//객체의 생성함(객체의 공간을 만들고 초기화 하는 부분)
            //이후에 생성자 호출이 안됨
            //생성자 사용은 => new 클래스이름(파라미터)//메모리 할당 및 생성자호출
            ma.showdata();
            //클래스 이름() 생성자를 안만들경우 => 시스템이 알아서 자동으로 생성자를 만든다 따라서 시스템이 알아서 초기화(0값)으로 함
            //하지만 생성자가 1개라도 있을경우 디폴트 생성자는 생성안됨
            //기본 클래스() ;// 파라미터가 없는 생성자는 스스로 다시만들어야 사용 가능
        }
    }
}
