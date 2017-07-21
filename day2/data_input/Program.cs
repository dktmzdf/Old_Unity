
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_input
{
    class Program
    {
        
        static void Main(string[] args)
        {
             
            string inputDay = Console.ReadLine();
            
            switch (inputDay)
            {
                case "월요일":
                    Console.WriteLine("Monday");
                    break;
                case "화요일":
                    Console.WriteLine("Tuesday");
                    break;
                case "수요일":
                    Console.WriteLine("Wedneday");
                    break;
                case "목요일":
                    Console.WriteLine("Thursday");
                    break;
                case "금요일":
                    Console.WriteLine("Friday");
                    break;
                case "토요일":
                    Console.WriteLine("Saturday");
                    break;
                case "일요일":
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("잘못입력하셨습니다.");
                    break;
            }
            
            //요일 입력하면 해당 요일을 영어로 출력하는 프로그램 만들기

        }
    }
}
/*Console.WriteLine("입력값은"+inputnum) ;
            Console.WriteLine("입력값은" + int.Parse(inputnum));
            Console.WriteLine("입력값은" + Convert.ToInt32(inputnum));*/

