using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property_ex3
{
    abstract class Product
    {
        private static int serial = 0;
        public string SerialId
        {
            get { return String.Format("{0:d5}", serial++); }
        }
        abstract public DateTime ProductDate
        {
            get;
            set;
        }
    }

    class MyProduct : Product
    {
        public override DateTime ProductDate { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Product product_1 = new MyProduct()
            {
                ProductDate = new DateTime(2014,1,10)
            };

            Console.WriteLine("Pro: {0} ProDate {1}",product_1.SerialId,product_1.ProductDate);

            Product product_2 = new MyProduct()
            {
                ProductDate = new DateTime(2014, 2, 3)
            };

            Console.WriteLine("Pro: {0} ProDate {1}", product_2.SerialId, product_2.ProductDate);
        }
    }
}
