using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class clsMau_BUS
    {
        public static List<clsMau_DTO> Retrieve_Mau(string condition)
        {
            return clsMau_DAO.Retrieve_Mau(condition);
        }
        public static clsMau_DTO LayMau(string maMau)
        {
            return clsMau_DAO.LayMau(maMau);
        }
    }
}
