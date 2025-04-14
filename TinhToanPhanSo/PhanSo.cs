using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhToanPhanSo
{
    internal class PhanSo
    {
        private int tuSo;
        private int mauSo;

        public int TuSo
        {
            get { return tuSo; }
            set { tuSo = value; }
        }

        public int MauSo
        {
            get { return mauSo; }
            set
            {
                if (value == 0)
                {
                    Console.WriteLine("Mẫu số không được bằng 0. Gán mặc định là 1.");
                    mauSo = 1;
                }
                else
                {
                    mauSo = value;
                }
            }
        }

        // Constructor mặc định
        public PhanSo() { }

        // Constructor có tham số
        public PhanSo(int tu, int mau)
        {
            TuSo = tu;
            MauSo = mau;
            RutGon();
        }

        // Phương thức nhập phân số
        public void NhapPhanSo()
        {
            Console.Write("Nhập tử số: ");
            TuSo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập mẫu số: ");
            MauSo = Convert.ToInt32(Console.ReadLine());
            RutGon();
        }

        // Phương thức rút gọn phân số (private)
        private void RutGon()
        {
            int ucln = UCLN(Math.Abs(tuSo), Math.Abs(mauSo));
            tuSo /= ucln;
            mauSo /= ucln;

            // Đưa dấu âm về tử số
            if (mauSo < 0)
            {
                tuSo *= -1;
                mauSo *= -1;
            }
        }

        // Tìm UCLN
        private int UCLN(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        // Phương thức cộng hai phân số
        public PhanSo Cong(PhanSo ps)
        {
            int tuMoi = this.TuSo * ps.MauSo + ps.TuSo * this.MauSo;
            int mauMoi = this.MauSo * ps.MauSo;
            return new PhanSo(tuMoi, mauMoi);
        }

        // Xuất phân số
        public override string ToString()
        {
            return $"{TuSo}/{MauSo}";
        }
    }
}