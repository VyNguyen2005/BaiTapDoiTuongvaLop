using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap ID nguoi dung 1: ");
            string myId = Console.ReadLine();
            Console.Write("Nhap ten nguoi dung 1: ");
            string myName = Console.ReadLine();
            Console.Write("Nhap so tien co trong tai khoan 1: ");
            int myBalance = int.Parse(Console.ReadLine());

            Account my = new Account(myId, myName, myBalance);

            Console.Write("Nhap ID nguoi dung 2: ");
            string yourId = Console.ReadLine();
            Console.Write("Nhap ten nguoi dung 2: ");
            string yourName = Console.ReadLine();
            Console.Write("Nhap so tien co trong tai khoan 2: ");
            int yourBalance = int.Parse(Console.ReadLine());

            Account your = new Account(yourId, yourName, yourBalance);

            Console.WriteLine("----Thong tin nguoi dung ban dau----");
            Console.WriteLine($"My Account: [ ID: {my.getID()}, Name: {my.getName()}, Balance: {my.getBalance()} ]");
            Console.WriteLine($"Your Account: [ ID: {your.getID()}, Name: {your.getName()}, Balance: {your.getBalance()} ]");

            Console.Write("Nhap so tien can nap: ");
            int nap = int.Parse(Console.ReadLine());
            my.credit(nap);

            Console.Write("Nhap so tien can rut: ");
            int rut = int.Parse(Console.ReadLine());
            your.debit(rut);

            Console.Write("Nhap so tien can chuyen: ");
            int chuyen = int.Parse(Console.ReadLine());
            my.tranferTo(your, chuyen);
            your.tranferTo(my, chuyen);

            Console.WriteLine("----Thong tin nguoi dung sau khi thuc hien----");
            Console.WriteLine($"My Account: [ ID: {my.getID()}, Name: {my.getName()}, Balance: {my.getBalance()} ]");
            Console.WriteLine($"Your Account: [ ID: {your.getID()}, Name: {your.getName()}, Balance: {your.getBalance()} ]");

            Console.ReadLine();
        }
    }
}
