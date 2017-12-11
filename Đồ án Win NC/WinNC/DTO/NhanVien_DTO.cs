using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien_DTO : TaiKhoan_DTO
    {
        string _maNV;
        string _hoTen;
        string _diaChi;
        DateTime _ngaySinh;
        string _sDT;
        string _email;
        decimal _luong;
        string _cMND;
        string _anhDaiDien;
        string _maTaiKhoan_NV;
        bool _trangThai_NV;

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

        public decimal Luong
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

        public string MaTaiKhoan_NV
        {
            get
            {
                return _maTaiKhoan_NV;
            }

            set
            {
                _maTaiKhoan_NV = value;
            }
        }

        public bool TrangThai_NV
        {
            get
            {
                return _trangThai_NV;
            }

            set
            {
                _trangThai_NV = value;
            }
        }

        /* public string MaTaiKhoan
         {
             get
             {
                 return _maTaiKhoan;
             }

             set
             {
                 _maTaiKhoan = value;
             }
         }*/


    }
}
