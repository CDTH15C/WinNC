using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
   public class clsSanPham_DAO
    {
        // Retrieve table SanPham

        public static List<clsSanPham_DTO> RetrieveTable_SanPham(List<string> condition)
        {
            List<clsSanPham_DTO> dsSanPham = new List<clsSanPham_DTO>();
            string sql = @"SELECT * FROM SanPham WHERE TrangThai = 1";
            SqlDataReader dr = DataProvider.Retrieve_Table(sql);
            while(dr.Read())
            {
                clsSanPham_DTO sp = new clsSanPham_DTO();
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
                    sp.MaLoaiSP = (string)dr["MaLoaiSP"];
                }
                if (!dr.IsDBNull(3))
                {
                    sp.MaNhaSX = (string)dr["MaNhaSX"];
                }
                if (!dr.IsDBNull(4))
                {
                    sp.NgayNhapKho = (DateTime)dr["NgayNhapKho"];
                }
                if (!dr.IsDBNull(5))
                {
                    sp.GioiTinh = (string)dr["GioiTinh"];
                }
                if (!dr.IsDBNull(6))
                {
                    sp.TrangThai_SP = (bool)dr["TrangThai"];
                }
                
                dsSanPham.Add(sp);
            }
            DataProvider.CloseConnect();
            return dsSanPham;
        }

        public static List<clsSanPham_DTO> LayDSSPTheoTen(string tenSP)
        {
            List<clsSanPham_DTO> dsSanPham = new List<clsSanPham_DTO>();
            string sql = string.Format("SELECT * FROM SanPham WHERE TrangThai = 1 and TenSP Like N'%{0}%'", tenSP);
            SqlDataReader dr = DataProvider.Retrieve_Table(sql);
            while (dr.Read())
            {
                clsSanPham_DTO sp = new clsSanPham_DTO();
                if (!dr.IsDBNull(0))
                {
                    sp.MaSP = (string)dr["MaSP"];
                }
                if (!dr.IsDBNull(1))
                {
                    sp.TenSP = (string)dr["TenSP"];
                }
                if (!dr.IsDBNull(2))
                {
                    sp.MaLoaiSP = (string)dr["MaLoaiSP"];
                }
                if (!dr.IsDBNull(3))
                {
                    sp.MaNhaSX = (string)dr["MaNhaSX"];
                }
                if (!dr.IsDBNull(4))
                {
                    sp.NgayNhapKho = (DateTime)dr["NgayNhapKho"];
                }
                if (!dr.IsDBNull(5))
                {
                    sp.GioiTinh = (string)dr["GioiTinh"];
                }
                if (!dr.IsDBNull(6))
                {
                    sp.TrangThai_SP = (bool)dr["TrangThai"];
                }

                dsSanPham.Add(sp);
            }
            DataProvider.CloseConnect();
            return dsSanPham;
        }

        public static clsSanPham_DTO Retrieve_SanPham(string masp)
        {
            clsSanPham_DTO sp = null;
            string sql = string.Format("SELECT * FROM SanPham WHERE MaSP = '{0}'", masp);
            SqlDataReader dr = DataProvider.Retrieve_Table(sql);
            if (dr.Read())
            {
                sp = new clsSanPham_DTO();
                if (!dr.IsDBNull(0))
                {
                    sp.MaSP = (string)dr["MaSP"];
                }
                if (!dr.IsDBNull(1))
                {
                    sp.TenSP = (string)dr["TenSP"];
                }
                if (!dr.IsDBNull(2))
                {
                    sp.MaLoaiSP = (string)dr["MaLoaiSP"];
                }
                if (!dr.IsDBNull(3))
                {
                    sp.MaNhaSX = (string)dr["MaNhaSX"];
                }
                if (!dr.IsDBNull(4))
                {
                    sp.NgayNhapKho = (DateTime)dr["NgayNhapKho"];
                }
                if (!dr.IsDBNull(5))
                {
                    sp.GioiTinh = (string)dr["GioiTinh"];
                }
                if (!dr.IsDBNull(6))
                {
                    sp.TrangThai_SP = (bool)dr["TrangThai"];
                }
            }
            DataProvider.CloseConnect();
            return sp;
        }

        public static bool ThemSanPham(clsSanPham_DTO sp)
        {
            string query = string.Format("insert into SanPham(MaSP, TenSP, MaLoaiSP, MaNhaSX, NgayNhapKho, GioiTinh, TrangThai) values('{0}',N'{1}','{2}','{3}','{4}',N'{5}','{6}')", sp.MaSP, sp.TenSP, sp.MaLoaiSP, sp.MaNhaSX, sp.NgayNhapKho, sp.GioiTinh, sp.TrangThai_SP);
            int kq = DataProvider.ExecuteInsertUpdateDelete(query);
            DataProvider.CloseConnect();
            return kq == 1;
        }

        public static int DemSLSanPham()
        {
            string query = "select count(*) from SanPham";
            int kq = DataProvider.Retrieve_Count(query);
            DataProvider.CloseConnect();
            return kq;
        }

        public static int DemSLSanPham(string ten)
        {
            string query = "select count(*) from SanPham where TenSP = N'" + ten + "'";
            int kq = DataProvider.Retrieve_Count(query);
            DataProvider.CloseConnect();
            return kq;
        }
    }
}
