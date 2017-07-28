using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overriding_ex1
{

    class ArmorSuite
    {
        public virtual void Initialize()
        {
            Console.WriteLine("Armored");
        }
    }

    class IronMan : ArmorSuite
    {
        public override void Initialize()
        {
            base.Initialize();
            Console.WriteLine("이온포");

        }
    }

    class WarMachine : ArmorSuite
    {
        public override void Initialize()
        {
            base.Initialize();
            Console.WriteLine("기관포");
            Console.WriteLine("로켓");

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("new Armored");
            ArmorSuite armorsuite = new ArmorSuite();
            armorsuite.Initialize();

            Console.WriteLine("mew Ironman");
            ArmorSuite ironman = new IronMan();
            ironman.Initialize();

            Console.WriteLine("new WarMachine");
            ArmorSuite warmachine = new WarMachine();
            warmachine.Initialize();
        }
    }
}
