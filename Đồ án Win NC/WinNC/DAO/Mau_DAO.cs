using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
   public class Mau_DAO
    {
        public List<Mau_DTO> Retrieve_Mau(string condition)
        {
            List<Mau_DTO> dsMau = new List<Mau_DTO>();
            string sql = @"select * from Mau where trangthai = 1";
            SqlDataReader dr = DataProvider.Retrieve_Table(sql);
            while (dr.Read())
            {
                Mau_DTO mau = new Mau_DTO();
                if (!dr.IsDBNull(0))
                {
                    mau.MaMau = (string)dr["MaMau"];
                }
                if (!dr.IsDBNull(1))
                {
                    mau.TenMau = (string)dr["TenMau"];
                }
                if (!dr.IsDBNull(2))
                {
                    mau.TrangThai = (Boolean)dr["TrangThai"];
                }
                dsMau.Add(mau);
            }
            return dsMau;
        }
    }
}
