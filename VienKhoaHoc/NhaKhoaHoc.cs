using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VienKhoaHoc
{
    public class NhaKhoaHoc : NhaQuanLy
    {
        private int soBaiBao;

        public int SoBaiBao { get => soBaiBao; set => soBaiBao = value; }

        public NhaKhoaHoc(int soBaiBao)
        {
            this.soBaiBao = soBaiBao;
        }

        public NhaKhoaHoc()
        {
        }
        public override void Nhap()
        {
            base.Nhap();

            #region nhập số bài báo
            bool soBaiBaoBool = false;
            do
            {
                Console.WriteLine("</> So bai bao: \t</>");
                string soBaiBaoStr = Console.ReadLine();
                int soBaiBaoInt;
                soBaiBaoBool = int.TryParse(soBaiBaoStr, out soBaiBaoInt);
                if (soBaiBaoBool == false)
                {
                    Console.WriteLine("</> Sai kieu du lieu so bai bao, vui long nhap lai! </>");

                }
                else
                {
                    this.soBaiBao = soBaiBaoInt;
                }
            } while (soBaiBaoBool == false);
            #endregion


        }

        public override void Xuat()
        {
            base.Xuat();//ctrl K D sap xep code
            Console.WriteLine("</> So bai bao:{0} \t</>", this.soBaiBao);
        }

        
    }
}
