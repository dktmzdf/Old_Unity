using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator
{
    class Program
    {
        static void Main(string[] args)
        {


        }
    }
}
/*
           //오칙연산(+,-,*,/,%)
           int orinum = 32;//int.Parse(args[1]);?
           int []num = new int[10];
           for (int i = 0; i < 10; i++)
           {
               num[i] = int.MaxValue;
           }
           int nNumSize = 2;//int.Parse(args[2]);?


           for (int i = 0; i < nNumSize; i++)
           {
               int temp=0;

               if (orinum > 0)
               {
                   if (i == 0) temp = orinum % 10;
                   else temp = num[i - 1] % 10;
               }
               else  if (orinum < 0)
               {
                   if (i == 0) temp = -(orinum % 10);
                   else  temp = -(num[i - 1] % 10);
               }

               num[i] = temp;

           }


           //대입
           int num2 = 333;
           //증감
           int hp =50;
           hp++;
           Console.WriteLine(hp);
           ++hp;
           hp--;
           --hp;
           //hp  += 10; hp = hp +10;
           //hp  /= 1-; hp  = hp/10;(0으로 나누어도안되고 값이 0을 나누게 하면 안됨)

   */
//비교    =>결과는 0,1 이다. => true;
//if(1) if(0)
// >,>=,<,<=,!=,==


//논리 &&(논리곱) ||(논리합) (~||!)(논리부정) - >값중에서 참거짓가지고 따짐=>논리체크
//      &          |  =>메모리 비트가지고 논리체크
//     교집합      합집합      여집합
//Exception
//(a > 10) && (a < 50) a = 34, a = 9
//(a == 1 ) && (a == 100) a = 34, a = 9
//!(a == 100 ) a=33;
//cf).
/*= 4;
          bool x,y;
          const bool Tvar = true;
          const bool Fvar = false;
          //Console.WriteLine(x + y);
          x = (a < 0);
          y = (b> 0);
          Console.WriteLine((a == 3) && (b==3));
          Console.WriteLine(x||y);
          Console.WriteLine(x);
          Console.WriteLine(y);

          Console.WriteLine(2*8 - 6 / 2);
          Console.WriteLine(2 * (8 - 6) / 2);
          Console.WriteLine(1 - 2 + 3);
          Console.WriteLine(1 - (2 + 3));

          //형변환 cast 연산자
          //=> 변수 앞에 () 넣고 자료형을 넣으면 강제로 형변환함;
          Console.WriteLine((float)(3 / 2));
          Console.WriteLine((float)3 / 2);
          Console.WriteLine((3 /(float) 2));
          int test = 1;

          Console.WriteLine(((float)3 / (float)2));
          //*/

//(a==5) || (a=7); (할당식은 참으로 간주)           
//삼항 연산자
/*
         //삼항 연산자
         //조건식의 값에 따라 계산식을 선택함
         //비슷한 문법적인 구조는 if - else
         //차이점:각 조건별 로직라인은 1줄로 제약
         //형식
         //값 ? 로직1 : 로직2
         //0,1 값 -> 값을 비교해서 참(1)일떄는 로직1 수행
                                   //거짓(0)일때는 로직2 수행
             string right = "정답";
             string wrong = "오답";
             bool value;
             value = true;
            
             String answer = value ? right : wrong;
             Console.WriteLine("값은 =>"+answer);

             value = false;

             answer = value ? right : wrong;
             Console.WriteLine("값은 =>" + answer);

            string answer2;
            value = true;
           
            answer2 = value? ("aaa"):("bbb");
            Console.WriteLine("값은 =>" + answer2);
            */

/*
       string num = "3.14";
       double dat = double.Parse(num);
       double dat2 = Convert.ToDouble(num);//데이터를 전문적으로 변경함
       Console.WriteLine(dat2);
       Console.WriteLine(dat2);
       int a = 33;
       string rest = Convert.ToString(a);

       Console.WriteLine(rest);*/
