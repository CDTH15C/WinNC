using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class clsChiTietHoaDonBan_DTO
    {
        string maChiTietSP, maHDBan;
        int donGiaBan, soLuong;
        bool trangThai;

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

        public int DonGiaBan
        {
            get
            {
                return donGiaBan;
            }

            set
            {
                donGiaBan = value;
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
