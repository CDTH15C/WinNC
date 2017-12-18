using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class clsChiTietHDNhap_BUS
    {
        public static List<clsChiTietHDNhap_DTO> LayDSCTHDNhap(string maCTSP)
        {
            return clsChiTietHDNhap_DAO.LayDSCTHDNhap(maCTSP);
        }
        public static bool ThemChiTietHDNhap(clsChiTietHDNhap_DTO cthd)
        {
            return clsChiTietHDNhap_DAO.ThemChiTietHDNhap(cthd);
        }
    }
}
