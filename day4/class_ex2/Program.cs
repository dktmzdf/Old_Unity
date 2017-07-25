using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//생성자 소멸자
//객체를 만들면 메모리 공간 할당
//c - malloc => 공간을 할당이 되지만 내부에는 쓰레기 값으로 가득참
//생성자 -> 객체의 생성 이후에 내부의 데이터를 초기화를 하기위해 필요한 호출되는 메서드
//자동 혹은 수동으로 호출됨(객체를 만들때만 쓸수 있음)
//객체가 만들어진 이후에는 생성자는 호출이 안된다.

namespace class_ex2
{
    class Cat
    {
        public Cat()
        {
            Name = "";
            Color = "";
        }

        public Cat(string _Name, string _Color)
        {
            Name = _Name;
            Color = _Color;
        }

        public void Meow()
        {
            Console.WriteLine("{0} : 야옹", Name);
        }

        ~Cat()
        {
            Console.WriteLine("{0} : 잘가",Name);
        }
        public string Name;
        public string Color;
        
    }
   
    class Program
    {
        static void Main(string[] args)
        {
            Cat kitty = new Cat("하얀색", "키티");
       
            kitty.Meow();
            Console.WriteLine("{0} : {1}", kitty.Name, kitty.Color) ;

            Cat nero = new Cat("검은색", "네로");
         
            nero.Meow();
            Console.WriteLine("{0} : {1}", nero.Name, nero.Color);
            
        }
    }
}
