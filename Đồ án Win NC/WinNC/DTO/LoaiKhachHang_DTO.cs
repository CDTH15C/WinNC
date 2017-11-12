using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiKhachHang_DTO
    {
        string _maLoaiKH;
        string _tenLoaiKH;
        int _phanTramGiamGia;
        bool _trangThai;

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

        public string TenLoaiKH
        {
            get
            {
                return _tenLoaiKH;
            }

            set
            {
                _tenLoaiKH = value;
            }
        }

        public int PhanTramGiamGia
        {
            get
            {
                return _phanTramGiamGia;
            }

            set
            {
                _phanTramGiamGia = value;
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
