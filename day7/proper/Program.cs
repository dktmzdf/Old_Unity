using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 멤버변수같이 보이지만 실제로는 메서드의 동작이다.
 * get, set 접근자로 로직을 작성한다.
 * 메서드타입으로 동작하기 때문에
 * static과 추상화 키워드를 쓸수 없다.
 * 내부적으로 메모리를 추가할당하지 않는다.(별도로 할당 안한다... )
 */
 class AA
{
    private int _m_a;//멤버변수

    public int m_a//get,set기능을 쓸 변수같아 보이는 메서드
                // 변수이름 = 메서드 이름
    {
        get
        {
            return _m_a;

        }
        set
        {
            _m_a = m_a;
        }
    }
}
/*
 * AA bb;
 * bb.m_a = 5;
 * {//메서드를 의미
 *      get=> 값을 넘겨준다
 *      {
 *      return 값이 필요
 *      }
 *      set=>변수에다 프로ㅓㅍ티를 통해 얻은 값을 대입한다.
 *      {
 *          값을 넣을 변수 = 프로퍼티이름을 넣음(해당 로직으로 얻은 값)
 *          
 *      }
 * }
 */
 /*
namespace proper
{
    class Birt0hdayInfo
    {
        private string name;
        private DateTime birthday;

        public string Name
        {
            get
            {
                return name;

            }
            set
            {
                name = value;
            }

        }

        public DateTime BirthDay
        {
            get
            {
                return birthday;
            }
            set
            {
                birthday = value;
            }
        }

        public int Age
        {
            get
            {
                return new DateTime(DateTime.Now.Subtract(birthday).Ticks).Year;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BirthdayInfo birth = new BirthdayInfo();
            birth.Name = "서현";
            birth.BirthDay = new DateTime(1991,6,28);

            Console.WriteLine("Name : {0}",birth.Name);
            Console.WriteLine("Birthday : {0}", birth.BirthDay);
            Console.WriteLine("age : {0}", birth.Age);

        }
    }
}
*/
/*
namespace proper
{
    class BirthdayInfo
    {
        private string name;
        private DateTime birthday;

        public string Name { get; set; }
        
        public DateTime BirthDay
        {
            get;set;
        }

        public int Age
        {
            get
            {
                return new DateTime(DateTime.Now.Subtract(birthday).Ticks).Year;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BirthdayInfo birth = new BirthdayInfo();
            birth.Name = "서현";
            birth.BirthDay = new DateTime(1991, 6, 28);

            Console.WriteLine("Name : {0}", birth.Name);
            Console.WriteLine("Birthday : {0}", birth.BirthDay);
            Console.WriteLine("age : {0}", birth.Age);

        }
    }
}*/
namespace proper
{
    class BirthdayInfo
    {
        
        public string Name { get; set; }
       
        public DateTime BirthDay
        {
            get; set;
        }

        public int Age
        {
            get
            {
                return new DateTime(DateTime.Now.Subtract(BirthDay).Ticks).Year;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BirthdayInfo birth = new BirthdayInfo()
            {
                Name = "서현",
                BirthDay = new DateTime(1991, 6, 28)
            };
            //생성자(맴버변수 세팅) {내부인자 (프로퍼티 세팅)}

            Console.WriteLine("Name : {0}", birth.Name);
            Console.WriteLine("Birthday : {0}", birth.BirthDay);
            Console.WriteLine("age : {0}", birth.Age);

        }
    }
}
