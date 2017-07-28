using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using NameTest;

namespace NameTest
{
    public class TestA
    {
        public void showdata()
        {
            Console.WriteLine("nametest 영역에 있는 클래스 TestA입니다.");
        }
    }
}
//가정 클래스이름은 중복이 안됨 
//1.namespace 이름을 중복하면 어떻게 될까?.. => 합쳐진다.
//2.namespace 이름이 중복되면 내부 클래스는? => 같은 이름은 충돌이 일어남
namespace NameTest2//namespace 중복
{
    class Program
    {
        static void Main(string[] args)
        {
            NameTest.TestA a = new NameTest.TestA();
            a.showdata();

            //namespace의 이름이 중복되면 같은 이름의 namespace끼리 합쳐진다.
            //namespace는 분할해서 합쳐서 쓸수 있다.
            NameTest.TestA b = new NameTest.TestA();
            b.showdata();
            /*
            TestA a = new TestA();
            a.showdata();*/
        }
    }
}
