using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class clsHoaDonBan_BUS
    {
        public static List<clsHoaDonBan_DTO> LayDSHDBan()
        {
            return clsHoaDonBan_DAO.LayDSHDBan();
        }
    }
}
