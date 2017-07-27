using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_ex1
{
    class Base
    {
        protected string Name;
        public Base(string Name)
        {
            this.Name = Name;
            Console.WriteLine("{0}.Base()",this.Name);
        }

        ~Base()
        {
            Console.WriteLine("{0}.~Base()", this.Name);
        }
        public void BaseMethod()
        {
            Console.WriteLine("{0}.BaseMethod()", this.Name);
        }
    }
    sealed class Derived :Base
    {
        
        public Derived(string Name) : base(Name)//(부모)this생성자 호출
        {
            this.Name = Name;
            Console.WriteLine("{0}.Derived()", this.Name);
        }

        ~Derived()
        {
            Console.WriteLine("{0}.~Derived()", this.Name);
        }
        public void DerivedMethod()
        {
            Console.WriteLine("{0}.DerivedMethod()", this.Name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Base a = new Base("a");
            a.BaseMethod();

            Derived b = new Derived("b");
            b.BaseMethod();
            b.DerivedMethod();
        }
    }
}
