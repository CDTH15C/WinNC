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
        bool _trangThai;
        string _maSP;

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
    }
}
