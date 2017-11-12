using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHang_DTO
    {
        string _maKH;
        string _hoTen;
        string _diaChi;
        DateTime _ngaySinh;
        string _sDT;
        string _email;
        string _tenDangNhap;
        string _matKhau;
        string cMND;
        string _maLoaiKH;
        bool _trangThai;

        public string MaKH
        {
            get
            {
                return _maKH;
            }

            set
            {
                _maKH = value;
            }
        }

        public string HoTen
        {
            get
            {
                return _hoTen;
            }

            set
            {
                _hoTen = value;
            }
        }

        public string DiaChi
        {
            get
            {
                return _diaChi;
            }

            set
            {
                _diaChi = value;
            }
        }

        public DateTime NgaySinh
        {
            get
            {
                return _ngaySinh;
            }

            set
            {
                _ngaySinh = value;
            }
        }

        public string SDT
        {
            get
            {
                return _sDT;
            }

            set
            {
                _sDT = value;
            }
        }

        public string Email
        {
            get
            {
                return _email;
            }

            set
            {
                _email = value;
            }
        }

        public string TenDangNhap
        {
            get
            {
                return _tenDangNhap;
            }

            set
            {
                _tenDangNhap = value;
            }
        }

        public string MatKhau
        {
            get
            {
                return _matKhau;
            }

            set
            {
                _matKhau = value;
            }
        }

        public string CMND
        {
            get
            {
                return cMND;
            }

            set
            {
                cMND = value;
            }
        }

        public string MaLoaiKH
        {
            get
            {
                return _maLoaiKH;
            }

            set
            {
                _maLoaiKH = value;
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
