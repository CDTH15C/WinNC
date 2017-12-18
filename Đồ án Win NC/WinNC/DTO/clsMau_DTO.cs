using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class clsMau_DTO
    {
        string _maMau;
        string _tenMau;
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

        public string TenMau
        {
            get
            {
                return _tenMau;
            }

            set
            {
                _tenMau = value;
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
