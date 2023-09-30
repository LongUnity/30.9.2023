using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class PhanSo
    {
        public int TuSo { get; set; }
        public int MauSo { get; set; }
        public double Value => (double)this.TuSo/ (double)this.MauSo;
        public override string ToString()
        {
            return $"{TuSo}/{MauSo}";
        }
        public PhanSo() { }
        public PhanSo(int TuSo, int MauSo)
        {
            this.TuSo = TuSo;
            this.MauSo = MauSo;
        }

        public PhanSo tong(PhanSo b)
        {
            PhanSo kq =  new PhanSo();

            kq.TuSo = (this.TuSo * b.MauSo) + (this.MauSo * b.TuSo);
            kq.MauSo = this.MauSo * b.MauSo;

            return kq;
        }

    }
}
