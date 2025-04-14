using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HinhHoc;

namespace HinhHoc
{
    internal class Mainn
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            List<Hinh> danhSachHinh = new List<Hinh>();

            // Thêm các hình
            danhSachHinh.Add(new HinhTron(7));
            danhSachHinh.Add(new HinhVuong(5));
            danhSachHinh.Add(new HinhChuNhat(4,6));
            danhSachHinh.Add(new HinhTamGiac(6, 8, 10));

            double tongChuVi = 0;
            double tongDienTich = 0;

            int i = 1;
            foreach (Hinh h in danhSachHinh)
            {
                double chuVi = h.TinhChuVi();
                double dienTich = h.TinhDienTich();
                Console.WriteLine($"Hình {i++}: Chu vi = {chuVi:F2}, Diện tích = {dienTich:F2}");
                tongChuVi += chuVi;
                tongDienTich += dienTich;
            }

            Console.WriteLine($"\n Tổng chu vi các hình: {tongChuVi:F2}");
            Console.WriteLine($" Tổng diện tích các hình: {tongDienTich:F2}");
        }
    }
}