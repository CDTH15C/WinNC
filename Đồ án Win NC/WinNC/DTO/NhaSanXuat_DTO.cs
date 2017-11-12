using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhaSanXuat_DTO
    {
        string _maNhaSX;
        string _tenNhaSX;
        string _diaChi;
        string _email;
        string _sDT;
        bool _trangThai;

        public string MaNhaSX
        {
            get
            {
                return _maNhaSX;
            }

            set
            {
                _maNhaSX = value;
            }
        }

        public string TenNhaSX
        {
            get
            {
                return _tenNhaSX;
            }

            set
            {
                _tenNhaSX = value;
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
