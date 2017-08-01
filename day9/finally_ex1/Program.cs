using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finally_ex1
{
    class Program
    {
        static int Divide(int divisor,int  dividend)
        {
            try
            {
                Console.WriteLine("start");
                return divisor / dividend;

            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("divide throw error");
                throw e;
            }
            finally
            {
                Console.WriteLine("Divide end");
            }
        }
        static void Main(string[] args)
        {
            try
            {
                Console.Write("계수를 입력하세요 : ");
                string temp = Console.ReadLine();
                int divisor = Convert.ToInt32(temp);


                Console.Write("계수를 입력하세요 : ");
                temp = Console.ReadLine();
                int dividend = Convert.ToInt32(temp);
                Console.WriteLine("{0}/{1} = {2}",divisor,dividend,Divide(divisor,dividend));
            }
            catch(FormatException e)
            {
                Console.WriteLine("에러 : " + e.Message);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("에러 : " + e.Message);
            }
            finally
            {
                Console.WriteLine("program end");
            }

        }
    }
}
