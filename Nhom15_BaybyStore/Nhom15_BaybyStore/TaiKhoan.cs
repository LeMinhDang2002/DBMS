using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom15_BaybyStore
{
    public partial class TaiKhoan : Form
    {
        public TaiKhoan()
        {
            InitializeComponent();
        }

        private void TaiKhoan_Load(object sender, EventArgs e)
        {
            DataTable dt = BUS.Account_BUS.Show_List_Account();
            dgvTaiKhoan.DataSource = dt;
        }

        private void btnThemTaiKhoan_Click(object sender, EventArgs e)
        {
            TaiKhoan_DTO account = new TaiKhoan_DTO();
            account.IdTK = txtTenTaiKhoan.Text;
            account.Matkhau = txtMatKhau.Text;
            account.IdLTK = cmbLoaiTaiKhoan.Text;

            BUS.Account_BUS.Insert_Account(account);
            TaiKhoan_Load(sender, e);
        }

        private void btnXoaTaiKhoan_Click(object sender, EventArgs e)
        {
            TaiKhoan_DTO account = new TaiKhoan_DTO();
            account.IdTK = txtTenTaiKhoan.Text;

            BUS.Account_BUS.Delete_Account(account);
            TaiKhoan_Load(sender, e);
        }

        private void btnSuaTaiKhoan_Click(object sender, EventArgs e)
        {
            TaiKhoan_DTO account = new TaiKhoan_DTO();
            account.IdTK = txtTenTaiKhoan.Text;
            account.Matkhau = txtMatKhau.Text;
            account.IdLTK = cmbLoaiTaiKhoan.Text;

            BUS.Account_BUS.Update_Account(account);
            TaiKhoan_Load(sender, e);
        }

        private void btnTimKiemTaiKhoan_Click(object sender, EventArgs e)
        {
            String str = txtTimKiemTaiKhoan.Text;

            DataTable dt = BUS.Account_BUS.Search_Account(str);
            dgvTaiKhoan.DataSource = dt;
        }

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvTaiKhoan.CurrentRow.Index;
            txtTenTaiKhoan.Text = dgvTaiKhoan.Rows[i].Cells["IdTK"].Value.ToString();
            txtMatKhau.Text = dgvTaiKhoan.Rows[i].Cells["Matkhau"].Value.ToString();
            cmbLoaiTaiKhoan.Text = dgvTaiKhoan.Rows[i].Cells["IdLTK"].Value.ToString();
        }
    }
}
