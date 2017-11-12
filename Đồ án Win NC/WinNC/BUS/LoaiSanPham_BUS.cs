using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class LoaiSanPham_BUS
    {
        public List<LoaiSanPham_DTO> Retrieve_LoaiSanPham()
        {
            LoaiSanPham_DAO obj = new LoaiSanPham_DAO();
            return obj.Retrieve_LoaiSanPham();
        }
    }
}
