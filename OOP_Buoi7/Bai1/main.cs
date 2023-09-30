using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class main
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;




            PhanSo p1 = new PhanSo(2,3);
            PhanSo p2 = new PhanSo(5,6);

            Console.WriteLine(p1.ToString());
            Console.WriteLine(p2.ToString());
            Console.WriteLine("Gia tri phan so: "+p1.tong(p2));
            Console.WriteLine("Gia tri thuc: " + (p1.tong(p2).Value));
            



            Console.ReadKey();
        }
    }
}
