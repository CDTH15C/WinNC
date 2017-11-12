using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;
namespace DAO
{
   public class HinhAnh_DAO
    {
        // retrive_HinhAnh theo MaSP
        public List<HinhAnh_DTO> Retrieve_HinhAnh(string condition)
        {
            List<HinhAnh_DTO> dsHinhAnh = new List<HinhAnh_DTO>();
            string sql = @"select * from HinhAnh where TrangThai = 1";
            if(condition != "")
            {
                sql += string.Format(" And MaSP = '{0}'", condition);
            }
           SqlDataReader dr =  DataProvider.Retrieve_Table(sql);
            while(dr.Read())
            {
                HinhAnh_DTO ha = new HinhAnh_DTO();
                if(!dr.IsDBNull(0))
                {
                    ha.MaHinhAnh = (string)dr["MaHinhAnh"];
                }
                if (!dr.IsDBNull(1))
                {
                    ha.LinkAnh = (string)dr["LinkAnh"];
                }
                if (!dr.IsDBNull(2))
                {
                    ha.TrangThai = (Boolean)dr["TrangThai"];
                }
                if (!dr.IsDBNull(3))
                {
                    ha.MaSP = (string)dr["MaSP"];
                }
                dsHinhAnh.Add(ha);
            }
            return dsHinhAnh;
        }
    }
}
