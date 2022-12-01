using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBenhNhan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QLBenhNhan QLBN = new QLBenhNhan();
            QLBN.LuaChon();
            Console.WriteLine("Chương trình kết thúc");
            Console.WriteLine();
        }
    }
}