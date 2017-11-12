using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiSanPham_DTO
    {
        string _maLoaiSP;
        string _tenLoaiSP;
        bool _trangThai;

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

        public string TenLoaiSP
        {
            get
            {
                return _tenLoaiSP;
            }

            set
            {
                _tenLoaiSP = value;
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
