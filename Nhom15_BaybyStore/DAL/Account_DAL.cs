using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Security.Principal;

namespace DAL
{
    public class Account_DAL
    {
        public static DataTable Show_List_Account()
        {
            SqlConnection conn = DatabaseAccess.ConnectionDatabase();
            SqlCommand cmd = new SqlCommand("dbo.proc_show_acc", conn);
            DataTable dt = new DataTable();
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public static DataTable Search_Account(String account)
        {
            SqlConnection conn = DatabaseAccess.ConnectionDatabase();
            SqlCommand cmd = new SqlCommand("dbo.proc_show_acc_str", conn);
            DataTable dt = new DataTable();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@str", SqlDbType.Char, 15).Value = account;
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public static void Insert_Account(TaiKhoan_DTO account)
        {
            SqlConnection conn = DatabaseAccess.ConnectionDatabase();
            SqlCommand cmd = new SqlCommand("dbo.transaction_proc_add_account", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@account", SqlDbType.Char, 30).Value = account.IdTK;
            cmd.Parameters.Add("@password", SqlDbType.Char, 15).Value = account.Matkhau;
            cmd.Parameters.Add("@typeaccount", SqlDbType.Char, 10).Value = account.IdLTK;

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void Delete_Accout(TaiKhoan_DTO account)
        {
            SqlConnection conn = DatabaseAccess.ConnectionDatabase();
            SqlCommand cmd = new SqlCommand("dbo.transaction_proc_delete_account", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@account", SqlDbType.Char, 30).Value = account.IdTK;

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void Update_Account(TaiKhoan_DTO account)
        {
            SqlConnection conn = DatabaseAccess.ConnectionDatabase();
            SqlCommand cmd = new SqlCommand("dbo.transaction_proc_update_account", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@account", SqlDbType.Char, 30).Value = account.IdTK;
            cmd.Parameters.Add("@password", SqlDbType.Char, 15).Value = account.Matkhau;
            cmd.Parameters.Add("@typeaccount", SqlDbType.Char, 10).Value = account.IdLTK;

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
