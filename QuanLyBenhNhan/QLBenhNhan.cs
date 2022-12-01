using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBenhNhan
{
    internal class QLBenhNhan
    {

        Dictionary<string, BenhNhan> danhsach = new Dictionary<string, BenhNhan>();
        internal Dictionary<string, BenhNhan> DanhSach
        {
            get { return danhsach; }
            set { danhsach = value; }
        }
        public QLBenhNhan()
        {

        }
        public void LuaChon()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            while (true)
            {
                Console.WriteLine("*-------------------------------------------------------------*");
                Console.WriteLine("|                CHƯƠNG TRÌNH QUẢN LÝ BỆNH NHÂN               |");
                Console.WriteLine("*-------------------------------------------------------------*");
                Console.WriteLine("| - Nhập 0 để kết thúc chương trình                           |");
                Console.WriteLine("| - Nhập 1 để nhập thông tin Bệnh nhân                        |");
                Console.WriteLine("| - Nhập 2 để in thông tin Bệnh nhân                          |");
                Console.WriteLine("| - Nhập 3 để tìm nhân viên theo mã Bệnh nhân                 |");
                Console.WriteLine("| - Nhập 4 để xóa nhân viên theo mã Bệnh nhân                 |");
                Console.WriteLine("| - Nhập 5 để tính tổng tiền viện phí                         |");
                Console.WriteLine("*-------------------------------------------------------------*");
                string luaChon = Console.ReadLine();
                if (luaChon == "0")
                    break;
                else if (luaChon == "1")
                    Nhap();

                else if (luaChon == "2")
                    Xuat();

                else if (luaChon == "3")
                    timBN();
                else if (luaChon == "4")
                    Xoa();
                else if (luaChon == "5")
                    tinhTongTien();

            }
        }
        public void Nhap()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            while (true)
            {
                Console.WriteLine("Nhập A để nhập bệnh nhân bảo hiểm xã hội \nNhập B để nhập bệnh nhân bảo hiểm y tế \nNhập E để thoát khỏi yêu cầu nhập");
                string option = Console.ReadLine().ToUpper();
                if (option == "E") break;
                if (option == "A")
                {
                    BenhNhan BN1 = new BenhNhan_BHXH();
                    while (true)
                    {
                        try
                        {
                            BN1.Nhap();
                            danhsach.Add(BN1.Mabn, BN1);
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("Nhập bị trùng mã hoặc sai định dạng ngày tháng ");

                        }
                    }

                }
                else if (option == "B")
                {
                    BenhNhan BN2 = new BenhNhan_BHYT();
                    while (true)
                    {
                        try
                        {
                            BN2.Nhap();
                            danhsach.Add(BN2.Mabn, BN2);
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("Nhập bị sai mã hoặc sai định dạng");
                        }
                    }
                }
                else Console.WriteLine("NHập sai lựa chọn!!!");
            }
        }
        public void Xuat()
        {
            foreach (BenhNhan item in danhsach.Values)
            {
                item.Xuat();
            }
            Console.WriteLine();
        }
        public void timBN()
        {
            BenhNhan bn = null;
            string maTim;
            int count = 0;
            Console.WriteLine("Nhập mã bệnh nhân cần tìm :");
            maTim = Console.ReadLine();
            foreach (BenhNhan item in danhsach.Values)
            {
                if (item.Mabn == maTim)
                {
                    count++;
                    bn = item;
                    break;

                }
            }
            if (count != 0)
            {
                Console.WriteLine("Tìm thấy bệnh nhân , mã bệnh nhân :{0}", maTim);
                Console.WriteLine("Thông tin bệnh nhân : ");
                bn.Xuat();
            }
            else
            {
                Console.WriteLine("Không tìm thấy bệnh nhân cần tìm !!!");
            }
        }
        public void Xoa()
        {
            Console.WriteLine("Nhập mã bệnh nhân cần xóa: ");
            string maxoa = Console.ReadLine();
            if (danhsach.ContainsKey(maxoa))
            {
                danhsach.Remove(maxoa);
                Console.WriteLine("******Danh sách sau khi xóa******");
                Xuat();
            }
            else Console.WriteLine("Không tìm thấy {0}\n", maxoa);


        }
        public void tinhTongTien()
        {
            double soBHXH = 0, soBHYT = 0, s = 0;
            foreach (BenhNhan item in danhsach.Values)
            {
                if (item is BenhNhan_BHXH)
                {
                    soBHXH = soBHXH + ((BenhNhan_BHXH)item).tinhVienPhi() * ((BenhNhan_BHXH)item).tienGiam();
                }
                else
                {
                    soBHYT = soBHYT + ((BenhNhan_BHYT)item).tinhVienPhi() * ((BenhNhan_BHYT)item).tienGiam();

                }
            }
            s = soBHYT + soBHXH;
            Console.WriteLine("Tổng viện phí :{0}", s);

        }

    }
}


