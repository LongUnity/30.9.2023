using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV
{
    internal class DSDG
    {
        public List<Docgia> ds { get; set; }
        public DSDG() { }

        public void nhap()
        {
            ds = new List<Docgia>();


            //ds.Add(new NguoiLon());
            Docgia a = new NguoiLon();
            a.nhap();
            ds.Add(a);
            //ds.Add(new TreEm());
            Docgia b = new TreEm();
            b.nhap();
            ds.Add(b);

        }

        public void xuat()
        {
            foreach(var d in ds)
            {
                d.xuat();
            }
        }

        public double tongTien()
        {
            double tong=0;
            foreach(var d in ds)
            {
                tong += d.tongPhi();
            }
            return tong;
        }
    }
}
