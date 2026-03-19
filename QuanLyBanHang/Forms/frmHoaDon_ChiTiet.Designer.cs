namespace QuanLyBanHang.Forms
{
    partial class frmHoaDon_ChiTiet
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            SanPhamID = new DataGridViewTextBoxColumn();
            TenSanPham = new DataGridViewTextBoxColumn();
            DonGiaBan = new DataGridViewTextBoxColumn();
            SoLuongBan = new DataGridViewTextBoxColumn();
            ThanhTien = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            btnXacNhanBan = new Button();
            cboSanPham = new ComboBox();
            label3 = new Label();
            numDonGiaBan = new NumericUpDown();
            numSoLuongBan = new NumericUpDown();
            label5 = new Label();
            label6 = new Label();
            btnXoa = new Button();
            btnThoat = new Button();
            groupBox3 = new GroupBox();
            txtGhiChuHoaDon = new TextBox();
            label4 = new Label();
            cboKhachHang = new ComboBox();
            g = new Label();
            cboNhanVien = new ComboBox();
            sd = new Label();
            btnLuuHoaDon = new Button();
            btnInHoaDon = new Button();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDonGiaBan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuongBan).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Location = new Point(15, 230);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(909, 327);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { SanPhamID, TenSanPham, DonGiaBan, SoLuongBan, ThanhTien });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 23);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(903, 301);
            dataGridView.TabIndex = 2;
            dataGridView.CellClick += dataGridView_CellClick;
            // 
            // SanPhamID
            // 
            SanPhamID.DataPropertyName = "SanPhamID";
            SanPhamID.HeaderText = "ID";
            SanPhamID.MinimumWidth = 6;
            SanPhamID.Name = "SanPhamID";
            SanPhamID.ReadOnly = true;
            // 
            // TenSanPham
            // 
            TenSanPham.DataPropertyName = "TenSanPham";
            TenSanPham.HeaderText = "Tên sản phẩm";
            TenSanPham.MinimumWidth = 6;
            TenSanPham.Name = "TenSanPham";
            TenSanPham.ReadOnly = true;
            // 
            // DonGiaBan
            // 
            DonGiaBan.DataPropertyName = "DonGiaBan";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            DonGiaBan.DefaultCellStyle = dataGridViewCellStyle1;
            DonGiaBan.HeaderText = "Đơn giá bán";
            DonGiaBan.MinimumWidth = 6;
            DonGiaBan.Name = "DonGiaBan";
            DonGiaBan.ReadOnly = true;
            // 
            // SoLuongBan
            // 
            SoLuongBan.DataPropertyName = "SoLuongBan";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            SoLuongBan.DefaultCellStyle = dataGridViewCellStyle2;
            SoLuongBan.HeaderText = "Số lượng bán";
            SoLuongBan.MinimumWidth = 6;
            SoLuongBan.Name = "SoLuongBan";
            SoLuongBan.ReadOnly = true;
            // 
            // ThanhTien
            // 
            ThanhTien.DataPropertyName = "ThanhTien";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Blue;
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            ThanhTien.DefaultCellStyle = dataGridViewCellStyle3;
            ThanhTien.HeaderText = "Thành tiền";
            ThanhTien.MinimumWidth = 6;
            ThanhTien.Name = "ThanhTien";
            ThanhTien.ReadOnly = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnXacNhanBan);
            groupBox1.Controls.Add(cboSanPham);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(numDonGiaBan);
            groupBox1.Controls.Add(numSoLuongBan);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Location = new Point(15, 145);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(909, 91);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin chi tiết hóa đơn";
            // 
            // btnXacNhanBan
            // 
            btnXacNhanBan.BackColor = SystemColors.ControlLight;
            btnXacNhanBan.ForeColor = Color.Black;
            btnXacNhanBan.Location = new Point(662, 49);
            btnXacNhanBan.Name = "btnXacNhanBan";
            btnXacNhanBan.Size = new Size(116, 29);
            btnXacNhanBan.TabIndex = 18;
            btnXacNhanBan.Text = "Xác nhận bán";
            btnXacNhanBan.UseVisualStyleBackColor = false;
            btnXacNhanBan.Click += btnXacNhanBan_Click;
            // 
            // cboSanPham
            // 
            cboSanPham.FormattingEnabled = true;
            cboSanPham.Location = new Point(30, 51);
            cboSanPham.Name = "cboSanPham";
            cboSanPham.Size = new Size(223, 28);
            cboSanPham.TabIndex = 17;
            cboSanPham.SelectionChangeCommitted += cboSanPham_SelectionChangeCommitted;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 28);
            label3.Name = "label3";
            label3.Size = new Size(98, 20);
            label3.TabIndex = 16;
            label3.Text = "Sản phẩm (*):";
            // 
            // numDonGiaBan
            // 
            numDonGiaBan.Location = new Point(276, 50);
            numDonGiaBan.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numDonGiaBan.Name = "numDonGiaBan";
            numDonGiaBan.Size = new Size(161, 27);
            numDonGiaBan.TabIndex = 15;
            numDonGiaBan.ThousandsSeparator = true;
            // 
            // numSoLuongBan
            // 
            numSoLuongBan.Location = new Point(464, 50);
            numSoLuongBan.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numSoLuongBan.Name = "numSoLuongBan";
            numSoLuongBan.Size = new Size(164, 27);
            numSoLuongBan.TabIndex = 14;
            numSoLuongBan.ThousandsSeparator = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(276, 28);
            label5.Name = "label5";
            label5.Size = new Size(114, 20);
            label5.TabIndex = 13;
            label5.Text = "Đơn giá bán (*):";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(464, 27);
            label6.Name = "label6";
            label6.Size = new Size(117, 20);
            label6.TabIndex = 12;
            label6.Text = "Số lượng bán(*):";
            // 
            // btnXoa
            // 
            btnXoa.BackColor = SystemColors.ControlLight;
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(784, 48);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = SystemColors.ControlLight;
            btnThoat.ForeColor = Color.Red;
            btnThoat.Location = new Point(476, 576);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtGhiChuHoaDon);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(cboKhachHang);
            groupBox3.Controls.Add(g);
            groupBox3.Controls.Add(cboNhanVien);
            groupBox3.Controls.Add(sd);
            groupBox3.Location = new Point(15, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(909, 127);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin hóa đơn";
            // 
            // txtGhiChuHoaDon
            // 
            txtGhiChuHoaDon.Location = new Point(152, 68);
            txtGhiChuHoaDon.Name = "txtGhiChuHoaDon";
            txtGhiChuHoaDon.Size = new Size(723, 27);
            txtGhiChuHoaDon.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 74);
            label4.Name = "label4";
            label4.Size = new Size(120, 20);
            label4.TabIndex = 20;
            label4.Text = "Ghi chú hóa đơn:";
            // 
            // cboKhachHang
            // 
            cboKhachHang.FormattingEnabled = true;
            cboKhachHang.Location = new Point(572, 34);
            cboKhachHang.Name = "cboKhachHang";
            cboKhachHang.Size = new Size(303, 28);
            cboKhachHang.TabIndex = 19;
            // 
            // g
            // 
            g.AutoSize = true;
            g.Location = new Point(461, 37);
            g.Name = "g";
            g.Size = new Size(109, 20);
            g.TabIndex = 18;
            g.Text = "Khách hàng (*):";
            // 
            // cboNhanVien
            // 
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Location = new Point(152, 34);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(282, 28);
            cboNhanVien.TabIndex = 17;
            // 
            // sd
            // 
            sd.AutoSize = true;
            sd.Location = new Point(27, 37);
            sd.Name = "sd";
            sd.Size = new Size(123, 20);
            sd.TabIndex = 16;
            sd.Text = "Nhân viên lập (*):";
            // 
            // btnLuuHoaDon
            // 
            btnLuuHoaDon.BackColor = SystemColors.ControlLight;
            btnLuuHoaDon.ForeColor = Color.Blue;
            btnLuuHoaDon.Location = new Point(219, 576);
            btnLuuHoaDon.Name = "btnLuuHoaDon";
            btnLuuHoaDon.Size = new Size(125, 29);
            btnLuuHoaDon.TabIndex = 10;
            btnLuuHoaDon.Text = "Lưu hóa đơn ";
            btnLuuHoaDon.UseVisualStyleBackColor = false;
            btnLuuHoaDon.Click += btnLuuHoaDon_Click;
            // 
            // btnInHoaDon
            // 
            btnInHoaDon.BackColor = SystemColors.ControlLight;
            btnInHoaDon.Location = new Point(358, 576);
            btnInHoaDon.Name = "btnInHoaDon";
            btnInHoaDon.Size = new Size(112, 29);
            btnInHoaDon.TabIndex = 11;
            btnInHoaDon.Text = "In hóa đơn…";
            btnInHoaDon.UseVisualStyleBackColor = false;
            // 
            // frmHoaDon_ChiTiet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(948, 617);
            Controls.Add(btnInHoaDon);
            Controls.Add(btnLuuHoaDon);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(btnThoat);
            Name = "frmHoaDon_ChiTiet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hóa đơn chi tiết";
            Load += frmHoaDon_ChiTiet_Load;
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDonGiaBan).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuongBan).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private DataGridView dataGridView;
        private GroupBox groupBox1;
        private NumericUpDown numDonGiaBan;
        private NumericUpDown numSoLuongBan;
        private Label label5;
        private Label label6;
        private Button btnThoat;
        private Button btnXoa;
        private ComboBox cboSanPham;
        private Label label3;
        private Button btnXacNhanBan;
        private GroupBox groupBox3;
        private TextBox txtGhiChuHoaDon;
        private Label label4;
        private ComboBox cboKhachHang;
        private Label g;
        private ComboBox cboNhanVien;
        private Label sd;
        private DataGridViewTextBoxColumn SanPhamID;
        private DataGridViewTextBoxColumn TenSanPham;
        private DataGridViewTextBoxColumn DonGiaBan;
        private DataGridViewTextBoxColumn SoLuongBan;
        private DataGridViewTextBoxColumn ThanhTien;
        private Button btnLuuHoaDon;
        private Button btnInHoaDon;
    }
}