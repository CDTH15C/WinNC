using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien_DTO
    {
        string _maNV;
        string _hoTen;
        string _diaChi;
        DateTime _ngaySinh;
        string _sDT;
        string _email;
        float _luong;
        string _cMND;
        string _anhDaiDien;
        string _maTaiKhoan;
        int _trangThai;

        public string MaNV
        {
            get
            {
                return _maNV;
            }

            set
            {
                _maNV = value;
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

        public float Luong
        {
            get
            {
                return _luong;
            }

            set
            {
                _luong = value;
            }
        }

        public string CMND
        {
            get
            {
                return _cMND;
            }

            set
            {
                _cMND = value;
            }
        }

        public string AnhDaiDien
        {
            get
            {
                return _anhDaiDien;
            }

            set
            {
                _anhDaiDien = value;
            }
        }

        public string MaTaiKhoan
        {
            get
            {
                return _maTaiKhoan;
            }

            set
            {
                _maTaiKhoan = value;
            }
        }

        public int TrangThai
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
