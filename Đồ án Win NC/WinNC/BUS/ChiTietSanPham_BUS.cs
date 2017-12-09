using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class ChiTietSanPham_BUS
    {
        public List<ChiTietSanPham_DTO> Retrieve_ChiTietSanPham()
        {
            ChiTietSanPham_DAO obj = new ChiTietSanPham_DAO();
            return obj.Retrieve_ChiTietSanPham();
        }
    }
}