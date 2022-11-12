using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Customer_BUS
    {
        public static void Insert_Cus(KhachHang_DTO customer)
        {
            DAL.Customer_DAL.Insert_Cus(customer);
        }
        public static void Delete_Cus(KhachHang_DTO customer)
        {
            DAL.Customer_DAL.Delete_Cus(customer);
        }
        public static void Update_Cus(KhachHang_DTO customer)
        {
            DAL.Customer_DAL.Update_Cus(customer);
        }
        public static DataTable Show_List_Cus()
        {
            return DAL.Customer_DAL.Show_List_Cus();
        }
        public static DataTable Show_List_Cus_Str(String str_cus)
        {
            return DAL.Customer_DAL.Show_List_Cus_String(str_cus);
        }
    }
}
