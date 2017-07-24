using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam2
{
    class Program
    {
        static void PrintProfile(string name,string phone = "")
        {
            Console.WriteLine("Name:{0} phone:{1}",name,phone);
        }
        static void Main(string[] args)
        {
            PrintProfile(name: "박찬호",phone:"010-5444-4444");
            PrintProfile(phone: "010-333-33333", name: "박지성");
            PrintProfile("박세리", "010-1111-4111");
            PrintProfile("박상현", phone: "010-5682-2222");
            PrintProfile("수영");
        }
    }
}
