using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
   public class clsMau_DAO
    {
        public static List<clsMau_DTO> Retrieve_Mau(string condition)
        {
            List<clsMau_DTO> dsMau = new List<clsMau_DTO>();
            string sql = @"select * from Mau where trangthai = 1";
            SqlDataReader dr = DataProvider.Retrieve_Table(sql);
            while (dr.Read())
            {
                clsMau_DTO mau = new clsMau_DTO();
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
            DataProvider.CloseConnect();
            return dsMau;
        }

        public static clsMau_DTO LayMau(string maMau)
        {
            clsMau_DTO mau = new clsMau_DTO();
            string sql = string.Format("select * from Mau where MaMau = '{0}'", maMau);
            SqlDataReader dr = DataProvider.Retrieve_Table(sql);
            if (dr.Read())
            {
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
            }
            DataProvider.CloseConnect();
            return mau;
        }
    }
}
