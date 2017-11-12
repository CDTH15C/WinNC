using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonBan_DTO
    {
        string _maHDBan;
        string _maKH;
        string _maNVLap;
        DateTime _ngayLapHD;
        decimal _thanhTien;
        bool _trangThai;

        public string MaHDBan
        {
            get
            {
                return _maHDBan;
            }

            set
            {
                _maHDBan = value;
            }
        }

        public string MaKH
        {
            get
            {
                return _maKH;
            }

            set
            {
                _maKH = value;
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

        public decimal ThanhTien
        {
            get
            {
                return _thanhTien;
            }

            set
            {
                _thanhTien = value;
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
