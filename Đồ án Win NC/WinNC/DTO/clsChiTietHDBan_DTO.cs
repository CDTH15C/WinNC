using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class clsChiTietHDBan_DTO
    {
        string maHDBan, maChiTietSP;
        int donGia, soLuong;
        bool trangThai;

        public string MaHDBan
        {
            get
            {
                return maHDBan;
            }

            set
            {
                maHDBan = value;
            }
        }

        public string MaChiTietSP
        {
            get
            {
                return maChiTietSP;
            }

            set
            {
                maChiTietSP = value;
            }
        }

        public int DonGia
        {
            get
            {
                return donGia;
            }

            set
            {
                donGia = value;
            }
        }

        public int SoLuong
        {
            get
            {
                return soLuong;
            }

            set
            {
                soLuong = value;
            }
        }

        public bool TrangThai
        {
            get
            {
                return trangThai;
            }

            set
            {
                trangThai = value;
            }
        }
    }
}
