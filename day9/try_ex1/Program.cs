using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class calc
{
    public void deivide(int x, int y)
    {
        int z;
        try
        {
            z = x / y;
            Console.WriteLine(z);
            //에러가 발생되면 그때 catch 구문 실행
            //강제로 예외상황 만들기
            if (x == 0) 
            {
                Exception e1 = new Exception("ㅇㅇ?");
                
                throw (e1);//상태에 맞추어서 에러코드를 날림
            }
        }catch(Exception e)//상황별 에러데이터가 들어감
        {
           
            Console.WriteLine(e.Message);
        }
    }
}

namespace try_ex1
{
    
    class Program
    {
        static void Main(string[] args)
        {
            calc c = new calc();
            c.deivide(5,3);
            c.deivide(30, 0);
            c.deivide(0, 30);

        }
    }
}
