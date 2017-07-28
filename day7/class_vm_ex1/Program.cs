using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//r가상 메서드, 오버라이딩
//기반 클래스의 메서드를 파생 클래스에서 변형(재정의)해서 사용하기 위한 방법
//형식
//1)부모 클래스
//메서드 virtual 키워드를 넣는다.
//권한 virtual 리턴타입 메서드 이름 (파라미터)
/*
 * {
 *      내부로직 구현
 *      
 * }//현재클래스는 이대로 사용하고
 * 파생클래스는 재정의 해서 사용
 * 2) 자식클래스는
 * 메서드에 override 키워드를 넣는다
 * 권한 override 리턴타입 메서드 이름(파라미터)
 * 
 * 참고)일반적인 virtual의 의미 가상(추상화) => 추상화 클래스할때 나옴
 *     )현재 구현이 안되고 파생클래스가 구현한다.
 *     )부모클래스는 정의만 내림(예측을 한다)
 *     )자식클래스가 해당 메소드를 재정의하는걸 요청함(재정의 할것이 없으면 (권한이 private면) 못함)
 *     )즉 protected와 public 만 가능 (부모 자식끼리 같은 권한을 가져야됨)
 *     )문법 구조도 같아야함(static 도 안됨)
 *     )기반클래스에서 정의한것을 자식클래스에서 다시 재정의 가능 =>virtual이 있어야 override가 있다.
 *     )virtual만 있으면 파생클래스에서 override가 되어있으면 오버라이드 된 메서드 실행
 *     )없으면 virtual로 된 메서드가 실행
 */ 

class parent
{
    public virtual void ShowData()
    {
        Console.WriteLine("안녕");
    }
}
class child : parent
{
    public void SetData()
    {
        Console.WriteLine("--------");
    }
    public override void ShowData()//overried를 안붙여도 되긴하지만 내부의 구조가 달라져버림(부모 ShowData를 버림)
    {
        Console.WriteLine("안녕^*&@^$#@^(#^!(*&");
    }
}

class chile2 : child
{
    //public override void SetData()//에러남
    //{
    //}

    public override void ShowData()
    {
        Console.WriteLine("안녕^*&!!!!!!!!!!!!!!(*&");
    }
}

class Program
{
    static void Main(string[] args)
    {
        parent p = new parent();
        p.ShowData();
        child c = new child();
        c.SetData();
        c.ShowData();

    }
}

