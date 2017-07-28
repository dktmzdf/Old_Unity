using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//해당 네임스페이스의 별명을 지어줌
using F = Fishing;
namespace Fishing
{
    class Fish
    {
        int num;
        string name;
        public Fish(string m, int n)
        {
            name = m;
            num = n;
        }

        public void print()
        {
            Console.WriteLine(name+" 몇마리 " + num + "낚았음");
        }
    }
}

namespace namespace_ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Fishing.Fish a = new Fishing.Fish("정어리",2);
            F.Fish b = new F.Fish("상어",10);
            //Fishing c = new Fishing("방어",2);
            
        }
    }
}
