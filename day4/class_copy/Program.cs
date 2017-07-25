using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MyClass
{
    public int data1;//생성자 x
    //컴파일러에서 생성자를 만들고 값을 0으로 초기화
    public int data2;//생성자 x
    public MyClass DeepCopy()
    {
        MyClass newCopy = new MyClass();//할당
        //클래스 내부에 클래스가 있는 형태
        /*
         |   data1               |MyClass
         |   []clonedata()       |
         |   [|data1   |newCopy] |
         */

        newCopy.data1 = this.data1;
        newCopy.data2 = this.data2;
        return newCopy;
    }
}

namespace class_copy
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass source;
            MyClass copy;
            source = new MyClass();//해당 클래스 크기 만큼 공간을 만들고 생성자를 호출
            Console.WriteLine("내부값 : " + source.data1);
            source.data1 = 10;
            //copy = source;//int a=3; int b=a;가 아니라 영역을 공유하게됨=?소스가 가르키는 데이터 영역의 정보를 copy에도 알려줌
            //copy.data1 = 123;//copy가 가르키는 영역에 내부 데이터를 바꿈
            //Console.WriteLine(source.data1);
            copy = source.DeepCopy();
            copy.data1 = 123;
            Console.WriteLine(source.data1);

        }
    }
}
