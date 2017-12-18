using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;

namespace DAO
{
    public class clsNhanVien_DAO
    {
       public static List<clsNhanVien_DTO> LayDsNV()
        {
            List<clsNhanVien_DTO> dsNV = new List<clsNhanVien_DTO>();

            string query = "Select * from NhanVien";

            SqlDataReader dr = DataProvider.Retrieve_Table(query);
            while(dr.Read())
            {
                clsNhanVien_DTO nv = new clsNhanVien_DTO();
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
                    nv.ChucVu = (string)dr[9];
                }
                if (!dr.IsDBNull(10))
                {
                    nv.TenTaiKhoan = (string)dr[10];
                }
                if (!dr.IsDBNull(11))
                {
                    nv.MatKhau = (string)dr[11];
                }
                if (!dr.IsDBNull(12))
                {
                    nv.TrangThai_NV = dr.GetBoolean(12);
                }

                dsNV.Add(nv);
            }

            DataProvider.CloseConnect();
            return dsNV;
        }

        public static clsNhanVien_DTO LayThongTinNV(string Username)
        {
            clsNhanVien_DTO nv = new clsNhanVien_DTO();
            string query = string.Format("SELECT * FROM NhanVien WHERE TrangThai = 1 AND TenTaiKhoan = '{0}'", Username);
            SqlDataReader dr = DataProvider.Retrieve_Table(query);
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
                    nv.ChucVu = (string)dr[9];
                }
                if (!dr.IsDBNull(10))
                {
                    nv.TenTaiKhoan = (string)dr[10];
                }
                if (!dr.IsDBNull(11))
                {
                    nv.MatKhau = (string)dr[11];
                }
                if (!dr.IsDBNull(12))
                {
                    nv.TrangThai_NV = dr.GetBoolean(12);
                }
            }
            DataProvider.CloseConnect();
            return nv;
        }
        public static bool KtraDangNhap(string TenTaiKhoan,string MatKhau)
        {
            string query = string.Format("SELECT COUNT(*) FROM NhanVien WHERE TenTaiKhoan = '{0}' AND MatKhau = '{1}'", TenTaiKhoan, MatKhau);
            bool kq = (DataProvider.Retrieve_Count(query) == 1);
            DataProvider.CloseConnect();
            return kq;
        }
    }
}
