using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DANG_KY_MON_HOC
{
    // 1.
    public class DatabaseConnection
    {
        public SqlConnection connection;
        private string connectionString;

        public DatabaseConnection(string u, string p)
        {
            // Tạo chuỗi kết nối
            connectionString = "Data Source=localhost;Initial Catalog=DANG_KY_MON_HOC;User ID=" + u + ";Password=" + p;
            connection = new SqlConnection(connectionString);
        }
        public DatabaseConnection()
        {
            // Tạo chuỗi kết nối
            connectionString = "Data Source=localhost;Initial Catalog=DANG_KY_MON_HOC;Integrated Security=True";
            connection = new SqlConnection(connectionString);
        }
        public bool OpenConnection()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi kết nối: " + ex.Message);
                return false;
            }
        }

        public bool CloseConnection()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi đóng kết nối: " + ex.Message);
                return false;
            }
        }
    }
}
