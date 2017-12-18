using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class clsChiTietHDNhap_DAO
    {
        public static List<clsChiTietHDNhap_DTO> LayDSCTHDNhap(string maCTSP)
        {
            List<clsChiTietHDNhap_DTO> dsCTHD = new List<clsChiTietHDNhap_DTO>();
            string query = "select * from ChiTietHDNhap ";
            if(maCTSP != "")
            {
                query += string.Format(" where MaChiTietSP = '{0}'", maCTSP);
            }
            SqlDataReader dr = DataProvider.Retrieve_Table(query);
            while(dr.Read())
            {
                clsChiTietHDNhap_DTO cthd = new clsChiTietHDNhap_DTO();
                if(!dr.IsDBNull(0))
                {
                    cthd.MaHDNhap = dr.GetString(0);
                }

                if (!dr.IsDBNull(1))
                {
                    cthd.MaChiTietSP = dr.GetString(1);
                }
                if (!dr.IsDBNull(2))
                {
                    cthd.DonGia = dr.GetInt32(2);
                }

                if (!dr.IsDBNull(3))
                {
                    cthd.SoLuong = dr.GetInt32(3);
                }

                if (!dr.IsDBNull(4))
                {
                    cthd.TrangThai = dr.GetBoolean(4);
                }
                dsCTHD.Add(cthd);
            }
            DataProvider.CloseConnect();
            return dsCTHD;
        }

        public static bool ThemChiTietHDNhap(clsChiTietHDNhap_DTO cthd)
        {
            string query = string.Format("insert into ChiTietHDNhap(MaHDNhap, MaChiTietSP, DonGiaNhap, SoLuong, TrangThai) values('{0}', '{1}', {2}, {3} ,'{4}')", cthd.MaHDNhap, cthd.MaChiTietSP, cthd.DonGia, cthd.SoLuong, cthd.TrangThai);
            int kq = DataProvider.ExecuteInsertUpdateDelete(query);
            DataProvider.CloseConnect();
            return kq == 1;
        }
    }
}
