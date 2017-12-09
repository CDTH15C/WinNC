using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class NhanVien_BUS
    {
        public List<NhanVien_DTO> LayDsNV()
        {
            NhanVien_DAO obj = new NhanVien_DAO();
            return obj.LayDsNV();
        }

        public bool KtraDangNhap(string TenTaiKhoan, string MatKhau)
        {
            NhanVien_DAO obj = new NhanVien_DAO();
            return obj.KtraDangNhap(TenTaiKhoan, MatKhau);
        }
        public NhanVien_DTO LayThongTinNV(string Username)
        {
            NhanVien_DAO obj = new NhanVien_DAO();
            return obj.LayThongTinNV(Username);
        } 
    }
}
