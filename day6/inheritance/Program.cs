using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
namespace inheritance
{

    //상속 : 특정클래스를 기반으로 기능이 확장된 새로운 클래스를 만드는것
    //형식 class : 기반 클래스 (기반클래스가 미리 정의가 되어ㅜ있어야함)

    class Book
    {
        public string title;
        public string genre;
        public void printBook()
        {
            Console.WriteLine("제목: " + title);
            Console.WriteLine("장르: " + genre);
        }
    }
    class Novel: Book
    {
        public string writer;
        public void printNovel()
        {
            printBook();
            Console.WriteLine("저자: " + writer);
        }
        
    }
    class Magazine : Book
    {
        public int day;
        public void printMag()
        {
            printBook();
            Console.WriteLine("발매일 " + day + " 일 ");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Book myBook = new Book();
            myBook.title = "C#강의";
            myBook.genre = "컴퓨터";
            myBook.printBook();

            Novel nov = new Novel();
            nov.title = "개미";
            nov.genre = "판타지";
            nov.writer = "베르나르";

            Magazine mgz = new Magazine();
            mgz.title = "마이크로소프트웨어";
            mgz.genre = "컴퓨터";
            mgz.day = 20;
            nov.printNovel();
            Console.WriteLine("");
            mgz.printMag();
        }
    }
}
*/

class Base
{
    private string var1 = "프리빗형 변수";
    protected string var2 = "프로텍티드형 변수";//protected는 
    public string var3 = "퍼블릭형 변수";
    public void BaseMathode()
    {
        Console.WriteLine("기반 클래스 메서드임");
    }
}

class Delivery : Base
{
    //
    protected string var4;
    public void SetData(string sdata)
    {
        var2 = sdata;
        var4 = var2;
    }
    public void SubMathode()
    {
        Console.WriteLine(var2);
        Console.WriteLine("파생 클래스 메서드임");
    }
}

class Sub2: Delivery
{
   public void AAA()
    {
        var2 = "기반 클래스에서 protected를 가지면 파생의 파생을 해도 protected가 됨";
    }
}


//자료형앞 권한 제한 형식

class nogive
{
    static int a;
    public int num;
}
sealed class giveme : nogive
{
    
}
/*
class veerygive : giveme
{

}*/

class Program
{
    static void Main()
    {
        Delivery psub = new Delivery();
        psub.SetData("상속받은 객체의 속성은 ?");
        psub.BaseMathode();
        psub.SubMathode();

    }
}