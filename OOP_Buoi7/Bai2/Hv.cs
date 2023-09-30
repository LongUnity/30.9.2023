using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class Hv:Hcn
    {
        public double canh { get; set; }
        public Hv() { }
        public override void nhap()
        {
            Console.Write("Nhập canh: ");
            dai = double.Parse(Console.ReadLine());
            rong = dai;
        }
        public override void xuat()
        {
            Console.WriteLine("Hinh vuong: ");
            Console.WriteLine("Canh: " + dai);
            Console.WriteLine("Chu vi: " + ChuVi());
            Console.WriteLine("Dien tich: " + DienTich());
            Console.WriteLine("");

        }
    }
}
