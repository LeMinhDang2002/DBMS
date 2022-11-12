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
    public partial class SanPham : Form
    {
        public SanPham()
        {
            InitializeComponent();
        }

        private void btnDoanhMuc_Click(object sender, EventArgs e)
        {
            DoanhMucSanPham doanhMucSanPham = new DoanhMucSanPham();
            doanhMucSanPham.Show();
        }
        private void btnDoanhMuc_MouseLeave(object sender, EventArgs e)
        {
            btnDoanhMuc.IconColor = Color.FromArgb(237, 61, 127);
            btnDoanhMuc.BackColor = Color.White;
        }

        private void btnDoanhMuc_MouseEnter(object sender, EventArgs e)
        {
            btnDoanhMuc.IconColor = Color.White;
            btnDoanhMuc.BackColor = Color.FromArgb(237, 61, 127);
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            NhaCungCap nhaCungCap = new NhaCungCap();
            nhaCungCap.Show();
        }
    }
}
