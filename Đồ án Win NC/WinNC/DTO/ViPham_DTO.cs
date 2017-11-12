using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ViPham_DTO
    {
        string _maViPham;
        string _maNV;
        string _maCaLamViec;
        DateTime _ngayLamViec;
        float _soTienBiTru;
        string _noiDung;
        bool _trangThai;

        public string MaViPham
        {
            get
            {
                return _maViPham;
            }

            set
            {
                _maViPham = value;
            }
        }

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

        public float SoTienBiTru
        {
            get
            {
                return _soTienBiTru;
            }

            set
            {
                _soTienBiTru = value;
            }
        }

        public string NoiDung
        {
            get
            {
                return _noiDung;
            }

            set
            {
                _noiDung = value;
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
