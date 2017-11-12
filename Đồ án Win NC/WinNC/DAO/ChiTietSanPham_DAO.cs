using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;


namespace DAO
{
    public class ChiTietSanPham_DAO
    {
        public List<ChiTietSanPham_DTO> Retrieve_ChiTietSanPham()
        {
            List<ChiTietSanPham_DTO> dsChiTietSP = new List<ChiTietSanPham_DTO>();

            string sql = @"select * from ChiTietSanPham where trangthai = 1";
            
            SqlDataReader dr = DataProvider.Retrieve_Table(sql);
            while(dr.Read())
            {
                ChiTietSanPham_DTO ctsp = new ChiTietSanPham_DTO();
                if (!dr.IsDBNull(0))
                {
                    ctsp.MaChiTietSanPham = (string)dr["MaChiTietSanPham"];
                }
                if (!dr.IsDBNull(1))
                {
                    ctsp.MaMau = (string)dr["MaMau"];
                }
                if (!dr.IsDBNull(2))
                {
                    ctsp.MaChatLieu = (string)dr["MaChatLieu"];
                }
                if (!dr.IsDBNull(3))
                {
                    ctsp.MaSize = (string)dr["MaSize"];
                }
                if (!dr.IsDBNull(4))
                {
                    ctsp.SoLuongTonKho = (int)dr["SoLuongTonKho"];
                }
                if (!dr.IsDBNull(5))
                {
                    ctsp.GiaTien = (int)dr["GiaTien"];
                }
                if (!dr.IsDBNull(6))
                {
                    ctsp.TrangThai = (Boolean)dr["TrangThai"];
                }
                dsChiTietSP.Add(ctsp);
            }
            return dsChiTietSP;
        }
    }
}
