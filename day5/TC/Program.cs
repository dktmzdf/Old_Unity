using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TC
{
    class AAA
    {
        int m_a, m_b;
        //this.m_a;// '.' 연산자는 캘래스 내부의 데이터
        //클래스내의 ':'연산자는 영역지정 연산자
        //생성자는 리터타입이 없는 클래스 이름을 가진 메서드
        //AAA:AAA()
        AAA():this(0,0)//클래스가 생성되고 생성자를 호출할때는 쓸수 있지만 정의->내부에 생성자 메서드는 호출할수 없음
        {
            
        }
        //:this()=> this 생성자
        //현재 내 클래스에 내장된 생성자를 호출.. 다른 생성자에서 필ㅇ한 생성자 호출
        //this 생성자는 현재 내가 작성중인 생성자를 호출할 수 없다.
        //이미 정의가 완료된 생성자만 호출가능
        public AAA(int a,int b) //: this(3,3)
        {
            
            m_a = a;
            m_b = b;

        }
    }

    class MyClass
    {
        int a, b, c;
        public MyClass()
        {
            this.a = 5425;
            Console.WriteLine("MyClass()");
        }
        public MyClass(int b) : this()
        {
            this.b = b;
            Console.WriteLine("MyClass({0})", b);
        }
        public MyClass(int b, int c) : this(b)
        {
            this.c = c;
            Console.WriteLine("MyClass({0},{1})", b, c);
        }
        public void PrintFields()
        {
            Console.WriteLine("a:{0} b:{1} c:{2}",a, b, c);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass a = new MyClass();
            a.PrintFields();
            Console.WriteLine();

            MyClass b = new MyClass(1);
            b.PrintFields();
            Console.WriteLine();

            MyClass c = new MyClass(10,20);
            c.PrintFields();
            Console.WriteLine();
        }
    }
}
