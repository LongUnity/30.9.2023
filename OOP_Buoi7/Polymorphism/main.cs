using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class main
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            /*Animals a = new Cho();
            Animals b = new Meo();
            Animals c = new Animals();

            a.keu();
            b.keu();
            c.keu();*/
            /*List<Animals> l = new List<Animals>();
            l.Add(new Cho());
            l.Add(new Meo());
            l.Add(new Animals());

            foreach (var item in l)
            {
                item.keu();
            }*/
            DSDV ds = new DSDV();
            ds.nhap();
            
            Console.WriteLine("SL class cho:" + ds.demSLCho());

            Console.ReadKey();
        }
    }
}
