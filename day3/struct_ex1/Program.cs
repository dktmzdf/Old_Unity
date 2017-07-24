using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace struct_ex1
{
    //구조체 사용자 정의 자료형
    //strcut 자료형 이름
    //{
    //  멤버 데이터
    //}
    //사용
    //자료형이름 변수
    //변수.멤버
    struct Hero
    {
        //내부를 접근할때 보호 수준이 있다(접근 권한)
        public int hp;
        public int mp;
        //c#기능도 넣을수 있다(메소드)
        public void init_data()
        {
            hp = mp = 100;//저장공간이 있는가?
        }//선언부 경우에는 저장공간이 없음

        public void print()
        {

            Console.WriteLine("aaa{0}bbb{1}", hp,  mp);
        }
    }//구조체 내부
    class Program
    {
        //구조체 외부   
        static void Main(string[] args)
        {
            /*
            Hero ironman = new Hero();
            ironman.hp = 100;
            ironman.mp = 100;*/
            /*
            Hero ironman
            ironman.hp = 100;
            ironman.mp = 100;*/


            //간접접근(저장공간을 만들고 해당 주소를 받음)
            Hero ironman = new Hero();//new Hero처럼 메모리 할당해주면 저장공간이 생기므로 함수사용가능해짐
            //Hero *ironman = (Hero *)malloc(sizeof(Hero));
            ironman.init_data();//내부 메서드, 내부 데이터를 변경
            ironman.print();//내부 메서드, 내부 데이터를 변경


            //직접접근
            //멤버를 직접 접근... 값세팅 -> 일반변수 처럼 사용됨
            Hero spiderman;
            spiderman.hp = 100;
            spiderman.mp = 100;
            spiderman.init_data();
            spiderman.print();
            
        }
    }
}
