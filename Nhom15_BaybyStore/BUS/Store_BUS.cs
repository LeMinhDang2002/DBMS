using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Store_BUS
    {
        public static DataTable Show_List_Store()
        {
            return DAL.Store_DAL.Show_List_Store();
        }
        public static void Insert_Store(CuaHang_DTO store)
        {
            DAL.Store_DAL.Insert_Store(store);
        }
        public static void Update_Store(CuaHang_DTO store)
        {
            DAL.Store_DAL.Update_Store(store);
        }
        public static DataTable Search_Store(String str)
        {
            return DAL.Store_DAL.Search_Store(str);
        }
    }
}
