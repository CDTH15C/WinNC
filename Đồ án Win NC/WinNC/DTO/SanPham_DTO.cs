using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SanPham_DTO
    {
        #region Property
        string _maSP;
        string _tenSP;
        string _maChiTietSanPham;
        string _maLoaiSP;
        DateTime _ngayNhapKho;
        float _giaNhapKho;
        float _giaBan;
        string _gioiTinh;
        bool _trangThai;

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

        public string TenSP
        {
            get
            {
                return _tenSP;
            }

            set
            {
                _tenSP = value;
            }
        }

        public string MaChiTietSanPham
        {
            get
            {
                return _maChiTietSanPham;
            }

            set
            {
                _maChiTietSanPham = value;
            }
        }

        public string MaLoaiSP
        {
            get
            {
                return _maLoaiSP;
            }

            set
            {
                _maLoaiSP = value;
            }
        }

        public DateTime NgayNhapKho
        {
            get
            {
                return _ngayNhapKho;
            }

            set
            {
                _ngayNhapKho = value;
            }
        }

        public float GiaNhapKho
        {
            get
            {
                return _giaNhapKho;
            }

            set
            {
                _giaNhapKho = value;
            }
        }

        public float GiaBan
        {
            get
            {
                return _giaBan;
            }

            set
            {
                _giaBan = value;
            }
        }

        public string GioiTinh
        {
            get
            {
                return _gioiTinh;
            }

            set
            {
                _gioiTinh = value;
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
        #endregion
    }
}
