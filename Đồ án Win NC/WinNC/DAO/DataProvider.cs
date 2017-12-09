using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DAO
{
    public class DataProvider
    {
        private static string strConnect = @"Data Source=DESKTOP-CNG06HV\CDTH15C;Initial Catalog=QLShopThoiTrang;Integrated Security=True";

        public static SqlConnection CreateConnect()
        {
            SqlConnection connect = new SqlConnection(strConnect);
            connect.Open();
            return connect;
        }

        public static void CloseConnect(SqlConnection conn)
        {
            conn.Close();
        }

        public static SqlDataReader Retrieve_Table(string sql)
        {
            SqlDataReader dr;
            SqlConnection conn = DataProvider.CreateConnect();
            SqlCommand cmd = new SqlCommand(sql, conn);
            dr = cmd.ExecuteReader();
            return dr;
        }


        public static int Retrieve_Count(string sql)
        {
            SqlConnection conn = DataProvider.CreateConnect();
            SqlCommand cmd = new SqlCommand(sql, conn);
            int row = (int)cmd.ExecuteScalar();
            return row;
        }
    }
}
