using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap03
{
    class Program
    {
        static void CauA()
        {
            Phanso p1 = new Phanso();
            Console.WriteLine("----Nhap thong tin phan so thu nhat----");
            Console.Write("Nhap tu so: ");
            int tuso = int.Parse(Console.ReadLine());
            Console.Write("Nhap mau so: ");
            int mauso = int.Parse(Console.ReadLine());

            p1.setTuso(tuso);
            p1.setMauso(mauso);
            p1.toiGian();

            Console.WriteLine("----Nhap thong tin phan so thu hai----");
            Console.Write("Nhap tu so: ");
            tuso = int.Parse(Console.ReadLine());
            Console.Write("Nhap mau so: ");
            mauso = int.Parse(Console.ReadLine());

            Phanso p2 = new Phanso(tuso, mauso);
            p2.toiGian();

            Phanso tong = p1.tong(p2);
            Console.WriteLine($"Tong 2 phan so {p1.getTuso()}/{p1.getMauso()} + {p2.getTuso()}/{p2.getMauso()} = {tong.getTuso()}/{tong.getMauso()}");
            Phanso hieu = p1.hieu(p2);
            Console.WriteLine($"Hieu 2 phan so {p1.getTuso()}/{p1.getMauso()} - {p2.getTuso()}/{p2.getMauso()} = {hieu.getTuso()}/{hieu.getMauso()}");
            Phanso tich = p1.tich(p2);
            Console.WriteLine($"Tich 2 phan so {p1.getTuso()}/{p1.getMauso()} * {p2.getTuso()}/{p2.getMauso()} = {tich.getTuso()}/{tich.getMauso()}");
            Phanso thuong = p1.thuong(p2);
            Console.WriteLine($"Thuong 2 phan so {p1.getTuso()}/{p1.getMauso()} / {p2.getTuso()}/{p2.getMauso()} = {thuong.getTuso()}/{thuong.getMauso()}");
        }
        static void CauB()
        {
            Console.WriteLine("----Tinh tong cua day phan so----");
            Console.Write("Nhap so nguyen duong: ");
            int n = int.Parse(Console.ReadLine());

            Phanso s = new Phanso(0, 1);
            for (int i = 1; i <= n; i++)
            {
                s = s.tong(new Phanso(1, i));
            }
            s.toiGian();
            Console.WriteLine($"Ket qua tinh tong: 1 + 1/2 + 1/3 +...+ 1/n = {s.getTuso()}/{s.getMauso()}");
        }
        static void Main(string[] args)
        {
            CauA();
            CauB();

            Console.ReadLine();
        }
    }
}
