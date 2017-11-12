using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietSanPham_DTO
    {
        string _maChiTietSanPham;
        string _maMau;
        string _maChatLieu;
        string _maSize;
        int _soLuongTonKho;
        decimal _giaTien;
        bool _trangThai;


        Mau_DTO _mau = new Mau_DTO();
        Size_DTO _size = new Size_DTO();
        ChatLieu_DTO _chatLieu = new ChatLieu_DTO();

      

        public string MaChiTietSanPham
        {
            get
            {
                return _maChiTietSanPham;
            }

            set
            {
                _maChiTietSanPham = value;
            }
        }

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

        public int SoLuongTonKho
        {
            get
            {
                return _soLuongTonKho;
            }

            set
            {
                _soLuongTonKho = value;
            }
        }

        public decimal GiaTien
        {
            get
            {
                return _giaTien;
            }

            set
            {
                _giaTien = value;
            }
        }

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

        public string MaChatLieu
        {
            get
            {
                return _maChatLieu;
            }

            set
            {
                _maChatLieu = value;
            }
        }

        public Mau_DTO Mau
        {
            get
            {
                return _mau;
            }

            set
            {
                _mau = value;
            }
        }

       
        public ChatLieu_DTO ChatLieu
        {
            get
            {
                return _chatLieu;
            }

            set
            {
                _chatLieu = value;
            }
        }

        public Size_DTO Size
        {
            get
            {
                return _size;
            }

            set
            {
                _size = value;
            }
        }
    }
}
