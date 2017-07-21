using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variable2
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = 'a';//unicode nbyte(1,2) //cf c utf8 =>1byte
            char b = '가';
            char c = '飛';
            Console.WriteLine(a +" "+ b + " "+c);
            string strdata = "안녕하세요^^";
            //char* strdata2 = "안녕하세요";
            Console.WriteLine(strdata);
            strdata = "123";
            Console.WriteLine(strdata);
            int numdata = int.Parse(strdata);
            Console.WriteLine(numdata);
            strdata = "3.14";
            float numdata2 = float.Parse(strdata);
            Console.WriteLine(numdata2);
            //계산
            //수치데이터 - > 문자로 바꾸어야
            float result = 123.456f;//가상으로 얻은 결과
                                    //문자열화
            //1)
            string strd = result.ToString();
            Console.WriteLine(strd);
            
            //2)
            //""문자열인데 데이터는 없음 (즉 널 문자열)
            string strd2 = "" + result;
            Console.WriteLine(strd2);

        }
    }
}
