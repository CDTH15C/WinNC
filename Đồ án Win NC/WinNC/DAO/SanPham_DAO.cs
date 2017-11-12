using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
   public class SanPham_DAO
    {
        // Retrieve table SanPham

        public List<SanPham_DTO> RetrieveTable_SanPham(List<string> condition)
        {
            List<SanPham_DTO> dsSanPham = new List<SanPham_DTO>();
            string sql = Query.dsThongTinSanPham;
            SqlDataReader dr = DataProvider.Retrieve_Table(sql);
            while(dr.Read())
            {
                SanPham_DTO sp = new SanPham_DTO();
                if(!dr.IsDBNull(0))
                {
                    sp.MaSP = (string)dr["MaSP"];
                }
                if (!dr.IsDBNull(1))
                {
                    sp.TenSP = (string)dr["TenSP"];
                }
                if (!dr.IsDBNull(2))
                {
                    sp.MaChiTietSanPham = (string)dr["MaChiTietSanPham"];
                }
                if (!dr.IsDBNull(3))
                {
                    sp.MaLoaiSP = (string)dr["MaLoaiSP"];
                }
                if (!dr.IsDBNull(4))
                {
                    sp.NgayNhapKho = (DateTime)dr["NgayNhapKho"];
                }
                if (!dr.IsDBNull(5))
                {
                    sp.GiaNhapKho = (decimal)dr["GiaNhapKho"];
                }
                if (!dr.IsDBNull(6))
                {
                    sp.GiaBan = (decimal)dr["GiaBan"];
                }
                if (!dr.IsDBNull(7))
                {
                    sp.GioiTinh = (string)dr["GioiTinh"];
                }
                if (!dr.IsDBNull(8))
                {
                    sp.TrangThai_SP = (bool)dr["TrangThai"];
                }

                if (!dr.IsDBNull(9))
                {
                    sp.MaChiTietSanPham = (string)dr[9];
                }
                if (!dr.IsDBNull(10))
                {
                   sp.Mau.MaMau = (string)dr[10];
                }
                if (!dr.IsDBNull(11))
                {
                    sp.Mau.TenMau = (string)dr[11];
                }

               
                dsSanPham.Add(sp);
            }
            return dsSanPham;
        }
    }
}
