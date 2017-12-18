using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class clsHoaDonNhap_DAO
    {
        public static List<clsHoaDonNhap_DTO> LayDSHD(string maHD)
        {
            List<clsHoaDonNhap_DTO> dsHDNhap = new List<clsHoaDonNhap_DTO>();
            string query = string.Format("select * from HoaDonNhap");
            if(maHD != "")
            {
                query += string.Format(" where MaHDNhap = '{0}'", maHD);
            }
            SqlDataReader dr = DataProvider.Retrieve_Table(query);
            while(dr.Read())
            {
                clsHoaDonNhap_DTO hd = new clsHoaDonNhap_DTO();

                if(!dr.IsDBNull(0))
                {
                    hd.MaHDNhap = dr.GetString(0);
                }

                if (!dr.IsDBNull(1))
                {
                    hd.MaNVLap = dr.GetString(1);
                }

                if (!dr.IsDBNull(2))
                {
                    hd.NgayLapHD = dr.GetDateTime(2);
                }

                if (!dr.IsDBNull(3))
                {
                    hd.TongTien = dr.GetDecimal(3);
                }

                if (!dr.IsDBNull(4))
                {
                    hd.TrangThai = dr.GetBoolean(4);
                }

                dsHDNhap.Add(hd);
            }
            DataProvider.CloseConnect();
            return dsHDNhap;

        }

        public static bool ThemHDNhap(clsHoaDonNhap_DTO hd)
        {
            string query = string.Format("insert into HoaDonNhap(MaHdNhap, MaNVLap, NgayLapHD, TongTien, TrangThai) values('{0}', '{1}', '{2}',{3}, '{4}')", hd.MaHDNhap, hd.MaNVLap, hd.NgayLapHD, hd.TongTien, hd.TrangThai);
            int kq = DataProvider.ExecuteInsertUpdateDelete(query);
            DataProvider.CloseConnect();
            return kq == 1;
        }
    }
}
