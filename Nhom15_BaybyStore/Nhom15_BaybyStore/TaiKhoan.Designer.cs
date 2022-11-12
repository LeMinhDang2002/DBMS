namespace Nhom15_BaybyStore
{
    partial class TaiKhoan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvTaiKhoan = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.btnTimKiemTaiKhoan = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtTimKiemTaiKhoan = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTenTaiKhoan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbLoaiTaiKhoan = new System.Windows.Forms.ComboBox();
            this.btnSuaTaiKhoan = new FontAwesome.Sharp.IconButton();
            this.btnXoaTaiKhoan = new FontAwesome.Sharp.IconButton();
            this.btnThemTaiKhoan = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTaiKhoan
            // 
            this.dgvTaiKhoan.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(61)))), ((int)(((byte)(127)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTaiKhoan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaiKhoan.EnableHeadersVisualStyles = false;
            this.dgvTaiKhoan.Location = new System.Drawing.Point(11, 140);
            this.dgvTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTaiKhoan.Name = "dgvTaiKhoan";
            this.dgvTaiKhoan.RowHeadersWidth = 62;
            this.dgvTaiKhoan.RowTemplate.Height = 28;
            this.dgvTaiKhoan.Size = new System.Drawing.Size(637, 474);
            this.dgvTaiKhoan.TabIndex = 88;
            this.dgvTaiKhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTaiKhoan_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(181, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(209, 25);
            this.label7.TabIndex = 72;
            this.label7.Text = "Danh sách tài khoản";
            // 
            // btnTimKiemTaiKhoan
            // 
            this.btnTimKiemTaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(61)))), ((int)(((byte)(127)))));
            this.btnTimKiemTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiemTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.btnTimKiemTaiKhoan.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnTimKiemTaiKhoan.IconColor = System.Drawing.Color.Aquamarine;
            this.btnTimKiemTaiKhoan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTimKiemTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiemTaiKhoan.Location = new System.Drawing.Point(478, 96);
            this.btnTimKiemTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiemTaiKhoan.Name = "btnTimKiemTaiKhoan";
            this.btnTimKiemTaiKhoan.Size = new System.Drawing.Size(126, 28);
            this.btnTimKiemTaiKhoan.TabIndex = 92;
            this.btnTimKiemTaiKhoan.Text = "Tìm kiếm";
            this.btnTimKiemTaiKhoan.UseVisualStyleBackColor = false;
            this.btnTimKiemTaiKhoan.Click += new System.EventHandler(this.btnTimKiemTaiKhoan_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(61)))), ((int)(((byte)(127)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(61)))), ((int)(((byte)(127)))));
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 28;
            this.iconPictureBox1.Location = new System.Drawing.Point(38, 98);
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(33, 28);
            this.iconPictureBox1.TabIndex = 91;
            this.iconPictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(61)))), ((int)(((byte)(127)))));
            this.panel4.Location = new System.Drawing.Point(87, 120);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(363, 1);
            this.panel4.TabIndex = 90;
            // 
            // txtTimKiemTaiKhoan
            // 
            this.txtTimKiemTaiKhoan.BackColor = System.Drawing.Color.White;
            this.txtTimKiemTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTimKiemTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemTaiKhoan.Location = new System.Drawing.Point(87, 93);
            this.txtTimKiemTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiemTaiKhoan.Name = "txtTimKiemTaiKhoan";
            this.txtTimKiemTaiKhoan.Size = new System.Drawing.Size(363, 27);
            this.txtTimKiemTaiKhoan.TabIndex = 89;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(61)))), ((int)(((byte)(127)))));
            this.panel2.Location = new System.Drawing.Point(937, 291);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(259, 1);
            this.panel2.TabIndex = 98;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BackColor = System.Drawing.Color.White;
            this.txtMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(937, 262);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(259, 27);
            this.txtMatKhau.TabIndex = 97;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(933, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 96;
            this.label2.Text = "Mật khẩu:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(61)))), ((int)(((byte)(127)))));
            this.panel1.Location = new System.Drawing.Point(937, 203);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 1);
            this.panel1.TabIndex = 95;
            // 
            // txtTenTaiKhoan
            // 
            this.txtTenTaiKhoan.BackColor = System.Drawing.Color.White;
            this.txtTenTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTaiKhoan.Location = new System.Drawing.Point(934, 174);
            this.txtTenTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            this.txtTenTaiKhoan.ReadOnly = true;
            this.txtTenTaiKhoan.Size = new System.Drawing.Size(259, 27);
            this.txtTenTaiKhoan.TabIndex = 94;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(930, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 93;
            this.label1.Text = "Tên tài khoản:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(933, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 96;
            this.label3.Text = "Loại tài khoản:";
            // 
            // cmbLoaiTaiKhoan
            // 
            this.cmbLoaiTaiKhoan.FormattingEnabled = true;
            this.cmbLoaiTaiKhoan.Location = new System.Drawing.Point(937, 396);
            this.cmbLoaiTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbLoaiTaiKhoan.Name = "cmbLoaiTaiKhoan";
            this.cmbLoaiTaiKhoan.Size = new System.Drawing.Size(259, 24);
            this.cmbLoaiTaiKhoan.TabIndex = 99;
            // 
            // btnSuaTaiKhoan
            // 
            this.btnSuaTaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(61)))), ((int)(((byte)(127)))));
            this.btnSuaTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.btnSuaTaiKhoan.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSuaTaiKhoan.IconColor = System.Drawing.Color.Black;
            this.btnSuaTaiKhoan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSuaTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaTaiKhoan.Location = new System.Drawing.Point(1143, 531);
            this.btnSuaTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuaTaiKhoan.Name = "btnSuaTaiKhoan";
            this.btnSuaTaiKhoan.Size = new System.Drawing.Size(126, 28);
            this.btnSuaTaiKhoan.TabIndex = 100;
            this.btnSuaTaiKhoan.Text = "Sửa";
            this.btnSuaTaiKhoan.UseVisualStyleBackColor = false;
            this.btnSuaTaiKhoan.Click += new System.EventHandler(this.btnSuaTaiKhoan_Click);
            // 
            // btnXoaTaiKhoan
            // 
            this.btnXoaTaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(61)))), ((int)(((byte)(127)))));
            this.btnXoaTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.btnXoaTaiKhoan.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnXoaTaiKhoan.IconColor = System.Drawing.Color.Black;
            this.btnXoaTaiKhoan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoaTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaTaiKhoan.Location = new System.Drawing.Point(1011, 531);
            this.btnXoaTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaTaiKhoan.Name = "btnXoaTaiKhoan";
            this.btnXoaTaiKhoan.Size = new System.Drawing.Size(126, 28);
            this.btnXoaTaiKhoan.TabIndex = 102;
            this.btnXoaTaiKhoan.Text = "Xóa";
            this.btnXoaTaiKhoan.UseVisualStyleBackColor = false;
            this.btnXoaTaiKhoan.Click += new System.EventHandler(this.btnXoaTaiKhoan_Click);
            // 
            // btnThemTaiKhoan
            // 
            this.btnThemTaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(61)))), ((int)(((byte)(127)))));
            this.btnThemTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.btnThemTaiKhoan.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnThemTaiKhoan.IconColor = System.Drawing.Color.Black;
            this.btnThemTaiKhoan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThemTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemTaiKhoan.Location = new System.Drawing.Point(878, 531);
            this.btnThemTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemTaiKhoan.Name = "btnThemTaiKhoan";
            this.btnThemTaiKhoan.Size = new System.Drawing.Size(126, 28);
            this.btnThemTaiKhoan.TabIndex = 101;
            this.btnThemTaiKhoan.Text = "Thêm";
            this.btnThemTaiKhoan.UseVisualStyleBackColor = false;
            this.btnThemTaiKhoan.Click += new System.EventHandler(this.btnThemTaiKhoan_Click);
            // 
            // TaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1422, 624);
            this.Controls.Add(this.btnSuaTaiKhoan);
            this.Controls.Add(this.btnXoaTaiKhoan);
            this.Controls.Add(this.btnThemTaiKhoan);
            this.Controls.Add(this.cmbLoaiTaiKhoan);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtTenTaiKhoan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTimKiemTaiKhoan);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txtTimKiemTaiKhoan);
            this.Controls.Add(this.dgvTaiKhoan);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TaiKhoan";
            this.Text = "TaiKhoan";
            this.Load += new System.EventHandler(this.TaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvTaiKhoan;
        private System.Windows.Forms.Label label7;
        private FontAwesome.Sharp.IconButton btnTimKiemTaiKhoan;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtTimKiemTaiKhoan;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTenTaiKhoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbLoaiTaiKhoan;
        private FontAwesome.Sharp.IconButton btnSuaTaiKhoan;
        private FontAwesome.Sharp.IconButton btnXoaTaiKhoan;
        private FontAwesome.Sharp.IconButton btnThemTaiKhoan;
    }
}