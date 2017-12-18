using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class clsLoaiSanPham_DAO
    {
        public static List<clsLoaiSanPham_DTO> Retrieve_LoaiSanPham()
        {
            List<clsLoaiSanPham_DTO> dsLSP = new List<clsLoaiSanPham_DTO>();
            string sql = @"select * from LoaiSanPham";
            SqlDataReader dr = DataProvider.Retrieve_Table(sql);
            while(dr.Read())
            {
                clsLoaiSanPham_DTO lsp = new clsLoaiSanPham_DTO();
                if(!dr.IsDBNull(0))
                {
                    lsp.MaLoaiSP = (string)dr["MaLoaiSP"];
                }
                if (!dr.IsDBNull(1))
                {
                    lsp.TenLoaiSP = (string)dr["TenLoaiSP"];
                }
                if (!dr.IsDBNull(2))
                {
                    lsp.TrangThai = (Boolean)dr["TrangThai"];
                }
                dsLSP.Add(lsp);
            }
            DataProvider.CloseConnect();
            return dsLSP;
        }

        public static clsLoaiSanPham_DTO Retrieve_LoaiSanPham(string maLoai)
        {
            clsLoaiSanPham_DTO lsp = new clsLoaiSanPham_DTO();
            string sql = string.Format("select * from LoaiSanPham where MaLoaiSP = '{0}'", maLoai);
            SqlDataReader dr = DataProvider.Retrieve_Table(sql);
            if (dr.Read())
            {
                if (!dr.IsDBNull(0))
                {
                    lsp.MaLoaiSP = (string)dr["MaLoaiSP"];
                }
                if (!dr.IsDBNull(1))
                {
                    lsp.TenLoaiSP = (string)dr["TenLoaiSP"];
                }
                if (!dr.IsDBNull(2))
                {
                    lsp.TrangThai = (Boolean)dr["TrangThai"];
                }
            }
            DataProvider.CloseConnect();
            return lsp;
        }
    }
}
