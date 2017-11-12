using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoan_DTO : LoaiTaiKhoan_DTO
    {
        string _maTaiKhoan;
        string _tenTaiKhoan;
        string _matKhau;
        DateTime _ngayTao;
        string _maLoaiTK_TK;
        bool _trangThai_TK;

        public string MaTaiKhoan
        {
            get
            {
                return _maTaiKhoan;
            }

            set
            {
                _maTaiKhoan = value;
            }
        }

        public string TenTaiKhoan
        {
            get
            {
                return _tenTaiKhoan;
            }

            set
            {
                _tenTaiKhoan = value;
            }
        }

        public string MatKhau
        {
            get
            {
                return _matKhau;
            }

            set
            {
                _matKhau = value;
            }
        }

        public DateTime NgayTao
        {
            get
            {
                return _ngayTao;
            }

            set
            {
                _ngayTao = value;
            }
        }

        public bool TrangThai_TK
        {
            get
            {
                return _trangThai_TK;
            }

            set
            {
                _trangThai_TK = value;
            }
        }

        public string MaLoaiTK_TK
        {
            get
            {
                return _maLoaiTK_TK;
            }

            set
            {
                _maLoaiTK_TK = value;
            }
        }

        /* public string MaLoaiTK
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
         */

    }
}
