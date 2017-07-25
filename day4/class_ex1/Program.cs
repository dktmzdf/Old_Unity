using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_ex1
{
    //객체 (데이터와 메서드)
    //형식
    /*
     * class 객체명
     * {
     *      정보(자료형)선언
     *      //멤버변수 인스턴스 변수
     *      기능 선언
     *      //멤버 메서드 인스턴스 메서드
     * }
     * 
     */
    class Hero
    {
        //권한 세팅
        //사용법 권한 리턴타입 메서드명 - 메서드
        //권한 타입 변수명 - 변수
        public int mp;
        public int hp;
        public int lv;
        public bool alive;
        public void initial()
        {
            lv = 1;
            hp = mp = 10;
            alive = true;
        }
        public void now_Dead()
        {
            hp = 0;
            mp = 0;
            alive = false;
        }
        public void now_leveup()
        {
            lv += 1;
            hp += 10;
            mp += 5;
            alive = true;
        }
        public void showstate()
        {
            Console.WriteLine("lv : "+ lv);
            Console.WriteLine("hp : " + hp);
            Console.WriteLine("mp : " + mp);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Hero link;
            //내부의 데이터를 사용할때 .연산자 사용
            //변수.내부 정보

            //멤버 에러 발생   클래스 영역을 벗어난 상태에서 내부 정보를 사용할때는 
            //그상황에 맞는 권한을 설정

            //객체변수의 에러발생
            //객체의 선언과 사용은 변수의 형태와는 다르다
            //변수  크기와 형태가 정해져있음
            //선언과 도시에 바로 사용할 메모리가 만들어지고 바로사용 가능
            //객체정보를 직접 접근
            //클래스 변수 : 크기와 형태가 제각각
            //별도로 메모리를 할당해주어야함
            //메모리 할당 키워드 new
            //해당 자료형크기만큼 할당
            //new 자료형() => 비슷한 뉘앙스 malloc
            //new - delete                  malloc - free
            //객체 메모리를 얻고 주소 기준으로 접근 
            //간접접근 => 클래스는 간접접근 방식(주소로 접근)
            //하지만 주소 자료형을 숨겨놓았기 때문에
            //겉으로 보면 직접접근처럼 보임
            link = new Hero();
            link.hp = 20;
            link.showstate();
            link.initial();
            link.now_leveup();
            link.showstate();
            link.now_leveup();
            link.showstate();
            link.now_Dead();
            link.showstate();
            link = null;
            //delete()? =>C#, java 메모리관리를 시스템에서 알아서 해줌
            //따라서 delete ㄱ문이 불필요
            //가비지 콜렉션

        }
    }
}
//객체:언어로 표현되는 대상 또는 사물 전체
//class:표현 사용하기전 정의된 객체