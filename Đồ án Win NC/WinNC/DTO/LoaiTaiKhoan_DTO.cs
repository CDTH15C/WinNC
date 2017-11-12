using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class LoaiTaiKhoan_DTO
    {
        string _maLoaiTK;
        string _tenLoaiTK;
        bool _trangThai;

        public string MaLoaiTK
        {
            get
            {
                return _maLoaiTK;
            }

            set
            {
                _maLoaiTK = value;
            }
        }

        public string TenLoaiTK
        {
            get
            {
                return _tenLoaiTK;
            }

            set
            {
                _tenLoaiTK = value;
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
