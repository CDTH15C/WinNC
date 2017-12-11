using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;

namespace DAO
{
    public class NhanVien_DAO
    {
       public List<NhanVien_DTO> LayDsNV()
        {
            List<NhanVien_DTO> dsNV = new List<NhanVien_DTO>();

            
            SqlDataReader dr = DataProvider.Retrieve_Table(Query.dsThongTinhNhanVien);
            while(dr.Read())
            {
                NhanVien_DTO nv = new NhanVien_DTO();
                if(!dr.IsDBNull(0))
                {
                    nv.MaNV = (string)dr["MaNV"];
                }
                if (!dr.IsDBNull(1))
                {
                    nv.HoTen = (string)dr["HoTen"];
                }
                if (!dr.IsDBNull(2))
                {
                    nv.DiaChi = (string)dr["DiaChi"];
                }
                if (!dr.IsDBNull(3))
                {
                    nv.NgaySinh = (DateTime)dr["NgaySinh"];
                }
                if (!dr.IsDBNull(4))
                {
                    nv.SDT = (string)dr["SDT"];
                }
                if (!dr.IsDBNull(5))
                {
                    nv.Email = (string)dr["Email"];
                }
                if (!dr.IsDBNull(6))
                {
                    nv.Luong = (decimal)dr[6];
                }
                if (!dr.IsDBNull(7))
                {
                    nv.CMND = (string)dr["CMND"];
                }
                if (!dr.IsDBNull(8))
                {
                    nv.AnhDaiDien = (string)dr["AnhDaiDien"];
                }
                if (!dr.IsDBNull(9))
                {
                    nv.MaTaiKhoan_NV = (string)dr[9];
                }
                if (!dr.IsDBNull(10))
                {
                    nv.TrangThai_NV = (bool)dr[10];
                }
                if (!dr.IsDBNull(11))
                {
                    nv.MaTaiKhoan = (string)dr[11];
                }
                if (!dr.IsDBNull(12))
                {
                    nv.TenTaiKhoan = (string)dr["TenTaiKhoan"];
                }
                if (!dr.IsDBNull(13))
                {
                    nv.MatKhau = (string)dr["MatKhau"];
                }
                if (!dr.IsDBNull(14))
                {
                    nv.NgayTao = (DateTime)dr["NgayTao"];
                }
                if (!dr.IsDBNull(15))
                {
                    nv.MaLoaiTK_TK = (string)dr[15];
                }
                if (!dr.IsDBNull(16))
                {
                    nv.TrangThai_TK = (Boolean)dr[16];
                }
                if (!dr.IsDBNull(17))
                {
                    nv.MaLoaiTK = (string)dr[17];
                }
                if (!dr.IsDBNull(18))
                {
                    nv.TenLoaiTK = (string)dr[18];
                }
                if (!dr.IsDBNull(19))
                {
                    nv.TrangThai = (bool)dr[19];
                }
                dsNV.Add(nv);
            }
            return dsNV;
        }

        public NhanVien_DTO LayThongTinNV(string Username)
        {
            NhanVien_DTO nv = new NhanVien_DTO();
            string sql = string.Format(Query.layThongTin_1_NhanVien, Username);
            SqlDataReader dr = DataProvider.Retrieve_Table(sql);
            if (dr.Read())
            {
                if (!dr.IsDBNull(0))
                {
                    nv.MaNV = (string)dr["MaNV"];
                }
                if (!dr.IsDBNull(1))
                {
                    nv.HoTen = (string)dr["HoTen"];
                }
                if (!dr.IsDBNull(2))
                {
                    nv.DiaChi = (string)dr["DiaChi"];
                }
                if (!dr.IsDBNull(3))
                {
                    nv.NgaySinh = (DateTime)dr["NgaySinh"];
                }
                if (!dr.IsDBNull(4))
                {
                    nv.SDT = (string)dr["SDT"];
                }
                if (!dr.IsDBNull(5))
                {
                    nv.Email = (string)dr["Email"];
                }
                if (!dr.IsDBNull(6))
                {
                    nv.Luong = (decimal)dr[6];
                }
                if (!dr.IsDBNull(7))
                {
                    nv.CMND = (string)dr["CMND"];
                }
                if (!dr.IsDBNull(8))
                {
                    nv.AnhDaiDien = (string)dr["AnhDaiDien"];
                }
                if (!dr.IsDBNull(9))
                {
                    nv.MaTaiKhoan_NV = (string)dr[9];
                }
                if (!dr.IsDBNull(10))
                {
                    nv.TrangThai_NV = (bool)dr[10];
                }
                if (!dr.IsDBNull(11))
                {
                    nv.MaTaiKhoan = (string)dr[11];
                }
                if (!dr.IsDBNull(12))
                {
                    nv.TenTaiKhoan = (string)dr["TenTaiKhoan"];
                }
                if (!dr.IsDBNull(13))
                {
                    nv.MatKhau = (string)dr["MatKhau"];
                }
                if (!dr.IsDBNull(14))
                {
                    nv.NgayTao = (DateTime)dr["NgayTao"];
                }
                if (!dr.IsDBNull(15))
                {
                    nv.MaLoaiTK_TK = (string)dr[15];
                }
                if (!dr.IsDBNull(16))
                {
                    nv.TrangThai_TK = (Boolean)dr[16];
                }
                if (!dr.IsDBNull(17))
                {
                    nv.MaLoaiTK = (string)dr[17];
                }
                if (!dr.IsDBNull(18))
                {
                    nv.TenLoaiTK = (string)dr[18];
                }
                if (!dr.IsDBNull(19))
                {
                    nv.TrangThai = (bool)dr[19];
                }
            }
            return nv;
        }
        public bool KtraDangNhap(string TenTaiKhoan,string MatKhau)
        {
            string sql = string.Format(Query.Ktra_TaiKhoan_MatKhau, TenTaiKhoan, MatKhau);
            return DataProvider.Retrieve_Count(sql) == 1 ? true : false;
        }
    }
}
