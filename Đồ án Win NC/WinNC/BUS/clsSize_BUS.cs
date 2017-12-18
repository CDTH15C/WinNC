using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class clsSize_BUS
    {
        public static List<clsSize_DTO> Retrieve_Size(string condition)
        {
            return clsSize_DAO.Retrieve_Size(condition);
        }
        public static clsSize_DTO LaySize(string maSize)
        {
            return clsSize_DAO.LaySize(maSize);
        }
    }
}
