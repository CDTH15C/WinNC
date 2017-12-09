using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class HinhAnh_BUS
    {
        public List<HinhAnh_DTO> Retrieve_HinhAnh(string condition)
        {
            HinhAnh_DAO obj = new HinhAnh_DAO();
            return obj.Retrieve_HinhAnh(condition);
        }

        public List<HinhAnh_DTO> layDsHinhAnh(string condition)
        {
            HinhAnh_DAO obj = new HinhAnh_DAO();
            return obj.layDsHinhAnh(condition);
        }
    }
}
