using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV
{
    internal class NguoiLon:Docgia
    {
        //Độc giả người lớn: Tên, cmnd, số tháng đăng kí, phí thu=15k/ 1 tháng
        public int CMND { get; set; }
        public NguoiLon() { }

        public override void nhap()
        {
            base.nhap();
            Console.Write("Nhập so CMND: ");
            CMND = int.Parse(Console.ReadLine());
        }
        public override void xuat()
        {
            base.xuat();
            Console.Write("CMND: " + CMND);
        }
        public override double tongPhi()
        {
            return 15000 * STDK;
        }
    }
}
