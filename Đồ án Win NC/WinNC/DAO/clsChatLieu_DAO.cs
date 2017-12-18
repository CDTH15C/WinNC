using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
namespace DAO
{
    public class clsChatLieu_DAO
    {
        public static List<clsChatLieu_DTO> LayDSChatLieu()
        {
            List<clsChatLieu_DTO> dsCL = new List<clsChatLieu_DTO>();
            string query = "select * from ChatLieu";
            SqlDataReader dr = DataProvider.Retrieve_Table(query);

            while(dr.Read())
            {
                clsChatLieu_DTO ChatLieu = new clsChatLieu_DTO();
                if(!dr.IsDBNull(0))
                {
                    ChatLieu.MaChatLieu = dr.GetString(0);
                }
                if (!dr.IsDBNull(1))
                {
                    ChatLieu.TenChatLieu = dr.GetString(1);
                }
                if (!dr.IsDBNull(2))
                {
                    ChatLieu.TrangThai = dr.GetBoolean(2);
                }
                dsCL.Add(ChatLieu);
            }

            DataProvider.CloseConnect();
            return dsCL;
        }

        public static clsChatLieu_DTO LayChatLieu(string maCL)
        {
            clsChatLieu_DTO ChatLieu = new clsChatLieu_DTO();
            string query = string.Format("select * from ChatLieu where MaChatLieu = '{0}'", maCL);
            SqlDataReader dr = DataProvider.Retrieve_Table(query);

            if (dr.Read())
            {
                if (!dr.IsDBNull(0))
                {
                    ChatLieu.MaChatLieu = dr.GetString(0);
                }
                if (!dr.IsDBNull(1))
                {
                    ChatLieu.TenChatLieu = dr.GetString(1);
                }
                if (!dr.IsDBNull(2))
                {
                    ChatLieu.TrangThai = dr.GetBoolean(2);
                }
            }

            DataProvider.CloseConnect();
            return ChatLieu;
        }
    }
}
