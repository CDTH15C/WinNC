using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class clsChiTietSanPham_BUS
    {
        public static List<clsChiTietSanPham_DTO> Retrieve_ChiTietSanPham(string tenSP, string maMau, string maCL, string maSize, bool lonHon, int soLuong, int giaBanMin, int giaBanMax, string loaiSP)
        {
            return clsChiTietSanPham_DAO.Retrieve_ChiTietSanPham(tenSP, maMau, maCL, maSize, lonHon, soLuong, giaBanMin, giaBanMax, loaiSP);
        }
        public static List<clsChiTietSanPham_DTO> Retrieve_ChiTietSanPham(string maSP, string maMau, string maChatLieu, string maSize)
        {
            return clsChiTietSanPham_DAO.Retrieve_ChiTietSanPham(maSP, maMau, maChatLieu, maSize);
        }
        public static bool ThemChiTietSP(clsChiTietSanPham_DTO ctsp)
        {
            return clsChiTietSanPham_DAO.ThemChiTietSP(ctsp);
        }
        public static List<clsChiTietSanPham_DTO> LayDSCTSPTheoMaSP(string maSP)
        {
            return clsChiTietSanPham_DAO.LayDSCTSPTheoMaSP(maSP);
        }
        public static bool CapNhatSoLuong(string maCTSP, int SL)
        {
            int n = SL + LaySoLuongTonKho(maCTSP);
            return clsChiTietSanPham_DAO.CapNhatSoLuong(maCTSP, n);
        }
        public static int LaySoLuongTonKho(string maCTSP)
        {
            return clsChiTietSanPham_DAO.LaySoLuongTonKho(maCTSP);
        }
        public static bool CapNhatTrangThai(bool trangThai, string maSP, string maMau, string maChatLieu, string maSize)
        {
            return clsChiTietSanPham_DAO.CapNhatTrangThai(trangThai, maSP, maMau, maChatLieu, maSize);
        }
        public static bool CapNhatCTSP(clsChiTietSanPham_DTO ctsp)
        {
            return clsChiTietSanPham_DAO.CapNhatCTSP(ctsp);
        }
        
    }
}