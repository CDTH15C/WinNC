using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class LoaiSanPham_DAO
    {
        public List<LoaiSanPham_DTO> Retrieve_LoaiSanPham()
        {
            List<LoaiSanPham_DTO> dsLSP = new List<LoaiSanPham_DTO>();
            string sql = @"select * from LoaiSanPham";
            SqlDataReader dr = DataProvider.Retrieve_Table(sql);
            while(dr.Read())
            {
                LoaiSanPham_DTO lsp = new LoaiSanPham_DTO();
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
            return dsLSP;
        }
    }
}
