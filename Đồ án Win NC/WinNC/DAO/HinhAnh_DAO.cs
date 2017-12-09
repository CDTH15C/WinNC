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
                    ha.TrangThai_HA = (Boolean)dr["TrangThai"];
                }
                if (!dr.IsDBNull(3))
                {
                    ha.MaSP_HA = (string)dr["MaSP"];
                }
                dsHinhAnh.Add(ha);
            }
            return dsHinhAnh;
        }

        public List<HinhAnh_DTO> layDsHinhAnh(string condition)
        {
            List<HinhAnh_DTO> dsHA = new List<HinhAnh_DTO>();
            string sql = "";
           if(condition == "BanChay")
            {
                sql = Query.spBanChay;
            }
           else
            {
                sql = Query.spBanCham;
            }
            SqlDataReader dr = DataProvider.Retrieve_Table(sql);
            while(dr.Read())
            {
                HinhAnh_DTO sp = new HinhAnh_DTO();
                if (!dr.IsDBNull(0))
                {
                    sp.SanPham.MaSP = (string)dr[0];
                }
                if (!dr.IsDBNull(1))
                {
                    sp.SanPham.TenSP = (string)dr["TenSP"];
                }
                if (!dr.IsDBNull(2))
                {
                    sp.SanPham.MaChiTietSanPham = (string)dr["MaChiTietSanPham"];
                }
                if (!dr.IsDBNull(3))
                {
                    sp.SanPham.MaLoaiSP = (string)dr["MaLoaiSP"];
                }
                if (!dr.IsDBNull(4))
                {
                    sp.SanPham.NgayNhapKho = (DateTime)dr["NgayNhapKho"];
                }
                if (!dr.IsDBNull(5))
                {
                    sp.SanPham.GiaNhapKho = (decimal)dr["GiaNhapKho"];
                }
                if (!dr.IsDBNull(6))
                {
                    sp.SanPham.GiaBan = (decimal)dr["GiaBan"];
                }
                if (!dr.IsDBNull(7))
                {
                    sp.SanPham.GioiTinh = (string)dr["GioiTinh"];
                }
                if (!dr.IsDBNull(8))
                {
                    sp.SanPham.TrangThai_SP = (bool)dr[8];
                }
                if (!dr.IsDBNull(9))
                {
                    sp.MaHinhAnh = (string)dr["MaHinhAnh"];
                }
                if (!dr.IsDBNull(10))
                {
                    sp.LinkAnh = (string)dr["LinkAnh"];
                }
                if (!dr.IsDBNull(11))
                {
                    sp.TrangThai_HA = (bool)dr[11];
                }
                if (!dr.IsDBNull(12))
                {
                    sp.MaSP_HA = (string)dr[12];
                }
                dsHA.Add(sp);
            }

            return dsHA;
        }
    }
}
