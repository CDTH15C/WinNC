using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class HinhAnh_DTO 
    {
        string _maHinhAnh;
        string _linkAnh;
        bool _trangThai_HA;
        string _maSP_HA;
        SanPham_DTO _sanPham = new SanPham_DTO();
        public string MaHinhAnh
        {
            get
            {
                return _maHinhAnh;
            }

            set
            {
                _maHinhAnh = value;
            }
        }

        public string LinkAnh
        {
            get
            {
                return _linkAnh;
            }

            set
            {
                _linkAnh = value;
            }
        }

        public bool TrangThai_HA
        {
            get
            {
                return _trangThai_HA;
            }

            set
            {
                _trangThai_HA = value;
            }
        }

        public string MaSP_HA
        {
            get
            {
                return _maSP_HA;
            }

            set
            {
                _maSP_HA = value;
            }
        }

        public SanPham_DTO SanPham
        {
            get
            {
                return _sanPham;
            }

            set
            {
                _sanPham = value;
            }
        }
    }
}
