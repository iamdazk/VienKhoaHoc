using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VienKhoaHoc
{
    public class NhanVien
    {
        private string hoTen;
        private int namSinh;
        private string bangCap;
        private long luong;

        public NhanVien()
        {
        }

        public NhanVien(string hoTen, int namSinh, string bangCap)
        {
            this.hoTen = hoTen;
            this.namSinh = namSinh;
            this.bangCap = bangCap;
        }

        public string HoTen { get => hoTen; set => hoTen = value; }
        public int NamSinh { get => namSinh; set => namSinh = value; }
        public string BangCap { get => bangCap; set => bangCap = value; }
        public long Luong { get => luong; protected set => luong = value; }

        public virtual void Nhap()
        {
            Console.WriteLine("</> NHAP THONG TIN </>");
            
            #region nhập họ tên
            Console.WriteLine("</> Ho ten: \t</>");
            this.hoTen = Console.ReadLine();
            #endregion

            #region nhập năm sinh
            bool namSinhBool = false; 
            do
            {
                Console.WriteLine("</> Nam sinh: \t</>");
                string namSinhStr = Console.ReadLine();
                int namSinhInt;
                namSinhBool = int.TryParse(namSinhStr, out namSinhInt);
                if (namSinhBool == false) // !namSinhBool
                {
                    Console.WriteLine("</> Sai kieu du lieu nam sinh, vui long nhap lai! </>");
                    
                }
                else
                {
                    this.namSinh = namSinhInt;
                }
            } while (namSinhBool == false);//!namSinhBool
            #endregion

            #region nhập họ tên
            Console.WriteLine("</> Bang cap: \t</>");
            this.bangCap = Console.ReadLine();
            #endregion

        }
        
        public virtual void Xuat()
        {
            Console.WriteLine("</> =========================== </>");
            Console.WriteLine("</> XUAT THONG TIN </>");
            Console.WriteLine("</> Loai NV:\t{0}\t </>", this.GetType().Name);
            Console.WriteLine("</> Ho ten:\t{0} </>",this.hoTen);
            Console.WriteLine("</> Nam sinh:\t{0} \t\t</>",this.namSinh);
            Console.WriteLine("</> Bang cap:\t{0} \t\t</>",this.bangCap);
        }
    }
}
