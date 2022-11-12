using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace Nhom15_BaybyStore
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void txtTenTaiKhoan_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(txtTenTaiKhoan.Text == "")
                {
                    txtTenTaiKhoan.Text = "Nhập tên tài khoản";
                    return;
                }
                txtTenTaiKhoan.ForeColor = Color.Black;
                panel5.Visible = false;
            }
            catch { }
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtMatKhau.Text == "")
                {
                    txtMatKhau.Text = "Nhập mật khẩu";
                    return;
                }
                txtMatKhau.ForeColor = Color.Black;
                txtMatKhau.PasswordChar = '*';
                panel7.Visible = false;
            }
            catch { }
        }

        private void txtTenTaiKhoan_Click(object sender, EventArgs e)
        {
            txtTenTaiKhoan.SelectAll();
        }

        private void txtMatKhau_Click(object sender, EventArgs e)
        {
            txtMatKhau.SelectAll();
        }

        private void btnDangNhap_MouseEnter(object sender, EventArgs e)
        {
            btnDangNhap.ForeColor = Color.Black;
        }

        private void btnDangNhap_MouseLeave(object sender, EventArgs e)
        {
            btnDangNhap.ForeColor = Color.White;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string IdTK = txtTenTaiKhoan.Text;
            string Matkhau = txtMatKhau.Text;

            if (txtTenTaiKhoan.Text == "Nhập tên tài khoản")
            {
                panel5.Visible = true;
                txtTenTaiKhoan.Focus();
                return;
            }
            if (txtMatKhau.Text == "Nhập mật khẩu")
            {
                panel7.Visible = true;
                txtMatKhau.Focus();
                return;
            }
            KiemTraLoai();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void KiemTraLoai()
        {
            if (rdbKhachHang.Checked == true)
            {
                KhachHang khachHang = new KhachHang();
                khachHang.ShowDialog();
            }
            if (rdbNhanVien.Checked == true)
            {
                QuayBan quayBan = new QuayBan();
                quayBan.ShowDialog();
            }
            if (rdbQuanLy.Checked == true)
            {
                Home home = new Home();
                home.ShowDialog();
            }
        }

        private void lblDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangKy dangKy = new DangKy();
            dangKy.ShowDialog();
        }
    }
}
