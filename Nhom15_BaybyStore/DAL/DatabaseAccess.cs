using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DatabaseAccess
    {
        /*string strCon = @"Data Source=DANG;Initial Catalog=BaybyStore;Integrated Security=True";
        public SqlConnection conn = null;*/
        public static SqlConnection ConnectionDatabase()
        {
            SqlConnection conn = new SqlConnection("Data Source=DANG;Initial Catalog=BaybyStore;Integrated Security=True");
            return conn;
        }
        /*public void OpenConnection()
        {
            if (conn == null)
            {
                conn = new SqlConnection(strCon);
            }
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public void CloseConnection()
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }*/
    }
}
