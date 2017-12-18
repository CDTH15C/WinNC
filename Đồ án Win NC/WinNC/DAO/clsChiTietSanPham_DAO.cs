using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;


namespace DAO
{
    public class clsChiTietSanPham_DAO
    {
        public static List<clsChiTietSanPham_DTO> Retrieve_ChiTietSanPham(string tenSP, string maMau, string maCL, string maSize, bool lonHon, int soLuong, int giaBanMin, int giaBanMax, string loaiSP)
        {
            List<clsChiTietSanPham_DTO> dsChiTietSP = new List<clsChiTietSanPham_DTO>();

            string sql = @"select * from ChiTietSanPham, SanPham where ChiTietSanPham.trangthai = 1 and ChiTietSanPham.MaSP = SanPham.MaSP";
            if(tenSP !="")
            {
                sql += string.Format(" and TenSP Like N'%{0}%'", tenSP);
            }
            
            if(maMau != "")
            {
                sql += string.Format(" and MaMau = '{0}'", maMau);
            }
            if(maCL != "")
            {
                sql += string.Format(" and MaChatLieu = '{0}'", maCL);
            }
            if (maSize != "")
            {
                sql += string.Format(" and maSize = '{0}'", maSize);
            }
            if (soLuong > 0)
            {
                if(lonHon)
                    sql += string.Format(" and SoLuongTonKho >= {0}", soLuong);
                else
                    sql += string.Format(" and SoLuongTonKho <= {0}", soLuong);
            }

            if (giaBanMin > 0)
            {
                sql += string.Format(" and GiaBan >= {0}", giaBanMin);
            }

            if(giaBanMax > 0)
            {
                sql += string.Format(" and GiaBan <= {0}", giaBanMax);
            }

            if (loaiSP != "")
            {
                sql += string.Format(" and MaLoaiSP = '{0}'", loaiSP);
            }


            SqlDataReader dr = DataProvider.Retrieve_Table(sql);
            while(dr.Read())
            {
                clsChiTietSanPham_DTO ctsp = new clsChiTietSanPham_DTO();

                if (!dr.IsDBNull(0))
                {
                    ctsp.MaChiTietSP = (string)dr["MaChiTietSP"];
                }
                if (!dr.IsDBNull(1))
                {
                    ctsp.MaSP = (string)dr["MaSP"];
                }

                if (!dr.IsDBNull(2))
                {
                    ctsp.MaMau = (string)dr["MaMau"];
                }
                if (!dr.IsDBNull(3))
                {
                    ctsp.MaChatLieu = (string)dr["MaChatLieu"];
                }
                if (!dr.IsDBNull(4))
                {
                    ctsp.MaSize = (string)dr["MaSize"];
                }
                if (!dr.IsDBNull(5))
                {
                    ctsp.HinhAnh = (string)dr["HinhAnh"];
                }
                if (!dr.IsDBNull(6))
                {
                    ctsp.SoLuongTonKho = (int)dr["SoLuongTonKho"];
                }
                if (!dr.IsDBNull(7))
                {
                    ctsp.GiaTien = dr.GetInt32(7);
                }
                if (!dr.IsDBNull(8))
                {
                    ctsp.TrangThai = (Boolean)dr["TrangThai"];
                }
                dsChiTietSP.Add(ctsp);
            }
            DataProvider.CloseConnect();
            return dsChiTietSP;
        }

        public static List<clsChiTietSanPham_DTO> Retrieve_ChiTietSanPham(string maSP,string maMau, string maChatLieu, string maSize)
        {
            List<clsChiTietSanPham_DTO> dsctsp = new List<clsChiTietSanPham_DTO>();
            string query = string.Format("select * from ChiTietSanPham, SanPham where ChiTietSanPham.trangthai = 1 and ChiTietSanPham.MaSP = SanPham.MaSP");
            if(maSP != "")
            {
                query += string.Format(" and ChiTietSanPham.MaSP = '{0}'", maSP);
            }
            if(maMau != "")
            {
                query += string.Format(" and MaMau = '{0}'", maMau);
            }
            if (maChatLieu != "")
            {
                query += string.Format(" and MaChatLieu = '{0}'", maChatLieu);
            }
            if (maSize != "")
            {
                query += string.Format(" and MaSize = '{0}'", maSize);
            }
            SqlDataReader dr = DataProvider.Retrieve_Table(query);
            while(dr.Read())
            {
                clsChiTietSanPham_DTO ctsp = new clsChiTietSanPham_DTO();
                if (!dr.IsDBNull(0))
                {
                    ctsp.MaChiTietSP = (string)dr["MaChiTietSP"];
                }
                if (!dr.IsDBNull(1))
                {
                    ctsp.MaSP = (string)dr["MaSP"];
                }

                if (!dr.IsDBNull(2))
                {
                    ctsp.MaMau = (string)dr["MaMau"];
                }
                if (!dr.IsDBNull(3))
                {
                    ctsp.MaChatLieu = (string)dr["MaChatLieu"];
                }
                if (!dr.IsDBNull(4))
                {
                    ctsp.MaSize = (string)dr["MaSize"];
                }
                if (!dr.IsDBNull(5))
                {
                    ctsp.HinhAnh = (string)dr["HinhAnh"];
                }
                if (!dr.IsDBNull(6))
                {
                    ctsp.SoLuongTonKho = (int)dr["SoLuongTonKho"];
                }
                if (!dr.IsDBNull(7))
                {
                    ctsp.GiaTien = dr.GetInt32(7);
                }
                if (!dr.IsDBNull(8))
                {
                    ctsp.TrangThai = (Boolean)dr["TrangThai"];
                }
                dsctsp.Add(ctsp);
            }
           

            DataProvider.CloseConnect();
 
            return dsctsp;
        }

