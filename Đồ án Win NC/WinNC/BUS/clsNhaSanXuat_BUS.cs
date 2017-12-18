using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class clsNhaSanXuat_BUS
    {
        public static List<clsNhaSanXuat_DTO> LayDSNSX(string maNSX)
        {
            return clsNhaSanXuat_DAO.LayDSNSX(maNSX);
        }
    }
}
