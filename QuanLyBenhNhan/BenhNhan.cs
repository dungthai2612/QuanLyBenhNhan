using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBenhNhan
{
    internal abstract class BenhNhan
    {
        private string mabn;
        private string hoTen;
        private int songay;

        public string Mabn { get => mabn; set => mabn = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public int Songay { get => songay; set => songay = value; }

        public BenhNhan()
        {
        }

        public BenhNhan(string mabn, string hoTen, int songay)
        {
            this.mabn = mabn;
            this.hoTen = hoTen;
            this.songay = songay;
        }
        public virtual void Nhap()
        {
            Console.WriteLine("Nhập mã số bệnh nhân : "); this.Mabn = Console.ReadLine();
            Console.WriteLine("Nhập họ tên bệnh nhân :"); this.hoTen = Console.ReadLine();
            Console.WriteLine("Nhập số ngày nằm viện : "); this.songay = int.Parse(Console.ReadLine());

        }
        public virtual void Xuat()
        {
            Console.WriteLine("Mã số bệnh nhân là :{0}", this.mabn);
            Console.WriteLine("Họ tên bệnh nhân là :{0} ", this.hoTen);
            Console.WriteLine("Số ngày nhập viện là :{0} ", this.Songay);
        }
        public abstract double tinhVienPhi();

    }
}