        public static List<clsChiTietSanPham_DTO> LayDSCTSPTheoMaSP(string maSP)
        {
            List<clsChiTietSanPham_DTO> dsCtsp = new List<clsChiTietSanPham_DTO>();
            string query = string.Format("select * from ChiTietSanPham where trangthai = 1  and MaSP = '{0}'", maSP);
            SqlDataReader dr = DataProvider.Retrieve_Table(query);
            while (dr.Read())
            {
                clsChiTietSanPham_DTO ctsp = new clsChiTietSanPham_DTO();
                if (!dr.IsDBNull(0))
                {
                    ctsp.MaChiTietSP = (string)dr["MaChiTietSP"];
                }
                if (!dr.IsDBNull(1))
                {
                    ctsp.MaSP = (string)dr["MaSP"];
                }

                if (!dr.IsDBNull(2))
                {
                    ctsp.MaMau = (string)dr["MaMau"];
                }
                if (!dr.IsDBNull(3))
                {
                    ctsp.MaChatLieu = (string)dr["MaChatLieu"];
                }
                if (!dr.IsDBNull(4))
                {
                    ctsp.MaSize = (string)dr["MaSize"];
                }
                if (!dr.IsDBNull(5))
                {
                    ctsp.HinhAnh = (string)dr["HinhAnh"];
                }
                if (!dr.IsDBNull(6))
                {
                    ctsp.SoLuongTonKho = (int)dr["SoLuongTonKho"];
                }
                if (!dr.IsDBNull(7))
                {
                    ctsp.GiaTien = dr.GetInt32(7);
                }
                if (!dr.IsDBNull(8))
                {
                    ctsp.TrangThai = (Boolean)dr["TrangThai"];
                }
                dsCtsp.Add(ctsp);
            }


            DataProvider.CloseConnect();

            return dsCtsp;
        }

        public static bool ThemChiTietSP(clsChiTietSanPham_DTO ctsp)
        {
            string query = string.Format("insert into ChiTietSanPham(MaChiTietSP, MaSP, MaMau, MaChatLieu, MaSize, HinhAnh, SoLuongTonKho, GiaBan, TrangThai) values('{8}', '{0}','{1}', '{2}', '{3}', '{4}', {5}, {6}, '{7}')", ctsp.MaSP, ctsp.MaMau, ctsp.MaChatLieu, ctsp.MaSize, ctsp.HinhAnh, ctsp.SoLuongTonKho, ctsp.GiaTien, ctsp.TrangThai, ctsp.MaChiTietSP);
            int kq = DataProvider.ExecuteInsertUpdateDelete(query);
            DataProvider.CloseConnect();
            return kq == 1;
        }

        public static bool CapNhatSoLuong(string maCTSP, int SL)
        {
            string query = string.Format("update ChiTietSanPham set SoLuongTonKho = {0} where maChiTietSP = '{1}'", SL, maCTSP);
            int kq = DataProvider.ExecuteInsertUpdateDelete(query);
            DataProvider.CloseConnect();
            return kq == 1;
        }

        public static int LaySoLuongTonKho(string maCTSP)
        {
            string query = string.Format("select SoLuongTonKho from ChiTietSanPham where MaChiTietSP = '{0}'", maCTSP);
            int kq = DataProvider.Retrieve_Count(query);
            DataProvider.CloseConnect();
            return kq;
        }

        public static bool CapNhatTrangThai(bool trangThai, string maSP, string maMau,string maChatLieu, string maSize)
        {
            string query = string.Format("update ChiTietSanPham set TrangThai = '{0}' where maSP = '{1}' and maMau = '{2}' and maChatLieu ='{3}' and maSize = '{4}'", trangThai,  maSP, maMau, maChatLieu, maSize);
            int kq = DataProvider.ExecuteInsertUpdateDelete(query);
            DataProvider.CloseConnect();
            return kq == 1;
        }
    }
}
