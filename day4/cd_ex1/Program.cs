using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Book
{
    public int price;
    public int num = 0;
    public string author;
    public string title;
    public Book()
    {
        price = num = 0;
        title = "";
    }

    public Book(string t,string a, int p)
    {
        price = p;
        author = a;
        title = t;
    }
    public void printbook()
    {
        Console.WriteLine("제목 : " + title);
        Console.WriteLine("작가 : " + author);
        Console.WriteLine("가격 : " + this.price);//현재 활성화된 내 객체를 참조함
        //클래스 키워드 
        //this.클래스명-> 현재 내가 사용하고 있는 클래스을 쓴다
        //객체를 제어한다
        Console.WriteLine("주문량 : " + num);
        Console.WriteLine("총합 : " + num * price);
    }
}

namespace cd_ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("해리포터","조엔 롤링",34000);
            book.num = 10;
            book.printbook();
        }
    }
}
