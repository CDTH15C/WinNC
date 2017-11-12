using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
   public class Mau_BUS
    {
        public List<Mau_DTO> Retrieve_Mau(string condition)
        {
            Mau_DAO obj = new Mau_DAO();
            return obj.Retrieve_Mau(condition);
        }
    }
}
