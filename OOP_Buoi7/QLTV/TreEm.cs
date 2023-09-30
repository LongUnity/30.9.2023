using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV
{
    internal class TreEm:Docgia
    {
        public string HTGiamho { get; set; }
        public TreEm() { }

        public override void nhap()
        {
            base.nhap();
            Console.Write("Nhập ten nguoi giam ho: ");
            HTGiamho = Console.ReadLine();            
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("Nguoi giam ho: " + HTGiamho);
        }
        public override double tongPhi()
        {
            return 10000 * STDK;
        }
    }
}
