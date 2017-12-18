using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;

namespace DAO
{
    public class clsNhaSanXuat_DAO
    {
        public static List<clsNhaSanXuat_DTO> LayDSNSX(string maNSX)
        {
            List<clsNhaSanXuat_DTO> dsNSX = new List<clsNhaSanXuat_DTO>();
            string query = "select * from NhaSanXuat";
            if(maNSX != "")
            {
                query += string.Format(" where MaNhaSx = '{0}'", maNSX); 
            }
            SqlDataReader dr = DataProvider.Retrieve_Table(query);
            while(dr.Read())
            {
                clsNhaSanXuat_DTO nsx = new clsNhaSanXuat_DTO();
                if(!dr.IsDBNull(0))
                {
                    nsx.MaNhaSX = dr.GetString(0);
                }
                if (!dr.IsDBNull(1))
                {
                    nsx.TenNhaSX = dr.GetString(1);
                }
                if (!dr.IsDBNull(2))
                {
                    nsx.DiaChi = dr.GetString(2);
                }
                if (!dr.IsDBNull(3))
                {
                    nsx.Email = dr.GetString(3);
                }
                if (!dr.IsDBNull(4))
                {
                    nsx.SDT = dr.GetString(4);
                }
                if (!dr.IsDBNull(5))
                {
                    nsx.TrangThai = dr.GetBoolean(5);
                }
                dsNSX.Add(nsx);
            }
            DataProvider.CloseConnect();
            return dsNSX;
        }
    }
}
