using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BookData
{
    public string  m_title;
    public int     m_price;
    public BookData(string t, int p)
    {
        m_title = t;
        m_price = p;
    }
    public BookData(BookData temp)//저장공간을 만들것? 아님
    {
        this.m_title = temp.m_title;//받은 자료형을 수정 x 값을 넣어줌
        this.m_price = temp.m_price;
        //temp 내부의 데이터의 변경 x
    }
    public void print()
    {
        Console.WriteLine("제목 : " + m_title);
        Console.WriteLine("가격 : " + m_price);
    }
   
}

class Program
{
    static void Main(string[] args)
    {
        BookData source = new BookData("트와일라잇",19800);
        source.print();
        //BookData copy = new BookData();
    }
}

