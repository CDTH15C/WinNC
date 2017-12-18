using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class clsNhanVien_BUS
    {
        public static List<clsNhanVien_DTO> LayDsNV()
        {
            return clsNhanVien_DAO.LayDsNV();
        }

        public static bool KtraDangNhap(string TenTaiKhoan, string MatKhau)
        {
            return clsNhanVien_DAO.KtraDangNhap(TenTaiKhoan, MatKhau);
        }
        public static clsNhanVien_DTO LayThongTinNV(string Username)
        {
            return clsNhanVien_DAO.LayThongTinNV(Username);
        } 
    }
}
