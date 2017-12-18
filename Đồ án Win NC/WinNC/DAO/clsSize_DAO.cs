using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;
namespace DAO
{
    public class clsSize_DAO
    {
        public static List<clsSize_DTO> Retrieve_Size(string condition)
        {
            List<clsSize_DTO> dsSize = new List<clsSize_DTO>();
            string sql = @"select * from Size where trangthai = 1";
            SqlDataReader dr = DataProvider.Retrieve_Table(sql);
            while(dr.Read())
            {
                clsSize_DTO size = new clsSize_DTO();
                if(!dr.IsDBNull(0))
                {
                    size.MaSize = (string)dr["MaSize"];
                }
                if (!dr.IsDBNull(1))
                {
                    size.TenSize = (string)dr["TenSize"];
                }
                if (!dr.IsDBNull(2))
                {
                    size.TrangThai = (Boolean)dr["TrangThai"];
                }
                dsSize.Add(size);
            }
            DataProvider.CloseConnect();
            return dsSize;
        }

        public static clsSize_DTO LaySize(string maSize)
        {
            clsSize_DTO size = new clsSize_DTO();
            string sql = string.Format("select * from Size where trangthai = 1 and MaSize = '{0}'", maSize);
            SqlDataReader dr = DataProvider.Retrieve_Table(sql);
            if (dr.Read())
            {
                if (!dr.IsDBNull(0))
                {
                    size.MaSize = (string)dr["MaSize"];
                }
                if (!dr.IsDBNull(1))
                {
                    size.TenSize = (string)dr["TenSize"];
                }
                if (!dr.IsDBNull(2))
                {
                    size.TrangThai = (Boolean)dr["TrangThai"];
                }
            }
            DataProvider.CloseConnect();
            return size;
        }
    }
}
