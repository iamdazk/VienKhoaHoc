using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VienKhoaHoc
{
    class Program
    {
        static void Main(string[] args)
        {
            List<NhanVien> nhanViens = new List<NhanVien>();

            showMenu(nhanViens);

            Console.ReadKey();
        }
        public static void showMenu(List<NhanVien> nhanViens)
        {
            int choose = 0;
            do
            {
                Console.WriteLine("</> =========================== </>");
                Console.WriteLine("</> \t\tMENU\t \t</>");
                Console.WriteLine("</> =========================== </>");
                Console.WriteLine("</> 1.NHAP NHA KHOA HOC \t</>");
                Console.WriteLine("</> 2.NHAP NHA QUAN LY \t\t</>");
                Console.WriteLine("</> 3.NHAP NHAN VIEN PTN \t</>");
                Console.WriteLine("</> 4.XUAT DANH SACH NHAN VIEN\t</>");
                Console.WriteLine("</> 5.XUAT LUONG THEO LOAI NV\t</>");
                Console.WriteLine("</> 0.EXIT \t\t\t</>");


                #region nhập lựa chọn
                bool chooseBool = false;
                do
                {
                    Console.Write("</> Lua chon(0 -- > 4):");
                    string chooseStr = Console.ReadLine();
                    int chooseInt;
                    chooseBool = int.TryParse(chooseStr, out chooseInt);
                    if (chooseBool == false)
                    {
                        Console.WriteLine("</> NOTE: Chi duoc chon tu 0 -> 4, vui long nhap lai! </>");

                    }
                    else
                    {
                        choose = chooseInt;
                    }
                } while (chooseBool == false);
                #endregion

                switch (choose)
                {
                    case 1:
                        Console.WriteLine("</> NHAP NHA KHOA HOC \t</>");
                        NhaKhoaHoc nhaKhoaHoc = new NhaKhoaHoc();
                        nhaKhoaHoc.Nhap();
                        nhanViens.Add(nhaKhoaHoc);
                        break;
                    case 2:
                        Console.WriteLine("</> NHAP NHA QUAN LY \t</>");
                        NhaQuanLy nhaQuanLy = new NhaQuanLy();
                        nhaQuanLy.Nhap();
                        nhanViens.Add(nhaQuanLy);
                        break;
                    case 3:
                        Console.WriteLine("</> NHAP NHAN VIEN PTN \t</>");
                        NhanVienPTN nhanVienPTN = new NhanVienPTN();
                        nhanVienPTN.Nhap();
                        nhanViens.Add(nhanVienPTN);
                        break;
                    case 4:
                        Console.WriteLine("</> DANH SACH NHAN VIEN \t</>");
                        foreach (NhanVien nv in nhanViens)
                        {
                            nv.Xuat();
                        }
                        break;
                    case 5:
                        Console.WriteLine("</> LUONG THEO NHAN VIEN \t</>");

                        long luongNVPTNsum = 0;
                        long luongNKHsum = 0;
                        long luongNQLsum = 0;
                        foreach (NhanVien nv in nhanViens)
                        {
                            switch (nv.GetType().Name) 
                            {
                                case "NhanVienPTN":
                                    luongNVPTNsum += nv.Luong;
                                    break;
                                case "NhaKhoaHoc":
                                    luongNKHsum += nv.Luong;
                                    break;
                                case "NhaQuanLy":
                                    luongNQLsum += nv.Luong;
                                    break;
                            }

                        }
                        Console.WriteLine("</> Luong cua nhan vien PTN: \t{0}", luongNVPTNsum);
                        Console.WriteLine("</> Luong cua nha khoa hoc: \t{0}", luongNKHsum);
                        Console.WriteLine("</> Luong cua nha quan ly: \t{0}", luongNQLsum);
                        break;
                    case 0:
                        Console.WriteLine("</> ĐÃ THOÁT THÀNH CÔNG \t</>");
                        break;
                }


            } while (choose != 0);
        }
    }
}
