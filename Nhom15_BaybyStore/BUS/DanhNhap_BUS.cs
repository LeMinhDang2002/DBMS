using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class DanhNhap_BUS
    {
        DangNhap_DAL DangNhap = new DangNhap_DAL();
        public bool CheckTaiKhoan(string tenTaiKhoan, string matKhau, string IdLTK)
        {
            return DangNhap.CheckTaiKhoan(tenTaiKhoan, matKhau, IdLTK);
        }
    }
}
