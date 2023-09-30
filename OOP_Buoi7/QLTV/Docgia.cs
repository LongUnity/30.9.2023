using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV
{
    internal abstract class Docgia
    {
        public string HoTen { get; set; }
        public int STDK { get; set; }
        public abstract double tongPhi();
        public Docgia() { }

        public virtual void nhap()
        {
            Console.Write("Nhập ho va ten: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhập so thang dang ky: ");
            STDK = int.Parse(Console.ReadLine());
        }
        public virtual void xuat()
        {
            Console.Write("Ho va ten: "+ HoTen);            
            Console.Write("so thang dang ky: "+STDK);
        }

    }
}
