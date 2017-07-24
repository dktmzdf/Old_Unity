using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_2
{
    class Program
    {
        //C언어 메서ㅡ를 선언(형태를 정의하다 메모리 사용안함 메서드가 어떻게 작동되는지 로직만 작성) 이후에 사용
        //메서드 작성 순서도 중요헀음
        //메인 상단부에 메서드가 위치 메서드 로직이 비대화됨; 실제 메인로직의 수정이 어려움->메서드의 프로토 타입;
        //은 메서드를 선언ㅂ와 비슷하게 {}없이 재정의 ; 
        //static void methodB();
        //c# 메서드가 정의가 되어있으면,어느곳에서도든 호출이 가능함.
        //메서드 정의위치가 중요X, 메서드정의가 되어 있는가?
        //메서드 정의 위치는 중요하지 않다..
        //메서드의 프로토타입이 필요 없다.
        //중첩메서드 :  호출된 메서드 내ㅔ서 다른 메서드를 효출해서 사용할수 이싿.
        
        static void methodB()
        {
            methodA();//다른 메서드 호출ㅠ
            Console.WriteLine("B메서드임");
            methodA();
            Console.WriteLine("---------");
        }
        static void methodA()
        {
            Console.WriteLine("A메서드임");
        }
        static void Main(string[] args)
        {
            methodB();
            methodA();
        }
    }
}
