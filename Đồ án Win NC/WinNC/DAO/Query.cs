using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class Query
    {
        // NHANVIEN , MATAIKHOAN , LOAITAIKHOAN
        public static string dsThongTinhNhanVien = @"SELECT * FROM NhanVien,TaiKhoan,LoaiTaiKhoan WHERE NhanVien.MaTaiKhoan = TaiKhoan.MaTaiKhoan AND TaiKhoan.MaLoaiTK = LoaiTaiKhoan.MaLoaiTK AND NhanVien.TrangThai = 1";
 
        // TaiKhoan
        public static string Ktra_TaiKhoan_MatKhau = @"SELECT COUNT(*) FROM TaiKhoan WHERE TaiKhoan.TenTaiKhoan = '{0}' AND TaiKhoan.MatKhau = '{1}'";

        // SanPham,ChiTietSanPham,Size,Mau,ChatLieu

        public static string dsThongTinSanPham = @"SELECT * FROM SanPham,ChiTietSanPham,Mau,Size,ChatLieu WHERE SanPham.MaChiTietSanPham = ChiTietSanPham.MaChiTietSanPham AND ChiTietSanPham.MaMau = Mau.MaMau AND ChiTietSanPham.MaSize = Size.MaSize AND ChiTietSanPham.MaChatLieu = ChatLieu.MaChatLieu AND SanPham.TrangThai = 1";
    }
}
