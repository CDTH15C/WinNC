using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;
namespace DAO
{
    public class Size_DAO
    {
        public List<Size_DTO> Retrieve_Size(string condition)
        {
            List<Size_DTO> dsSize = new List<Size_DTO>();
            string sql = @"select * from Size where trangthai = 1";
            SqlDataReader dr = DataProvider.Retrieve_Table(sql);
            while(dr.Read())
            {
                Size_DTO size = new Size_DTO();
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
            return dsSize;
        }
    }
}
