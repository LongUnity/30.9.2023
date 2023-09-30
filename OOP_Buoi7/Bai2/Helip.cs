using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class Helip:Hinhhoc
    {

        public double BT1 { get; set; }
        public double BT2 { get; set; }
        public double pi = 3.14;
        
        public Helip() { }

        public override void nhap()
        {
            Console.WriteLine("Nhập chiều dài trục 1: ");
            BT1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập chiều dài trục 2: ");
            BT2 = double.Parse(Console.ReadLine());
        }
        public override void xuat()
        {
            Console.WriteLine("hinh elip: ");
            Console.WriteLine("Chiều dài trục 1: " + BT1);
            Console.WriteLine("Chiều dài trục 2: " + BT2);
            Console.WriteLine("Chu vi: " + ChuVi());
            Console.WriteLine("Dien tich: " + DienTich());
            Console.WriteLine("");
        }
        public override double ChuVi()  => 2 * pi * Math.Sqrt((Math.Pow(BT1, 2) + Math.Pow(BT2, 2)) / 2);
        public override double DienTich() => pi * BT1 * BT2;
    }
}
