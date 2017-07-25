using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_exx2
{
    class Temp
    {
        //접근권한 클래스 내부에서는 모든 데이터의 접근이 가능하다
        //하지만 클래스 외부에서는?
        //만약 현재 클래스를 기준으로 기능을 추가했다면
        //기능 추가한 클래스는 기반 클래스의 자료형을 쓸수 있는가?
        //public     private     protected
        //외 o        x           x(해당클래스를 기반으로 =>기능 추가된 클래스는 접근이 가능함 )=>상속
        //내부는 전부 가능
        //oop 특징 - 캡슐화 은닉화.....상속, 다형성
        public int a;
        private int b;
        protected int c;
        int d;//아무것도 안쓰면 private 속성을 가진다.
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
