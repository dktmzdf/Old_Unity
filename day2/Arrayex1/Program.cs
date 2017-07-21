using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Arrayex1
{
    class Program
    {
        static void Main(string[] args)
        {

            //FileStream fsa = File.Create("a.txt");
            //FileInfo file = new FileInfo("b.txt");
            //FileStream fsb = file.Create();

            //fsa.Close();
            //fsb.Close();
            //File.Copy("a.txt", "c.txt");
            //FileInfo dst = file.CopyTo("d.txt");
            /*
            int[] num;
            int[,] num3;
            int[,,] num4;
            num = new int[2];
            num3 = new int[2, 3];//[][]
            num4 = new int[2, 3, 4];//[][][]
            for (int i=0; i<2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(" " + num3[i,j]);
                }
                Console.WriteLine(" ");
            }


            string inputValue1 = Console.ReadLine();
            string inputValue2 = Console.ReadLine();

            int count1 = Convert.ToInt32(inputValue1);
            int count2 = Convert.ToInt32(inputValue2);


            int[,] num5 = new int[count1,count2];
            for (int i = 0; i < count1; i++)
            {
                for (int j = 0; j < count2; j++)
                {
                    Console.Write(" " + num5[i, j]);
                }
                Console.WriteLine(" ");
            }
            int[] arrdata = new int[5];
            Console.WriteLine(arrdata.Length);//배열의 갯수
            int[,,] arrdata2 = new int[3,4,5];
            Console.WriteLine(arrdata2.Length);//배열의 갯수
            */

            int DataCount = 0,DataCol=0;
            char delimiterChar = ',';
            double[,] dData;

            string path = @"C:\Users\KICT-06\Desktop\Unity/data_large.txt";
            string line;
            FileInfo DataFile = new FileInfo(path);
            
            if (DataFile.Exists)
            {
                int i=0, j=0;
                StreamReader readDataLine = new System.IO.StreamReader(path);
                line = readDataLine.ReadLine();
                DataCol = Convert.ToInt32(line);
                line = readDataLine.ReadLine();
                DataCount = Convert.ToInt32(line);
                dData = new double[DataCount, DataCol];
                
                while ((line = readDataLine.ReadLine()) != null)
                {
                    string[] tempString;
                    tempString = line.Split(delimiterChar);
                    for(j=0;j< DataCol; j++) {
                        dData[i, j] = Convert.ToDouble(tempString[j]);
                    }
                    j = 0;
                    i++;
                }
                Console.WriteLine(dData[0,0]);
                Console.WriteLine(dData[1, 0]);
                Console.WriteLine(dData[2, 0]);
                readDataLine.Close();
                double tempValue=0;
                for (i = 0; i < DataCount; i++)
                {
                    for (j = 0; j < DataCol; j++)
                    {
                        tempValue += dData[i, j];
                    }
                   
                }
                Console.WriteLine(tempValue);
            }
            else
            {
                Console.WriteLine("존재하지 않습니다.");
            }
            
            
        }
    }
}
/*
         //배열 array
         //같은 형태의 여러개의 자료형을 하나의 이름으로 정의해서 사용는것
         //int[] a = new int[5];
         //1.배열형 변수선언 
         //2.개수나 값의 초기화
         int[] num;//1 데이터형 배열명
         num = new int[5];//2 초기화 new 데이터형[개수] : =>배열변수에 할당.
         //num.Initialize(0);
         //num[0] = 1;
         //num[1] = 2;
         //num[2] = 3;
         //num[3] = 4;
         //num[4] = 5;
         for (int i=0; i< 5; i++)
         {
             Console.WriteLine("배열->"+num[i]);
         }

         //int []num2 = new int[5] {1,2,3,4,5};
         int[] num2 = { 1, 2, 3, 4, 5 };
         for (int i = 0; i < 5; i++)
         {
             Console.WriteLine("배열->" + num2[i]);
         }

         string[] str = new string[5];
         for (int i = 0; i < 5; i++)
         {
             Console.WriteLine("배열->" + str[i]);
         }
         float[] Fnum = { float.MaxValue,float.MinValue,float.MaxValue + float.MinValue,float.Epsilon};

         for (int i = 0; i < 4; i++)
         {
             Console.WriteLine("배열->" + Fnum[i]);
         }
         double[] Dnum = { double.MaxValue, double.MinValue, double.MaxValue + double.MinValue, double.Epsilon };

         for (int i = 0; i < 4; i++)
         {
             Console.WriteLine("배열->" + Dnum[i]);
         }
         decimal [] Denum = { decimal.MaxValue, decimal.MinValue, decimal.MaxValue + decimal.MinValue, decimal.Zero };

         for (int i = 0; i < 4; i++)
         {
             Console.WriteLine("배열->" + Denum[i]);
         }*/
/*
   //배열에 있엇 표준적으로 사용하느 기능은
   //num.Length 기능 사용
   int[] num = { 3, 2, 1, 6, 7, 9, 8 };
   Array.Sort(num);
   //Array.Clear(num);
   for (int i=0;i<7;i++)
   {
       Console.Write("  " + num[i]);
   }*/

    /*
int[] num;
int[,] num3;
int[,,] num4;
num = new int[2];
            num3 = new int[2, 3];//[][]
            num4 = new int[2, 3, 4];//[][][]
            int count = 3;
int[] num5 = new int[count];
            for (int i = 0; i< 3;i++)
            {
                Console.WriteLine("갯수" + num5[i]);
            }*/