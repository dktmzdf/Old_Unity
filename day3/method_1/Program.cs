using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_1
{
    //메서드: 프로그램 내에서 결과를 도출하는 로직을 특정한 이름으로 정의한것.
    //형식
    //C returntype 메서드명(파라미터)
    //C# 접근권한 변수타입 returntype 메서드명(파라미터)
    //     public   static   int        add   (int x, int y)
    //C# 언어의 메서드는 class 내에서 사용한다.
    class Program
    {
        static void aaa()
        {

        }

        static void Main(string[] args) //static 자료타입이 정적
                                        //종료가 되기전 까지 메모리에서 계속 존재한다.
                                        //호출하는 메서드는 해당영역의 자료타입에 맞추어야 한다.
        {
            
        }
        /*
         * int num1, num2, num3;
            double dnum1, dnum2, dnum3;
            num1 = 123;num2 = 456;num3 = 0;
            dnum1 = 123.0; dnum2 = 456.0; dnum3 = 0;
            //두수를 더하는 기능을 새로 정의
            num3 = add_data(num1, num2);//함수의 호출은 C C# 동일
            dnum3 = add_data(dnum1, dnum2);//함수의 호출은 C C# 동일
            string str = add_data("dd", "cc");
            Console.WriteLine(num3);
            Console.WriteLine(dnum3);
            Console.WriteLine(str);
            
        int numdata(int x)
        {
            int ret = x;
            return ret;
        }
        void main2()
        {
            numdata(3);
        }


        //public, protected, private
        public static int add_data(int a, int b)//넘겨지는 자료형이 어디에서 쓰이는가?
        {
            int ret = a + b;
            return ret;
        }
        //실수 문자를 더함;
        public static double add_data(double a, double b)
        {
            double ret = a + b;
            return ret;
        }
        public static float add_data(float a, float b)
        {
            float ret = a + b;
            return ret;
        }
        public static string add_data(string a, string b)
        {
            string ret = a + b;
            return ret;
        }
        //함수의 중복정의 (overload)
        //컴파일러가 메서드를 인식할때 이름으로 인식하는가 파라미터로 인식하는가
        //C언어는 이름으로 인식 ->메서드 이름은 중복X =>unique
        //C# 언어는 파라미터 타입을 가지고 인식.
        //파라미터가 다르다면 같은 이름의 메서드를 사용해도 무방
        //같은ㅇ ㅣ름의 같은 파라미터는 한개만 됨*/
    }
}
