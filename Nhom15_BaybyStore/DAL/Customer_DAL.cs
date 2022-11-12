using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class Customer_DAL
    {
        public static DataTable Show_List_Cus()
        {
            SqlConnection conn = DatabaseAccess.ConnectionDatabase();
            SqlCommand cmd = new SqlCommand("dbo.show_list_cus", conn);
            DataTable dt = new DataTable();
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public static DataTable Show_List_Cus_String(String str_cus)
        {
            SqlConnection conn = DatabaseAccess.ConnectionDatabase();
            SqlCommand cmd = new SqlCommand("dbo.show_list_cus_str", conn);
            DataTable dt = new DataTable();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@str_Cus", SqlDbType.Char, 10).Value = str_cus;
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public static void Insert_Cus(KhachHang_DTO customer)
        {
            SqlConnection conn = DatabaseAccess.ConnectionDatabase();
            SqlCommand cmd = new SqlCommand("dbo.add_customer", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@name", SqlDbType.NVarChar, 30).Value = customer.Hovaten;
            cmd.Parameters.Add("@point", SqlDbType.Int).Value = customer.Diem;
            cmd.Parameters.Add("@phonenumber", SqlDbType.Char, 11).Value = customer.Sdt;

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void Delete_Cus(KhachHang_DTO customer)
        {
            SqlConnection conn = DatabaseAccess.ConnectionDatabase();
            SqlCommand cmd = new SqlCommand("dbo.del_customer", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@phonenumber", SqlDbType.Char, 11).Value = customer.Sdt;

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void Update_Cus(KhachHang_DTO customer)
        {
            SqlConnection conn = DatabaseAccess.ConnectionDatabase();
            SqlCommand cmd = new SqlCommand("dbo.update_customer", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@ID_cus", SqlDbType.Char, 10).Value = customer.IdKH;
            cmd.Parameters.Add("@name", SqlDbType.NVarChar, 30).Value = customer.Hovaten;
            cmd.Parameters.Add("@point", SqlDbType.Int).Value = customer.Diem;
            cmd.Parameters.Add("@phonenumber", SqlDbType.Char, 11).Value = customer.Sdt;

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
        
}
