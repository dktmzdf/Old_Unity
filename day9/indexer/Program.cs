using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//인덱서는 객체내의 배열을 접근(access)해서 클래스를 배열처럼 취급하는 방법
//기본 문법 베이스는 속성(property,get/set)과 유사
//특징:
/*
 * 배열을 접근하듯이 []기호를 사용함
 * this 키워드를 사용한다.
 * get / set 접근자로 표현
 * 멤버변수처럼 보이지만 내부적으로 메서드로 동작한다.

 */
/*
 * 형식
 * 멤버자료형으로 배열이 필요.
 * 접근 권한 리턴타입 'this'키워드 [index]
 * {
 *      get/set;
 *      }
 * 
 */
class K
{
    private int[] array = new int[4];
    public int this[int i]//해당키워드를 통해 내부정보 접근
    {
        get
        {
            return array[i];//get객체
        }
        set
        {
            array[i] = value;//set 객체
        }
    }
}
namespace indexer
{
    class MyList
    {
        private int[] array;
        public MyList()
        {
            array = new int[3];
        }
        public int this[int index]
        {
            get
            {
                return array[index];

            }
            set
            {
                if (index>= array.Length)
                {
                    Array.Resize<int>(ref array, index + 1);
                    Console.WriteLine("Array Resized : {0}", array.Length);
                }
                array[index] = value;
            }
        }
        public int Length
        {
            get { return array.Length; }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            MyList list = new MyList();
            for(int i=0; i<5; i++)
            {
                list[i] = i;

            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(list[i]);

            }

        }
    }
}
