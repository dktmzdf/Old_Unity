using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class A
{
    
    public int m_a;
}

namespace var_ext_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int? b = null;
            Console.WriteLine(b);
            if (b.HasValue == false)
            {
                
                b = 123;
                Console.WriteLine("값을 세팅해야됨");
            }
            else
            {
                Console.WriteLine(b.Value);
                
            }

            var ad = 3.14f;
//var은 클래스도 인식할수 있음
//단점은 var은 전역적으로는 못씀(static같은거나 클래스로 매기기 난감함)
            Console.WriteLine(ad.GetType());
        }
    }
}
