using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class DSHinh
    {
        public int n { get; set; }
        public List<Hinhhoc> ds { get; set; }
        public DSHinh() { }

        public void nhap()
        {
            ds = new List<Hinhhoc>();
            Console.WriteLine("Nhập số hinh: ");
            this.n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int m;
                Console.WriteLine("1: thêm hinh chu nhat:");
                Console.WriteLine("2: thêm hinh vuong:");
                Console.WriteLine("3: thêm hinh eclip:");
                Console.WriteLine("4: thêm hinh tron:");
                Console.WriteLine("số khác: Thoát!!!");
                Console.Write("Nhập lựa chọn: ");
                m = int.Parse(Console.ReadLine());
                switch (m)
                {
                    case 1:
                        Console.WriteLine("Mời thêm chu nhat:");
                        Hinhhoc hcn = new Hcn();
                        hcn.nhap();
                        ds.Add(hcn);
                        break;
                    case 2:
                        Console.WriteLine("Mời thêm vuong:");
                        Hinhhoc hv = new Hv();
                        hv.nhap();
                        ds.Add(hv);
                        break;
                    case 3:
                        Console.WriteLine("Mời thêm hinh eclip:");
                        Hinhhoc he = new Helip();
                        he.nhap();
                        ds.Add(he);
                        break;
                    case 4:
                        Console.WriteLine("Mời thêm hinh tron:");
                        Hinhhoc ht = new Htron();
                        ht.nhap();
                        ds.Add(ht);
                        break;
                    default:
                        Console.WriteLine("Thoát chương trình");
                        break;
                }

                Console.WriteLine();
            }
        }
        public void xuat()
        {

            foreach (var item in ds)
            {
                item.xuat();
            }
        }
        public double tongChuvi()
        {
            double tong = 0;
            foreach (var d in ds)
            {
                tong += d.ChuVi();
            }
            return tong;
        }
        public double tongDientich()
        {
            double tong = 0;
            foreach (var d in ds)
            {
                tong += d.DienTich();
            }
            return tong;
        }
    }
}
