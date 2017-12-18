using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class clsSanPham_DTO
    {
        #region Property
        string _maSP;
        string _tenSP;
        string _maLoaiSP;
        string _maNhaSX;
        DateTime _ngayNhapKho;
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

        #endregion
    }
}
