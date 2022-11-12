using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Store_DAL
    {
        public static DataTable Show_List_Store()
        {
            SqlConnection conn = DatabaseAccess.ConnectionDatabase();
            SqlCommand cmd = new SqlCommand("dbo.proc_ShowCH", conn);
            DataTable dt = new DataTable();
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public static int Check_Info_Store(CuaHang_DTO store)
        {
            SqlConnection conn = DatabaseAccess.ConnectionDatabase();
            SqlCommand cmd = new SqlCommand("dbo.func_Check_Info", conn);
            cmd.Parameters.Add("@str", SqlDbType.NVarChar, 40).Value = store.IdQL;
            int dt = 1;
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            dt = cmd.ExecuteNonQuery();
            conn.Close();
            return dt;
        }
        public static void Insert_Store(CuaHang_DTO store)
        {
            SqlConnection conn = DatabaseAccess.ConnectionDatabase();
            SqlCommand cmd = new SqlCommand("dbo.proc_Add_CH", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Address", SqlDbType.NVarChar, 30).Value = store.Diachi;
            cmd.Parameters.Add("@ManagerID", SqlDbType.Char, 10).Value = store.IdQL;

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            
        }
        public static void Update_Store(CuaHang_DTO store)
        {
            SqlConnection conn = DatabaseAccess.ConnectionDatabase();
            SqlCommand cmd = new SqlCommand("dbo.proc_UpdateCH", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Address", SqlDbType.NVarChar, 30).Value = store.Diachi;
            cmd.Parameters.Add("@IDMgr", SqlDbType.Char, 10).Value = store.IdQL;
            cmd.Parameters.Add("@IdCH", SqlDbType.Char, 10).Value = store.IdCH;

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static DataTable Search_Store(String str)
        {
            SqlConnection conn = DatabaseAccess.ConnectionDatabase();
            SqlCommand cmd = new SqlCommand("dbo.proc_showCH_str", conn);
            cmd.Parameters.Add("@str", SqlDbType.NVarChar, 40).Value = str;
            DataTable dt = new DataTable();
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            conn.Close();
            return dt;
        }
    }
}
