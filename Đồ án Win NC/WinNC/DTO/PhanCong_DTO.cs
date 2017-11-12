using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhanCong_DTO
    {
        string _maNV;
        string _maCaLamViec;
        DateTime _ngayLamViec;
        bool _coDiLam;

        public string MaNV
        {
            get
            {
                return _maNV;
            }

            set
            {
                _maNV = value;
            }
        }

        public string MaCaLamViec
        {
            get
            {
                return _maCaLamViec;
            }

            set
            {
                _maCaLamViec = value;
            }
        }

        public DateTime NgayLamViec
        {
            get
            {
                return _ngayLamViec;
            }

            set
            {
                _ngayLamViec = value;
            }
        }

        public bool CoDiLam
        {
            get
            {
                return _coDiLam;
            }

            set
            {
                _coDiLam = value;
            }
        }
    }
}
