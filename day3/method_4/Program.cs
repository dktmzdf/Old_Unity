using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//int numd = 33;

namespace method_4
{
    class Program//형태를 정한것이지 메모리가 만들어 진건 아님
    {
        static int numdata = 33;//변수가 있음 근데 저장공간이 없어 33세팅이 안됨

        static void var_data()
        {
            int a = 123;
            int b = 486;
            b += a;
        }

        static void Main(string[] args)
        {
            //구체화된거만 가져다 쓸수있음
            int aaa;//구체화 되어있고 메모리 공간이 있음 
            var_data();
            Console.WriteLine(numdata);
            var_data();
            var_data();
            var_data();
            var_data();
            var_data();
            var_data();

        }
    }
}
/*
 * 메서드내에서 만드는 자료형들은 일반적으로 지역 변수라 부른다.
 * 지역변수: 특정 영역 안에 만들어진 변수로 해당 영역을 벗어나면 변수는 자동으로 없어진다
 * 
 * cf) static: 정적
 * 메모리공간의 정적 -> 메모리 공간을 만들고 해당공간을 재사용한다.
 * static 변수        -> 호출1                                             ->호출2
 * 공간을 생성         값의 변경                                           ->반환안한 공간을 재사용
 * 값세팅            해당영역의 변수                                       초기화 세팅은 하지 않음
 *                  메서드는 저장공간을 밭환하나                           값의 변경은 가능
 *                  정적 자료형은 저장공간을 반환 안함
 *                  초기화가 된경우 다시 초기화를 하지 않음
 * 결론: 지역변수처럼 만들어지나 -> 내부형태나 사용은 전역변수처럼 사용할수 있다.
 * 사용처: 어디에서 사용을 하는가
 * main 루틴이 존재하는경우 static 변수를 사용해도 사용안해도 무방
 * main 루틴이 존재하지 않는경우
 * ->class 나 struct 만 있는 경우 main()이 없는 경우는 전역변수를 만들수 없다
 * ->프로그램에서 데이터가 끝까지 유지가 안된다.(상황에따라 다 삭제가됨)
 * static 기호를 통한 변수를 만들어서 전역변수처럼 사용한다
 * main루틴외 공간에서 전역자료형을 만드는 방법 전역변수를 
 * */