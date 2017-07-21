using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grade
{
    class Program
    {
        enum Animal : Int32 { mouse,cat,bird,dog=100,pig=200,linon};

        static void Main()
        {
            Animal a;
            a = Animal.dog;
            Console.WriteLine(Animal.bird);
            Console.WriteLine(Animal.pig);
            Console.WriteLine(Animal.bird);
            Console.WriteLine((int)Animal.bird);
            Console.WriteLine((int)a+(int)Animal.bird+a);


        }
    }
}
/*  const int nGrade = 89;
            const int n_PGrade = 10;
            if (nGrade >= 90)
            {
                Console.WriteLine("점수는 A");
               
            }
            else if (nGrade >= 80)
            {
                Console.WriteLine("점수는 B");
              
            }
            else 
            {
                Console.WriteLine("점수는 C");
              
            }
            
            switch ((nGrade - (nGrade%10)) / 10)
            {
                case 10:
                case 9:
                    Console.WriteLine("점수는 A");
                    break;
                case 8:
                    Console.WriteLine("점수는 B");
                    break;
                
                default:
                    Console.WriteLine("점수는 C");
                    break;*/
//상수
//변수 선언과 비슷하지만 앞에 const키워드를 붙인다.
//생성과 동시에 초기화
//생성후 초기화 안됨됨
//생성후 값의 변경 안됨

//열거
//멤버변수별로 자동으로 값이 세팅되는자료형
//형식
//enum  자료형이름 {파라미터(키워드) } 해당 키워드에 값이 자동으로 세팅된다.;
//0부터 세팅됨
//변수생성
//열거자료형 변수
//변우세 값을 세티
//변수 = 열거평,파라미터, 파라밑터가 가르키고 있는 숫자값이 변수에 들어감
/*
GameState state;//변수
state = GameState.Load;//세팅
Console.WriteLine(state);//정한 이름값이 나옴
switch (state)
{
    case GameState.Load:
        Console.WriteLine("Load");
        break;
    case GameState.Game:
        Console.WriteLine("Load");
        break;
    case GameState.Option:
        Console.WriteLine("Load");
        break;

}
*/
