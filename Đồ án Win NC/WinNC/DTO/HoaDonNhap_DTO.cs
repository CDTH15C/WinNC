using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class HoaDonNhap_DTO
    {
        string _maHDNhap;
        string _maNVLap;
        DateTime _ngayLapHD;
        decimal _tongTien;
        string _maNhaSX;
        bool _trangThai;

        public string MaHDNhap
        {
            get
            {
                return _maHDNhap;
            }

            set
            {
                _maHDNhap = value;
            }
        }

        public string MaNVLap
        {
            get
            {
                return _maNVLap;
            }

            set
            {
                _maNVLap = value;
            }
        }

        public DateTime NgayLapHD
        {
            get
            {
                return _ngayLapHD;
            }

            set
            {
                _ngayLapHD = value;
            }
        }

        public decimal TongTien
        {
            get
            {
                return _tongTien;
            }

            set
            {
                _tongTien = value;
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
