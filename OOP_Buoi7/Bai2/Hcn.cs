using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class Hcn:Hinhhoc
    {
        public double dai { get; set; }
        public double rong { get; set; }

        public Hcn() { }
        public override void nhap()
        {
            Console.Write("Nhập chiều dài: ");
            dai = double.Parse(Console.ReadLine());
            Console.Write("Nhập chiều rộng: ");
            rong = double.Parse(Console.ReadLine());
        }
        public override void xuat()
        {
            Console.WriteLine("HCN: ");           
            Console.WriteLine("Chiều dai: "+dai);
            Console.WriteLine("Chiều rong: " + rong);
            Console.WriteLine("Chu vi: " + ChuVi());
            Console.WriteLine("Dien tich: " + DienTich());
            Console.WriteLine("");

        }
        public override double ChuVi() => (dai + rong) * 2;
        public override double DienTich() => dai * rong;
    }
}
