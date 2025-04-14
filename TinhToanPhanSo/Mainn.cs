using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhToanPhanSo
{
    internal class Mainn
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            List<PhanSo> danhSachPhanSo = new List<PhanSo>();

            Console.Write("Nhập số lượng phân số: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nNhập phân số thứ {i + 1}:");
                PhanSo ps = new PhanSo();
                ps.NhapPhanSo();
                danhSachPhanSo.Add(ps);
            }

            PhanSo tong = new PhanSo(0, 1);
            foreach (PhanSo ps in danhSachPhanSo)
            {
                tong = tong.Cong(ps);
            }

            Console.WriteLine($"\nTổng các phân số là: {tong}");
        }
    }
}