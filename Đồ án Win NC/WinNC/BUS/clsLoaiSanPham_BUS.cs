using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public static class clsLoaiSanPham_BUS
    {
        public static List<clsLoaiSanPham_DTO> Retrieve_LoaiSanPham()
        {
            return clsLoaiSanPham_DAO.Retrieve_LoaiSanPham();
        }
        public static clsLoaiSanPham_DTO Retrieve_LoaiSanPham(string maLoai)
        {
            return clsLoaiSanPham_DAO.Retrieve_LoaiSanPham(maLoai);
        }
    }
}
