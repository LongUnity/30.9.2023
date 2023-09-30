using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV
{
    internal class main
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;





            DSDG dSDG = new DSDG();

            dSDG.nhap();
            dSDG.xuat();

            Console.WriteLine("tong tien: "+dSDG.tongTien());






            Console.ReadKey();
        }
    }
}
