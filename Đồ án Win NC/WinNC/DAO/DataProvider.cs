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
        private static SqlConnection conn = new SqlConnection(@"Data Source=localhost;Initial Catalog=ShopThoiTrang;Integrated Security=True");

        public static void CloseConnect()
        {
            conn.Close();
        }

        public static SqlDataReader Retrieve_Table(string sql)
        {
            try
            {
                conn.Open();
                SqlDataReader dr;
                SqlCommand cmd = new SqlCommand(sql, conn);
                dr = cmd.ExecuteReader();
                return dr;
            }
            catch(Exception e)
            {
                return null;
            }
            
        }


        public static int Retrieve_Count(string sql)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                int row = (int)cmd.ExecuteScalar();
                return row;
            }
            catch (Exception e)
            {
                return 0;
            }
            
        }

        public static int ExecuteInsertUpdateDelete(string query)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                int kq = cmd.ExecuteNonQuery();
                return kq;
            }
            catch(Exception e)
            {
                return 0;
            }
        }
    }
}
