using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VienKhoaHoc
{
    public class NhanVienPTN : NhanVien
    {
        private long luongKhoan;

        public long LuongKhoan { get => luongKhoan; set => luongKhoan = value; }

        public NhanVienPTN(long luongKhoan)
        {
            this.luongKhoan = luongKhoan;
        }

        public NhanVienPTN()
        {
        }
        public override void Nhap()
        {
            base.Nhap();

            #region nhập lương khoán
            bool luongKhoanBool = false;
            do
            {
                Console.WriteLine("</> Luong Khoan: \t</>");
                string luongKhoanStr = Console.ReadLine();
                int luongKhoanInt;
                luongKhoanBool = int.TryParse(luongKhoanStr, out luongKhoanInt);
                if (luongKhoanBool == false) // !luongKhoanBool
                {
                    Console.WriteLine("</> Sai kieu du lieu luong khoan, vui long nhap lai! </>");

                }
                else
                {
                    this.luongKhoan = luongKhoanInt;
                }
            } while (luongKhoanBool == false);//!luongKhoanBool
            #endregion

            TinhLuong();
        }

        public override void Xuat()
        {
            base.Xuat();//ctrl K D sap xep code
            Console.WriteLine("</> Luong khoan:{0} \t</>", this.luongKhoan);
        }

        public void TinhLuong()
        {
            base.Luong = this.luongKhoan;
        }
    }
}
