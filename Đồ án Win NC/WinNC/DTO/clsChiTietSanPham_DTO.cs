using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class clsChiTietSanPham_DTO
    {
        string _maChiTietSP;
        string _maSP;
        string _maMau;
        string _maChatLieu;
        string _maSize;
        string _hinhAnh;
        int _soLuongTonKho;
        int _giaTien;
        bool _trangThai;
      
        public string MaMau
        {
            get
            {
                return _maMau;
            }

            set
            {
                _maMau = value;
            }
        }

        public int SoLuongTonKho
        {
            get
            {
                return _soLuongTonKho;
            }

            set
            {
                _soLuongTonKho = value;
            }
        }

        public int GiaTien
        {
            get
            {
                return _giaTien;
            }

            set
            {
                _giaTien = value;
            }
        }

        public string MaSize
        {
            get
            {
                return _maSize;
            }

            set
            {
                _maSize = value;
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

        public string MaChatLieu
        {
            get
            {
                return _maChatLieu;
            }

            set
            {
                _maChatLieu = value;
            }
        }

        public string MaSP
        {
            get
            {
                return _maSP;
            }

            set
            {
                _maSP = value;
            }
        }

        public string HinhAnh
        {
            get
            {
                return _hinhAnh;
            }

            set
            {
                _hinhAnh = value;
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
    }
}
