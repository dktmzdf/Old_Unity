using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_ex2
{
    class Cat
    {
        public Cat()
        {
            Name = "";
            Color = "";
        }

        public Cat(string _Name, string _Color)
        {
            Name = _Name;
            Color = _Color;
        }

        public void Meow()
        {
            Console.WriteLine("{0} : 야옹", Name);
        }

        ~Cat()
        {
            Console.WriteLine("{0} : 잘가",Name);
        }
        public string Name;
        public string Color;
        
    }
   
    class Program
    {
        static void Main(string[] args)
        {
            Cat kitty = new Cat("하얀색", "키티");
       
            kitty.Meow();
            Console.WriteLine("{0} : {1}", kitty.Name, kitty.Color) ;

            Cat nero = new Cat("검은색", "네로");
         
            nero.Meow();
            Console.WriteLine("{0} : {1}", nero.Name, nero.Color);
            
        }
    }
}
