using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class SanPham_BUS
    {
        public List<SanPham_DTO> RetrieveTable_SanPham(List<string> condition)
        {
            SanPham_DAO obj = new SanPham_DAO();
            return obj.RetrieveTable_SanPham(condition);
        }
    }
}
