using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class clsChatLieu_BUS
    {
        public static List<clsChatLieu_DTO> LayDSChatLieu()
        {
            return clsChatLieu_DAO.LayDSChatLieu();
        }
        public static clsChatLieu_DTO LayDSChatLieu(string maCL)
        {
            return clsChatLieu_DAO.LayChatLieu(maCL);
        }
    }
}
