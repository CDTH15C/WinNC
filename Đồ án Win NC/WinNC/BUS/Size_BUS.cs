using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class Size_BUS
    {
        public List<Size_DTO> Retrieve_Size(string condition)
        {
            Size_DAO obj = new Size_DAO();
            return obj.Retrieve_Size(condition);
        }
    }
}
