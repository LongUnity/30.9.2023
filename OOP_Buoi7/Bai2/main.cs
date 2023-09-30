using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class main
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;






            DSHinh ds=new DSHinh();

            ds.nhap();
            ds.xuat();
            Console.WriteLine("Tong chu vi: "+ds.tongChuvi());
            Console.WriteLine("Tong dien tich: " + ds.tongDientich());

            Console.ReadKey();
        }
    }
}
