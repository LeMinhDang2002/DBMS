namespace Nhom15_BaybyStore
{
    partial class SanPham
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
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtTimKiemSanPham = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIDSanPham = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenSanPham = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDoanhMuc = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbNhaCungCap = new System.Windows.Forms.ComboBox();
            this.dtpNSX = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpHSD = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGiaSanPham = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbCuaHang = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnDoanhMuc = new FontAwesome.Sharp.IconButton();
            this.btnNhaCungCap = new FontAwesome.Sharp.IconButton();
            this.btnSuaSanPham = new FontAwesome.Sharp.IconButton();
            this.btnXoaSanPham = new FontAwesome.Sharp.IconButton();
            this.btnThemSanPham = new FontAwesome.Sharp.IconButton();
            this.btnTimKiemSanPham = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.rdbSanPhamHetHan = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(61)))), ((int)(((byte)(127)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSanPham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgvSanPham.EnableHeadersVisualStyles = false;
            this.dgvSanPham.Location = new System.Drawing.Point(223, 481);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.RowHeadersWidth = 62;
            this.dgvSanPham.RowTemplate.Height = 28;
            this.dgvSanPham.Size = new System.Drawing.Size(1365, 287);
            this.dgvSanPham.TabIndex = 106;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên sản phẩm";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Doanh mục";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Nhà cung cấp";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 200;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "NSX";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "HSD";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.Width = 150;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Gia";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.Width = 150;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Cửa hàng";
            this.Column8.MinimumWidth = 8;
            this.Column8.Name = "Column8";
            this.Column8.Width = 150;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(61)))), ((int)(((byte)(127)))));
            this.panel4.Location = new System.Drawing.Point(276, 467);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(308, 1);
            this.panel4.TabIndex = 97;
            // 
            // txtTimKiemSanPham
            // 
            this.txtTimKiemSanPham.BackColor = System.Drawing.Color.White;
            this.txtTimKiemSanPham.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTimKiemSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemSanPham.Location = new System.Drawing.Point(276, 433);
            this.txtTimKiemSanPham.Name = "txtTimKiemSanPham";
            this.txtTimKiemSanPham.Size = new System.Drawing.Size(308, 32);
            this.txtTimKiemSanPham.TabIndex = 96;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(853, 449);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(253, 29);
            this.label7.TabIndex = 93;
            this.label7.Text = "Danh sách sản phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(427, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 113;
            this.label3.Text = "Doanh mục:";
            // 
            // txtIDSanPham
            // 
            this.txtIDSanPham.BackColor = System.Drawing.Color.White;
            this.txtIDSanPham.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIDSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDSanPham.Location = new System.Drawing.Point(16, 37);
            this.txtIDSanPham.Name = "txtIDSanPham";
            this.txtIDSanPham.ReadOnly = true;
            this.txtIDSanPham.Size = new System.Drawing.Size(291, 32);
            this.txtIDSanPham.TabIndex = 108;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 20);
            this.label1.TabIndex = 107;
            this.label1.Text = "ID:";
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.BackColor = System.Drawing.Color.White;
            this.txtTenSanPham.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSanPham.Location = new System.Drawing.Point(12, 130);
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.Size = new System.Drawing.Size(291, 32);
            this.txtTenSanPham.TabIndex = 111;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(61)))), ((int)(((byte)(127)))));
            this.panel1.Location = new System.Drawing.Point(16, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 1);
            this.panel1.TabIndex = 109;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(61)))), ((int)(((byte)(127)))));
            this.panel2.Location = new System.Drawing.Point(12, 166);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(291, 1);
            this.panel2.TabIndex = 112;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 110;
            this.label2.Text = "Tên sản phẩm:";
            // 
            // cmbDoanhMuc
            // 
            this.cmbDoanhMuc.FormattingEnabled = true;
            this.cmbDoanhMuc.Location = new System.Drawing.Point(427, 56);
            this.cmbDoanhMuc.Name = "cmbDoanhMuc";
            this.cmbDoanhMuc.Size = new System.Drawing.Size(291, 28);
            this.cmbDoanhMuc.TabIndex = 119;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(427, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 113;
            this.label4.Text = "Nhà cung cấp:";
            // 
            // cmbNhaCungCap
            // 
            this.cmbNhaCungCap.FormattingEnabled = true;
            this.cmbNhaCungCap.Location = new System.Drawing.Point(427, 139);
            this.cmbNhaCungCap.Name = "cmbNhaCungCap";
            this.cmbNhaCungCap.Size = new System.Drawing.Size(291, 28);
            this.cmbNhaCungCap.TabIndex = 119;
            // 
            // dtpNSX
            // 
            this.dtpNSX.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtpNSX.CalendarTitleForeColor = System.Drawing.Color.AliceBlue;
            this.dtpNSX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNSX.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNSX.Location = new System.Drawing.Point(930, 56);
            this.dtpNSX.Name = "dtpNSX";
            this.dtpNSX.Size = new System.Drawing.Size(287, 28);
            this.dtpNSX.TabIndex = 123;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(925, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 121;
            this.label5.Text = "NSX:";
            // 
            // dtpHSD
            // 
            this.dtpHSD.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtpHSD.CalendarTitleForeColor = System.Drawing.Color.AliceBlue;
            this.dtpHSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHSD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHSD.Location = new System.Drawing.Point(929, 135);
            this.dtpHSD.Name = "dtpHSD";
            this.dtpHSD.Size = new System.Drawing.Size(287, 28);
            this.dtpHSD.TabIndex = 126;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(924, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 124;
            this.label6.Text = "HSD:";
            // 
            // txtGiaSanPham
            // 
            this.txtGiaSanPham.BackColor = System.Drawing.Color.White;
            this.txtGiaSanPham.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGiaSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaSanPham.Location = new System.Drawing.Point(12, 240);
            this.txtGiaSanPham.Name = "txtGiaSanPham";
            this.txtGiaSanPham.Size = new System.Drawing.Size(291, 32);
            this.txtGiaSanPham.TabIndex = 128;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(61)))), ((int)(((byte)(127)))));
            this.panel3.Location = new System.Drawing.Point(12, 276);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(291, 1);
            this.panel3.TabIndex = 129;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 20);
            this.label8.TabIndex = 127;
            this.label8.Text = "Giá:";
            // 
            // cmbCuaHang
            // 
            this.cmbCuaHang.FormattingEnabled = true;
            this.cmbCuaHang.Location = new System.Drawing.Point(427, 244);
            this.cmbCuaHang.Name = "cmbCuaHang";
            this.cmbCuaHang.Size = new System.Drawing.Size(291, 28);
            this.cmbCuaHang.TabIndex = 131;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(427, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 20);
            this.label9.TabIndex = 130;
            this.label9.Text = "Cửa hàng:";
            // 
            // btnDoanhMuc
            // 
            this.btnDoanhMuc.BackColor = System.Drawing.Color.White;
            this.btnDoanhMuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoanhMuc.ForeColor = System.Drawing.Color.White;
            this.btnDoanhMuc.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.btnDoanhMuc.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(61)))), ((int)(((byte)(127)))));
            this.btnDoanhMuc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDoanhMuc.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDoanhMuc.Location = new System.Drawing.Point(722, 39);
            this.btnDoanhMuc.Name = "btnDoanhMuc";
            this.btnDoanhMuc.Size = new System.Drawing.Size(60, 60);
            this.btnDoanhMuc.TabIndex = 120;
            this.btnDoanhMuc.UseVisualStyleBackColor = false;
            this.btnDoanhMuc.Click += new System.EventHandler(this.btnDoanhMuc_Click);
            this.btnDoanhMuc.MouseEnter += new System.EventHandler(this.btnDoanhMuc_MouseEnter);
            this.btnDoanhMuc.MouseLeave += new System.EventHandler(this.btnDoanhMuc_MouseLeave);
            // 
            // btnNhaCungCap
            // 
            this.btnNhaCungCap.BackColor = System.Drawing.Color.White;
            this.btnNhaCungCap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhaCungCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhaCungCap.ForeColor = System.Drawing.Color.White;
            this.btnNhaCungCap.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.btnNhaCungCap.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(61)))), ((int)(((byte)(127)))));
            this.btnNhaCungCap.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNhaCungCap.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNhaCungCap.Location = new System.Drawing.Point(722, 126);
            this.btnNhaCungCap.Name = "btnNhaCungCap";
            this.btnNhaCungCap.Size = new System.Drawing.Size(60, 60);
            this.btnNhaCungCap.TabIndex = 120;
            this.btnNhaCungCap.UseVisualStyleBackColor = false;
            this.btnNhaCungCap.Click += new System.EventHandler(this.btnNhaCungCap_Click);
            // 
            // btnSuaSanPham
            // 
            this.btnSuaSanPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(61)))), ((int)(((byte)(127)))));
            this.btnSuaSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaSanPham.ForeColor = System.Drawing.Color.White;
            this.btnSuaSanPham.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSuaSanPham.IconColor = System.Drawing.Color.Black;
            this.btnSuaSanPham.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSuaSanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaSanPham.Location = new System.Drawing.Point(1219, 237);
            this.btnSuaSanPham.Name = "btnSuaSanPham";
            this.btnSuaSanPham.Size = new System.Drawing.Size(142, 35);
            this.btnSuaSanPham.TabIndex = 116;
            this.btnSuaSanPham.Text = "Sửa";
            this.btnSuaSanPham.UseVisualStyleBackColor = false;
            // 
            // btnXoaSanPham
            // 
            this.btnXoaSanPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(61)))), ((int)(((byte)(127)))));
            this.btnXoaSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaSanPham.ForeColor = System.Drawing.Color.White;
            this.btnXoaSanPham.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnXoaSanPham.IconColor = System.Drawing.Color.Black;
            this.btnXoaSanPham.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoaSanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaSanPham.Location = new System.Drawing.Point(1071, 237);
            this.btnXoaSanPham.Name = "btnXoaSanPham";
            this.btnXoaSanPham.Size = new System.Drawing.Size(142, 35);
            this.btnXoaSanPham.TabIndex = 118;
            this.btnXoaSanPham.Text = "Xóa";
            this.btnXoaSanPham.UseVisualStyleBackColor = false;
            // 
            // btnThemSanPham
            // 
            this.btnThemSanPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(61)))), ((int)(((byte)(127)))));
            this.btnThemSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemSanPham.ForeColor = System.Drawing.Color.White;
            this.btnThemSanPham.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnThemSanPham.IconColor = System.Drawing.Color.Black;
            this.btnThemSanPham.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThemSanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemSanPham.Location = new System.Drawing.Point(922, 237);
            this.btnThemSanPham.Name = "btnThemSanPham";
            this.btnThemSanPham.Size = new System.Drawing.Size(142, 35);
            this.btnThemSanPham.TabIndex = 117;
            this.btnThemSanPham.Text = "Thêm";
            this.btnThemSanPham.UseVisualStyleBackColor = false;
            // 
            // btnTimKiemSanPham
            // 
            this.btnTimKiemSanPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(61)))), ((int)(((byte)(127)))));
            this.btnTimKiemSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiemSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemSanPham.ForeColor = System.Drawing.Color.White;
            this.btnTimKiemSanPham.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnTimKiemSanPham.IconColor = System.Drawing.Color.Aquamarine;
            this.btnTimKiemSanPham.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTimKiemSanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiemSanPham.Location = new System.Drawing.Point(590, 434);
            this.btnTimKiemSanPham.Name = "btnTimKiemSanPham";
            this.btnTimKiemSanPham.Size = new System.Drawing.Size(142, 35);
            this.btnTimKiemSanPham.TabIndex = 104;
            this.btnTimKiemSanPham.Text = "Tìm kiếm";
            this.btnTimKiemSanPham.UseVisualStyleBackColor = false;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(61)))), ((int)(((byte)(127)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(61)))), ((int)(((byte)(127)))));
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 35;
            this.iconPictureBox1.Location = new System.Drawing.Point(223, 440);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(36, 35);
            this.iconPictureBox1.TabIndex = 101;
            this.iconPictureBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(5, 467);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 20);
            this.label10.TabIndex = 127;
            this.label10.Text = "Bộ lọc tìm kiếm";
            // 
            // rdbSanPhamHetHan
            // 
            this.rdbSanPhamHetHan.AutoSize = true;
            this.rdbSanPhamHetHan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbSanPhamHetHan.Location = new System.Drawing.Point(9, 531);
            this.rdbSanPhamHetHan.Name = "rdbSanPhamHetHan";
            this.rdbSanPhamHetHan.Size = new System.Drawing.Size(165, 24);
            this.rdbSanPhamHetHan.TabIndex = 132;
            this.rdbSanPhamHetHan.TabStop = true;
            this.rdbSanPhamHetHan.Text = "Sản phẩm hết hạn";
            this.rdbSanPhamHetHan.UseVisualStyleBackColor = true;
            // 
            // SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1600, 780);
            this.Controls.Add(this.rdbSanPhamHetHan);
            this.Controls.Add(this.cmbCuaHang);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtGiaSanPham);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpHSD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpNSX);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDoanhMuc);
            this.Controls.Add(this.btnNhaCungCap);
            this.Controls.Add(this.cmbNhaCungCap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbDoanhMuc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSuaSanPham);
            this.Controls.Add(this.btnXoaSanPham);
            this.Controls.Add(this.btnThemSanPham);
            this.Controls.Add(this.txtIDSanPham);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTenSanPham);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvSanPham);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnTimKiemSanPham);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.txtTimKiemSanPham);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SanPham";
            this.Text = "SanPham";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton btnTimKiemSanPham;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.TextBox txtTimKiemSanPham;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIDSanPham;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenSanPham;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDoanhMuc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbNhaCungCap;
        private FontAwesome.Sharp.IconButton btnNhaCungCap;
        private FontAwesome.Sharp.IconButton btnDoanhMuc;
        private System.Windows.Forms.DateTimePicker dtpNSX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpHSD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.TextBox txtGiaSanPham;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconButton btnThemSanPham;
        private FontAwesome.Sharp.IconButton btnXoaSanPham;
        private FontAwesome.Sharp.IconButton btnSuaSanPham;
        private System.Windows.Forms.ComboBox cmbCuaHang;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rdbSanPhamHetHan;
    }
}