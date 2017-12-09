using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Size_DTO
    {
        string _maSize;
        string _tenSize;
        bool _trangThai;

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

        public string TenSize
        {
            get
            {
                return _tenSize;
            }

            set
            {
                _tenSize = value;
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
