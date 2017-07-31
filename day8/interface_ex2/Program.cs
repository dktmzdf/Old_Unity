using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





/*
 * 인터페이스의 상속
 * 인터페이스는 클래스처럼 상속해서 인터페이스를 만들수 있다.
 * 이때 상속받는 클래스는 : 기호를 사용한다
 * ex) interface A:B
 *     {
 *     }
 * 인터페이스는 복수로 상속받아서 쓸수 있다.=>기능(메스드의) g형태만 추가이기 때문에
 * ex) interface :B,c,d,e,
 * {
 * }
 */


/* 상속형식을 만들때, 파생 객체와 기반 객체(부모)의 멤버메서드가 중복될시
 * 모호성이 발생되며 warning 경고를 호출함
 * =>부모자식이 같은 멤버라면 부모 객체의 멤버를 은폐를 시켜야 한다.
 *  
 */




    /*


interface A
{
    void f();
}
interface B : A
{
    new void f();
}
//상속대상 인터페이스에 같은 메서드가 있을때 -> new 키워드를 통해 상속대상을 메서드를 우선순위에 ㄶ고 기반 메서드를 은폐시킨다.
class C
{
    public void f()
    {
        Console.WriteLine("AAA");
    }
}
class D : C
{
    //클래스 외부의 new 공간할당 /클래스 내부 new ->부모객체의 은폐
    new public void f()//자식객체의 메서드 앞에 new 키워드를 붙인다
    {
        Console.WriteLine("AA1112121A");
    }
}

namespace interface_ex2
{
    interface ILogger
    {
        void WriteLog(string message);
    }
    interface IFormattableLogger : ILogger
    {
        void WriteLog(string format,params Object[] args);
    }
    class ConsoleLogger2 : IFormattableLogger
    {
        public void WriteLog(string message)//인터페이스
        {
            Console.WriteLine("{0} {1} DataeTime.Now.ToLocalTime()",message); 
        }
        public void WriteLog(string fotmat,params Object[] args)//클래스 재정의
        {
            String message = String.Format(fotmat,args);
            Console.WriteLine("{0} {1} DataeTime.Now.ToLocalTime()", message);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IFormattableLogger logger = new ConsoleLogger2();
            logger.WriteLog("the world");
            logger.WriteLog("{0} + {1} = {2}",1,2,3);

            
        }
    }
}
*/
interface Greet
{
    void greet();

}

interface Bye:Greet
{
    void bye();
}

class Greeting : Bye
{
    public void greet()
    {
        Console.WriteLine("Heelo");
    }
    public void bye()
    {
        Console.WriteLine("Bye");
    }
}

class Program
{
    static public void Main()
    {
        Greeting gt = new Greeting();
        gt.greet();
        gt.bye();
    }
}