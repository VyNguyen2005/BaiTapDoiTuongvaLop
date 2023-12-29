using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap03
{
    class Phanso
    {
        private int tuso;
        private int mauso;
        public Phanso()
        {
            tuso = 0;
            mauso = 1;
        }
        public Phanso(int tuso, int mauso)
        {
            this.tuso = tuso;
            this.mauso = mauso;
        }
        public void setTuso(int tuso)
        {
            this.tuso = tuso;
        }
        public int getTuso()
        {
            return tuso;
        }
        public void setMauso(int mauso)
        {
            this.mauso = mauso;
        }
        public int getMauso()
        {
            return mauso;
        }
        private int TimUSCLN(int a, int b)
        {
            int x = Math.Abs(a);
            int y = Math.Abs(b);
            while (x != y)
            {
                if (x > y)
                    x = x - y;
                else
                    y = y - x;
            }
            return x;
        }
        public void toiGian()
        {
            int ucln = TimUSCLN(tuso, mauso);
            tuso = tuso / ucln;
            mauso = mauso / ucln;
        }
        public Phanso tong(Phanso ps)
        {
            Phanso kq = new Phanso();
            kq.tuso = tuso * ps.mauso + mauso * ps.tuso;
            kq.mauso = mauso * ps.mauso;
            return kq;
        }
        public Phanso hieu(Phanso ps)
        {
            Phanso kq = new Phanso();
            kq.tuso = tuso * ps.mauso - mauso * ps.tuso;
            kq.mauso = mauso * ps.mauso;
            return kq;
        }
        public Phanso tich(Phanso ps)
        {
            Phanso kq = new Phanso();
            kq.tuso = tuso * ps.tuso;
            kq.mauso = mauso * ps.mauso;
            return kq;
        }
        public Phanso thuong(Phanso ps)
        {
            Phanso kq = new Phanso();
            kq.tuso = tuso * ps.mauso;
            kq.mauso = mauso * ps.tuso;
            return kq;
        }
    }
}

