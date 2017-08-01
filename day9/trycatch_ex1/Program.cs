using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//예외처리(Exception)
//=> 프로그램 실행중에 일어나게 되는 오류를 말하며.
//이러한 오류를 대응하는 코드를 예외처리라고 한다.

//try-catch-throw-finally
//try : 예외가 일어날지도 모르는 영역을 블록화 시키기
//catch : 예외(오류)가 났을때. 오류의 종류와 처리를 담당하는 부분
//finally : 예외와 관계없이 처리되는 부분
//throw : 의도적으로 예외 상황을 만들어서 강제로 catch문을 실행하게 만드는것
/*
 * try
 * {
 *      //오류가 날지도 모르는 부분
 *      
 *      //예외상황을 만들때
 *      throw 예외코드://
 * }
 * catch(예외 인식)
 * {
 *      예외상황이 발생했을때 처리
 * }
 * finally
 * {
 *      예외가 있던없던 처리
 * }
 */ 
namespace trycatch_ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(arr[i]);


            }
            Console.WriteLine("종료");
        }
    }
}

