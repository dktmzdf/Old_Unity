using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//일반화
//공통자료형  어떤자료형이 올수 있도록 기호화 한 키워드
//T  : template의 약어
//일반화 메서드
//함수에 사용되는 자료형을 일반화한 메서드
//리턴타입 메서드명 <T>(파라미터) //T형 변수
 




class Program
{

    static void Swap<T>(ref T a, ref T b)
    {
        T tmp;
        tmp = a;
        a = b;
        b = tmp;
    }
    
    static void Main(string[] args)
    {
        SwapTest1();
        SwapTest2();
    }

    static void SwapTest1()
    {
        int a = 21331;
        int b = 2;
        Swap<int>(ref a, ref b); 
        System.Console.WriteLine(a+"  "+b);
    }
    static void SwapTest2()
    {
        string a = "ㅁㅁㅁㅁㅁㅁ";
        string b = "ㅠㅠㅠㅠㅠㅠ";
        Swap<string>(ref a, ref b);
        System.Console.WriteLine(a + "   " + b);
    }
}
