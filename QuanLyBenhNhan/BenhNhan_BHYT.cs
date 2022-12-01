using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBenhNhan
{
    class BenhNhan_BHYT : BenhNhan, ITienAn
    {
        private string maBHYT;

        public string MaBHYT { get => maBHYT; set => maBHYT = value; }

        public BenhNhan_BHYT() : base()
        {
        }

        public BenhNhan_BHYT(string mabn, string hoTen, int songay, string maBHYT)
            : base(mabn, hoTen, songay)
        {
            this.maBHYT = maBHYT;

        }

        public override void Nhap()
        {
            Console.OutputEncoding = Encoding.UTF8;
            base.Nhap();
            Console.WriteLine("Nhập mã số bao hiểm xã hội : ");
            this.MaBHYT = Console.ReadLine();
        }
        public override void Xuat()
        {
            Console.OutputEncoding = Encoding.UTF8;
            base.Xuat();
            Console.WriteLine("Mã số bảo hiểm xã hội là : " + this.maBHYT);
            Console.WriteLine("Tiền viện phí là : " + tinhVienPhi());
            Console.WriteLine("Tiền ăn là :" + tinhTienAn());
        }

        public override double tinhVienPhi()
        {
            return this.Songay * (50000 + tinhTienAn());

        }
        public double tinhTienAn()
        {
            return 25000;
        }
        public double tienGiam()
        {
            return 0.2;
        }
    }
}
