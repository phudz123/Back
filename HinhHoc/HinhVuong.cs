using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HinhHoc;

namespace HinhHoc
{
    internal class HinhVuong : Hinh
    {
        private double canh;

        public HinhVuong(double c)
        {
            canh = c;
        }

        public override double TinhChuVi()
        {
            return 4 * canh;
        }

        public override double TinhDienTich()
        {
            return canh * canh;
        }
    }
}