using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
class calc1
{
    public int x;
    public calc1(int a, int b)
    {
        x = a + b;
    }

}
class calc2 : calc1
{
    //상속시 원본의 생성자를 호출할때 base키워드를 쓴다
    public int y;
    public calc2(int c, int d):base(c,d)
    {
        
    }
}

namespace class_con_base
{

    
    class Program
    {
        static void Main(string[] args)
        {
            calc2 cx = new calc2(1, 2);
            Console.WriteLine(cx.x);
        }
    }
}

*/

class A
{
    public int a = 3;

}
class B : A
{
    public int a = 100;
    public void print()
    {
        Console.WriteLine(a);
              Console.WriteLine(base.a);
    }
}

class Program
{
    static void Main()
    {
        B b = new B();
        b.print();
    }
}