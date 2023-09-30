using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class DSDV
    {
        public DSDV() { }

        public List<Animals> ds { get; set; }

        public void nhap()
        {
            ds = new List<Animals>();
            ds.Add(new Cho());
            ds.Add(new Cho());
            ds.Add(new Meo());
        }
        public void xuat()
        {
            foreach (var item in ds)
            {
                item.keu();
            }
        }

        public double demSLCho()
        {
            double count=0;

            foreach (var item in ds) {
                if (item.GetType() == typeof(Cho))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
