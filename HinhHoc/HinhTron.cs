using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HinhHoc;

namespace HinhHoc
{
    internal class HinhTron : Hinh
    {
        private double banKinh;

        public HinhTron(double r)
        {
            banKinh = r;
        }

        public override double TinhChuVi()
        {
            return 2 * Math.PI * banKinh;
        }

        public override double TinhDienTich()
        {
            return Math.PI * banKinh * banKinh;
        }
    }
}