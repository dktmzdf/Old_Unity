using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Date
{
    private int yy;
    int mm;
    int dd;
    public Date(int yy, int mm, int dd)
    {
        this.yy = yy;
        this.mm = mm;
        this.dd = dd;

    }
    //new Date(2017,07,26);//프로그래머가 생성자를 만들면
                           //시스템에서 제공되는  기본생성자(default construct)가 활성화가 안된다
    //사용자가 만든 디폴트 생성자
    public Date():this(2017,7, 27)
    {
        
    }
    public void GetDate()
    {
        Console.WriteLine("{0} 년도 {1}월 {2}일",yy,mm,dd);
    }
}


namespace class_ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            Date a = new Date();
            a.GetDate();
        }
    }
}

