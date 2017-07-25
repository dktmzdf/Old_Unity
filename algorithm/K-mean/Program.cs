using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class NumData
{
    private int DataCount;
    private int DataCol;
    public double[,] ArrData;
    public NumData(int count,int col)
    {
        DataCount = count;
        DataCol = col;
        ArrData = new double[DataCount, DataCol];
    }
    public NumData(NumData temp)
    {
        this.DataCount = temp.DataCount;
        this.DataCol = temp.DataCount;
        this.ArrData = new double[DataCount, DataCol];
    }
    public void DataStructView()
    {
        Console.WriteLine("DataCount:" + DataCount + " dim: " + DataCol);
    }
    public int CountView()
    {
        return this.DataCount;
    }
    public int ColView()
    {
        return this.DataCol;
    }
    
}


namespace K_mean
{
    class Program
    {
        static void Main(string[] args)
        {
            NumData dData;
            int DataCount = 0, DataCol = 0;
            char delimiterChar = ',';
           

            string path = @"C:\Users\KICT-06\Desktop\Unity/data_large.txt";
            string line;
            FileInfo DataFile = new FileInfo(path);

            if (DataFile.Exists)
            {
                int i = 0, j = 0;
                StreamReader readDataLine = new System.IO.StreamReader(path);
                line = readDataLine.ReadLine();
                DataCol = Convert.ToInt32(line);
                line = readDataLine.ReadLine();
                DataCount = Convert.ToInt32(line);
                dData = new NumData(DataCount,DataCol);

                while ((line = readDataLine.ReadLine()) != null)
                {
                    string[] tempString;
                    tempString = line.Split(delimiterChar);
                    for (j = 0; j < DataCol; j++)
                    {
                        dData.ArrData[i, j] = Convert.ToDouble(tempString[j]);
                    }
                    j = 0;
                    i++;
                }
                Console.WriteLine(dData.ArrData[0, 0]);
                Console.WriteLine(dData.ArrData[1, 0]);
                Console.WriteLine(dData.ArrData[2, 0]);
                readDataLine.Close();
                
                
                
            }
            else
            {
                Console.WriteLine("존재하지 않습니다.");
            }

        }
    }
}
