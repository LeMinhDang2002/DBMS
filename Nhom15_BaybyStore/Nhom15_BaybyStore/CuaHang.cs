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
    public partial class CuaHang : Form
    {
        public CuaHang()
        {
            InitializeComponent();
        }

        private void CuaHang_Load(object sender, EventArgs e)
        {
            DataTable dt = BUS.Store_BUS.Show_List_Store();
            dgvCuaHang.DataSource = dt;
        }

        private void btnThemCuaHang_Click(object sender, EventArgs e)
        {
            CuaHang_DTO store = new CuaHang_DTO();
            store.Diachi = txtDiaChi.Text;
            store.IdQL = txtIDQuanLy.Text;

            BUS.Store_BUS.Insert_Store(store);
            CuaHang_Load(sender, e);
        }

        private void btnSuaCuaHang_Click(object sender, EventArgs e)
        {
            CuaHang_DTO store = new CuaHang_DTO();
            store.IdCH = txtIDCH.Text;
            store.Diachi = txtDiaChi.Text;
            store.IdQL = txtIDQuanLy.Text;

            BUS.Store_BUS.Update_Store(store);
            CuaHang_Load(sender, e);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            String str = txtTmKiemCuaHang.Text;
            DataTable dt = BUS.Store_BUS.Search_Store(str);
            dgvCuaHang.DataSource = dt;
        }

        private void dgvCuaHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvCuaHang.CurrentRow.Index;
            txtIDCH.Text = dgvCuaHang.Rows[i].Cells["IdCH"].Value.ToString();
            txtDiaChi.Text = dgvCuaHang.Rows[i].Cells["Diachi"].Value.ToString();
            txtIDQuanLy.Text = dgvCuaHang.Rows[i].Cells["IdQL"].Value.ToString();
        }
    }
}
