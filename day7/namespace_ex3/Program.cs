using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tokyo;
using Tokyo.Tosima;

namespace Tokyo
{
    class Tokyotower
    {
        public void print()
        {

            Console.WriteLine("도쿄타워입니다.");
        }
    }
    namespace Tosima
    {
        class sunshine
        {
            public void print()
            {
                Console.WriteLine("샤인60");
            }
        }
    }
        
    
}

class Program
{
    static void Main(string[] args)
    {
        //생성이 너무 힘듬
        //생성을 쉽게 하는방법
        //s네임스페이스를 미리 등록=>알아서 내부의 데이터에 접근할수있다.
        //using=> 해당 namespace영역에 있는 다양한 클래스나 메서드나 자료형을 쓰겠다.
        //using namespace;//using 다음에는 네임스페이스만 올수 있다.(클래스가 오는 자리가 없ㅈ다)
        //프로그램시작전에 먼저 선언해 준다.
        //내가 선언한 네임스페이스내의 영역=>클래스나 메서드만
        //내부에 있는 네임 스페이스는 안보여줌

        Tokyo.Tokyotower tower = new Tokyo.Tokyotower();
        Tokyo.Tosima.sunshine sn = new Tokyo.Tosima.sunshine();

        Tokyotower tower1 = new Tokyotower();
        sunshine sn1 = new sunshine();
        tower.print();
        sn.print();
    }
}
