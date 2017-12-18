using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class clsHoaDonNhap_BUS
    {
        public static List<clsHoaDonNhap_DTO> LayDSHD(string maHD)
        {
            return clsHoaDonNhap_DAO.LayDSHD(maHD);
        }
        public static bool ThemHDNhap(clsHoaDonNhap_DTO hd)
        {
            return clsHoaDonNhap_DAO.ThemHDNhap(hd);
        }
    }
}
