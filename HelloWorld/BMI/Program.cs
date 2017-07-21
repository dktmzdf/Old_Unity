using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            string sGender = "남자";
            double dWeight;
            double dTall;
            double dResult;

            if (sGender != "남자")
            {
                dTall = 173;
                dWeight = 80;
                dTall = dTall / 100;
                dResult = dWeight / (dTall * dTall);
                if (dResult <=18.5)
                {
                    Console.WriteLine(dResult);
                    Console.WriteLine("저체중");

                }
                else if(dResult < 23 && dResult > 18.5 )
                {
                    Console.WriteLine(dResult);
                    Console.WriteLine("보통");
                }
                else if (dResult < 25 && dResult > 23.0)//18.5 < 
                {
                    Console.WriteLine(dResult);
                    Console.WriteLine("과제중");
                }
                else if (dResult < 30 && dResult > 25.0)//18.5 < 
                {
                    Console.WriteLine(dResult);
                    Console.WriteLine("위험체중");
                }
                else if (dResult < 40 && dResult > 30)//18.5 < 
                {
                    Console.WriteLine(dResult);
                    Console.WriteLine("비만1");
                }
                else if (dResult > 40.0)//18.5 < 
                {
                    Console.WriteLine(dResult);
                    Console.WriteLine("비만2");
                }
            }
            else
            {
                dTall = 173;
                dWeight = 80;
                dTall = dTall / 100;
                dResult = dWeight / (dTall * dTall);
                if (dResult <= 18.5)
                {
                    Console.WriteLine(dResult);
                    Console.WriteLine("저체중");

                }
                else if (dResult < 23 && dResult > 18.5)
                {
                    Console.WriteLine(dResult);
                    Console.WriteLine("보통");
                }
                else if (dResult < 25 && dResult > 23.0)//18.5 < 
                {
                    Console.WriteLine(dResult);
                    Console.WriteLine("위험체중");
                }
                else if (dResult < 30 && dResult > 25.0)//18.5 < 
                {
                    Console.WriteLine(dResult);
                    Console.WriteLine("비만1");
                }
                else if (dResult < 40 && dResult > 30)//18.5 < 
                {
                    Console.WriteLine(dResult);
                    Console.WriteLine("비만2");
                }
                else if (dResult > 40.0)//18.5 < 
                {
                    Console.WriteLine(dResult);
                    Console.WriteLine("비만3");
                }
            }
        }
    }
}
