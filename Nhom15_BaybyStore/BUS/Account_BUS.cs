using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Account_BUS
    {
        public static DataTable Show_List_Account()
        {
            return DAL.Account_DAL.Show_List_Account();
        }
        public static DataTable Search_Account(String account)
        {
            return DAL.Account_DAL.Search_Account(account);
        }
        public static void Insert_Account(TaiKhoan_DTO account)
        {
            DAL.Account_DAL.Insert_Account(account);
        }
        public static void Delete_Account(TaiKhoan_DTO account)
        {
            DAL.Account_DAL.Delete_Accout(account);
        }
        public static void Update_Account(TaiKhoan_DTO account)
        {
            DAL.Account_DAL.Update_Account(account);
        }
    }
}
