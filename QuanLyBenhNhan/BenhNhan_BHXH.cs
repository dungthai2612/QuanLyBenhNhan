using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBenhNhan
{
    class BenhNhan_BHXH : BenhNhan, ITienAn
    {
        private string maBHXH;

        public string MaBHXH { get => maBHXH; set => maBHXH = value; }

        public BenhNhan_BHXH() : base()
        {
        }

        public BenhNhan_BHXH(string mabn, string hoTen, int songay, string maBHXH)
            : base(mabn, hoTen, songay)
        {
            this.maBHXH = maBHXH;

        }

        public override void Nhap()
        {
            Console.OutputEncoding = Encoding.UTF8;
            base.Nhap();
            Console.WriteLine("Nhập mã số bao hiểm xã hội : ");
            this.MaBHXH = Console.ReadLine();
        }
            
        public override void Xuat()
        {
            Console.OutputEncoding = Encoding.UTF8;
            base.Xuat();
            Console.WriteLine("Mã số bảo hiểm xã hội là : " + this.maBHXH);
            Console.WriteLine("Tiền viện phí là: " + tinhVienPhi());
            Console.WriteLine("Tiền ăn là :" + tinhTienAn());
        }

        public override double tinhVienPhi()
        {
            return this.Songay * (70000 + tinhTienAn());

        }
        public double tinhTienAn()
        {
            return 30000;
        }
        public double tienGiam()
        {
            return 0.1;
        }
    }
}
