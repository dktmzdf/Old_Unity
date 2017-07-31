using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

interface IRunnable
{
    void Run();
}

interface IFlyalbe
{
    void Fly();
}

class FlyingCar : IRunnable, IFlyalbe
{
    public void Run()
    {
        Console.WriteLine("Run! Run");
    }
    public void Fly()
    {
        Console.WriteLine("Fly! Fly!");
    }
}

namespace interface_ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            FlyingCar car = new FlyingCar();
            car.Run();
            car.Fly();
            ;
            IRunnable runnable = car as IRunnable;
            runnable.Run();

            IFlyalbe flyable = car as IFlyalbe;
            flyable.Fly();
        }
    }
}
