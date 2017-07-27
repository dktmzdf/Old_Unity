using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_as
{
    class Mammal
    {
        public void Nurse()
        {
            Console.WriteLine("Nurse()");
        }
    }
    class Dog: Mammal
    {
        public void Bark()
        {
            Console.WriteLine("Bark()");
        }
    }
    class Cat : Mammal
    {
        public void Meow()
        {
            Console.WriteLine("Meow()");
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {/////////////////////////////
            Mammal test1 = new Mammal();
            Dog test2 = new Dog();

            if (test1 is Dog) Console.WriteLine("pass test1");//x
            if (test2 is Mammal) Console.WriteLine("pass test2");//o
            /////////////////////////////
            Mammal mammal = new Dog();
            Dog dog;

            
         
            if (mammal is Dog)
            {
                dog = (Dog)mammal;
                dog.Bark();
            }
            //////////////////////////////////////////////////////////////////////////////
            Mammal mammal3 = new Mammal();//이렇게 되면 as로 자식클래스로 바꿀수가 없음
                   
            Cat test3 = mammal3 as Cat;
            Cat test4 = new Cat();

            Mammal de = test4 as Mammal;
            if (test3 != null) test3.Meow();//x
            if(de!=null) Console.WriteLine("pass test4");//o
            //////////////////////////////////////////////////////////////////////////////
            Mammal mammal2 = new Cat();
            

            Cat cat = mammal2 as Cat;
            if (cat != null)
                cat.Meow();

            Cat cat2 = mammal as Cat;
            if (cat2 != null)
                cat2.Meow();
            else
                Console.WriteLine("cat 2 is not a Cat");

        }
    }
}
//is:자료형 체크(맞으면 true 틀리면 false)
//    -
//as:자료형 강제 변환(변환 실패하면 NULL값 줌(받는걸 끊어줘서 오작동을 막음))
//    -