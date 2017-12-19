using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class clsSanPham_BUS
    {
        public static List<clsSanPham_DTO> RetrieveTable_SanPham(List<string> condition)
        {
            return clsSanPham_DAO.RetrieveTable_SanPham(condition);
        }
        public static clsSanPham_DTO Retrieve_SanPham(string masp)
        {
            return clsSanPham_DAO.Retrieve_SanPham(masp);
        }
        public static bool ThemSanPham(clsSanPham_DTO sp)
        {
            return clsSanPham_DAO.ThemSanPham(sp);
        }
        public static List<clsSanPham_DTO> LayDSSPTheoTen(string tenSP)
        {
            return clsSanPham_DAO.LayDSSPTheoTen(tenSP);
        }
        public static int DemSLSanPham()
        {
            return clsSanPham_DAO.DemSLSanPham();
        }
        public static int DemSLSanPham(string ten)
        {
            return clsSanPham_DAO.DemSLSanPham(ten);
        }
        public static bool CapNhatSanPham(clsSanPham_DTO sp)
        {
            return clsSanPham_DAO.CapNhatSanPham(sp);
        }
    }
}
