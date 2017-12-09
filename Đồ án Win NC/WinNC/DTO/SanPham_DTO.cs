using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SanPham_DTO : ChiTietSanPham_DTO
    {
        #region Property
        string _maSP;
        string _tenSP;
        string _maChiTietSanPham_SP;
        string _maLoaiSP;
        DateTime _ngayNhapKho;
        decimal _giaNhapKho;
        decimal _giaBan;
        string _gioiTinh;
        bool _trangThai_SP;


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

        public decimal GiaNhapKho
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

        public decimal GiaBan
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

        public string MaChiTietSanPham_SP
        {
            get
            {
                return _maChiTietSanPham_SP;
            }

            set
            {
                _maChiTietSanPham_SP = value;
            }
        }

        public bool TrangThai_SP
        {
            get
            {
                return _trangThai_SP;
            }

            set
            {
                _trangThai_SP = value;
            }
        }

        #endregion
    }
}
