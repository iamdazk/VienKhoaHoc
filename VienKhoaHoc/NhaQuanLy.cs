using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VienKhoaHoc
{
    public class NhaQuanLy : NhanVien
    {
        private string chucVu;
        private int soNgayCong;
        private float bacLuong;

        public string ChucVu { get => chucVu; set => chucVu = value; }
        public int SoNgayCong { get => soNgayCong; set => soNgayCong = value; }
        public float BacLuong { get => bacLuong; set => bacLuong = value; }

        public NhaQuanLy()
        {
        }

        public NhaQuanLy(string chucVu, int soNgayCong, float bacLuong)
        {
            this.chucVu = chucVu;
            this.soNgayCong = soNgayCong;
            this.bacLuong = bacLuong;
        }
        public override void Nhap()
        {
            base.Nhap();

            #region nhập chức vụ
            Console.WriteLine("</> Chuc vu: \t</>");
            this.chucVu = Console.ReadLine();
            #endregion

            #region nhập số ngày công
            bool soNgayCongBool = false;
            do
            {
                Console.WriteLine("</> So ngay cong: \t</>");
                string soNgayCongStr = Console.ReadLine();
                int soNgayCongInt;
                soNgayCongBool = int.TryParse(soNgayCongStr, out soNgayCongInt);
                if (soNgayCongBool == false) // !soNgayCongBool
                {
                    Console.WriteLine("</> Sai kieu du lieu so ngay cong, vui long nhap lai! </>");

                }
                else
                {
                    this.soNgayCong = soNgayCongInt;
                }
            } while (soNgayCongBool == false);//!soNgayCongBool
            #endregion

            #region nhập bậc lương
            bool bacLuongBool = false;
            do
            {
                Console.WriteLine("</> Bac luong: \t</>");
                string bacLuongStr = Console.ReadLine();
                float bacLuongFloat;
                bacLuongBool = float.TryParse(bacLuongStr, out bacLuongFloat);
                if (bacLuongBool == false)
                {
                    Console.WriteLine("</> Sai kieu du lieu so bac luong, vui long nhap lai! </>");

                }
                else
                {
                    this.bacLuong = bacLuongFloat;
                }
            } while (bacLuongBool == false);
            #endregion

            TinhLuong();
        }

        public override void Xuat()
        {
            base.Xuat();//ctrl K D sap xep code
            Console.WriteLine("</> Chuc vu:\t{0} \t</>", this.chucVu);
            Console.WriteLine("</> Ngay cong:\t{0} \t\t</>", this.soNgayCong);
            Console.WriteLine("</> Bac luong:\t{0} \t</>", this.bacLuong);
            Console.WriteLine("</> So luong:\t{0} \t</>", base.Luong);

        }
        public void TinhLuong()
        {
            base.Luong = Convert.ToInt64(this.soNgayCong * this.bacLuong);
        }
    }
}
