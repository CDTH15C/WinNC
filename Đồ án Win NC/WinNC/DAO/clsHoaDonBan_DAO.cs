using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class clsHoaDonBan_DAO
    {
        public static List<clsHoaDonBan_DTO> LayDSHDBan()
        {
            List<clsHoaDonBan_DTO> dsCT = new List<clsHoaDonBan_DTO>();
            string query = "select * from ChiTietHDBan where TrangThai = 1";
            SqlDataReader dr = DataProvider.Retrieve_Table(query);
            while(dr.Read())
            {
                clsHoaDonBan_DTO ct = new clsHoaDonBan_DTO();

                if(!dr.IsDBNull(0))
                {
                    ct.MaHDBan = dr.GetString(0);
                }
                if (!dr.IsDBNull(1))
                {
                    ct.MaNVLap = dr.GetString(1);
                }
                if (!dr.IsDBNull(2))
                {
                    ct.NgayLapHD = dr.GetDateTime(2);
                }
                if (!dr.IsDBNull(3))
                {
                    ct.ThanhTien = dr.GetInt32(3);
                }
                if (!dr.IsDBNull(4))
                {
                    ct.TrangThai = dr.GetBoolean(4);
                }
                dsCT.Add(ct);
            }
            DataProvider.CloseConnect();
            return dsCT;

        }
    }
}
