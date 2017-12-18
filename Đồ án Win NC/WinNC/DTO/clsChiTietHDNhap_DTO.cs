using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class clsChiTietHDNhap_DTO
    {
        string _maHDNhap, _maChiTietSP;
        int _soLuong, _donGia;
        bool _trangThai;

        public int DonGia
        {
            get
            {
                return _donGia;
            }

            set
            {
                _donGia = value;
            }
        }

        public string MaHDNhap
        {
            get
            {
                return _maHDNhap;
            }

            set
            {
                _maHDNhap = value;
            }
        }

        public string MaChiTietSP
        {
            get
            {
                return _maChiTietSP;
            }

            set
            {
                _maChiTietSP = value;
            }
        }

        public int SoLuong
        {
            get
            {
                return _soLuong;
            }

            set
            {
                _soLuong = value;
            }
        }

        public bool TrangThai
        {
            get
            {
                return _trangThai;
            }

            set
            {
                _trangThai = value;
            }
        }
    }
}
