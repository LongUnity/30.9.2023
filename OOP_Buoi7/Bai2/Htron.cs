using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class Htron:Helip
    {
        public Htron() { }

        public override void nhap()
        {
            Console.WriteLine("Nhập bán kính: ");
            BT1 = float.Parse(Console.ReadLine());
            BT2 = BT1;
        }
        public override void xuat()
        {
            Console.WriteLine("Hinh tron: ");
            Console.WriteLine("Bán kính: " + BT1);
            Console.WriteLine("Chu vi: " + ChuVi());
            Console.WriteLine("Dien tich: " + DienTich());
            Console.WriteLine("");
        }
    }
}
