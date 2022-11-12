using DTO;
using FontAwesome.Sharp;
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
    public partial class QLKhachHang : Form
    {
        public QLKhachHang()
        {
            InitializeComponent();
        }

        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
            KhachHang_DTO customer = new KhachHang_DTO();
            customer.Hovaten = txtTenKhachHang.Text;
            customer.Diem = Convert.ToInt32(txtDiem.Text);
            customer.Sdt = txtSDTKhachHang.Text;
            BUS.Customer_BUS.Insert_Cus(customer);
            QLKhachHang_Load(sender, e);
        }

        private void btnXoaKhachHang_Click(object sender, EventArgs e)
        {
            KhachHang_DTO customer = new KhachHang_DTO();
            customer.IdKH = txtIDKhachHang.Text;
            customer.Hovaten = txtTenKhachHang.Text;
            customer.Diem = Convert.ToInt32(txtDiem.Text);
            customer.Sdt = txtSDTKhachHang.Text;
            BUS.Customer_BUS.Delete_Cus(customer);
            QLKhachHang_Load(sender, e);
        }
        private void btnSuaKhachHang_Click(object sender, EventArgs e)
        {
            KhachHang_DTO customer = new KhachHang_DTO();
            customer.IdKH = txtIDKhachHang.Text;
            customer.Hovaten = txtTenKhachHang.Text;
            customer.Diem = Convert.ToInt32(txtDiem.Text);
            customer.Sdt = txtSDTKhachHang.Text;
            BUS.Customer_BUS.Update_Cus(customer);
            QLKhachHang_Load(sender, e);
        }

        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void QLKhachHang_Load(object sender, EventArgs e)
        {
            DataTable dt = BUS.Customer_BUS.Show_List_Cus();
            /*dgvKhachHang.DataSource = dt;*/
            dgvKhachHang.DataSource = dt;
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvKhachHang.CurrentRow.Index;
            txtIDKhachHang.Text = dgvKhachHang.Rows[i].Cells["IdKH"].Value.ToString();
            txtTenKhachHang.Text = dgvKhachHang.Rows[i].Cells["Hovaten"].Value.ToString();
            txtDiem.Text = dgvKhachHang.Rows[i].Cells["Diem"].Value.ToString();
            txtSDTKhachHang.Text = dgvKhachHang.Rows[i].Cells["Sdt"].Value.ToString();
        }

        private void btnTimKiemKhachHang_Click(object sender, EventArgs e)
        {
            String str_cus = "";
            str_cus = txtTimKiemKhachHang.Text.ToString();
            DataTable dt = BUS.Customer_BUS.Show_List_Cus_Str(str_cus);
            dgvKhachHang.DataSource = dt;
        }
    }
}
