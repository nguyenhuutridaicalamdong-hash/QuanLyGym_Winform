namespace QuanLyGym
{
    partial class FormHoiVien
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
            this.dgvHoiVien = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtGioiTinh = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.btnLamMoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoiVien)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHoiVien
            // 
            this.dgvHoiVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoiVien.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvHoiVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoiVien.Location = new System.Drawing.Point(650, 189);
            this.dgvHoiVien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvHoiVien.Name = "dgvHoiVien";
            this.dgvHoiVien.RowHeadersWidth = 51;
            this.dgvHoiVien.RowTemplate.Height = 24;
            this.dgvHoiVien.Size = new System.Drawing.Size(978, 627);
            this.dgvHoiVien.TabIndex = 0;
            this.dgvHoiVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoiVien_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 127);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên hội viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 233);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Giới tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 325);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "SĐT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 417);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày sinh";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(270, 127);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(338, 31);
            this.txtHoTen.TabIndex = 6;
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.Location = new System.Drawing.Point(270, 233);
            this.txtGioiTinh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new System.Drawing.Size(338, 31);
            this.txtGioiTinh.TabIndex = 7;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(270, 325);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(338, 31);
            this.txtSDT.TabIndex = 8;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(924, 117);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(338, 31);
            this.txtSearch.TabIndex = 9;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Moccasin;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Location = new System.Drawing.Point(114, 730);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(112, 36);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Yellow;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Location = new System.Drawing.Point(467, 730);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(112, 36);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click_1);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Yellow;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Location = new System.Drawing.Point(293, 730);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(112, 36);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(758, 117);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(112, 36);
            this.btnTimKiem.TabIndex = 13;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click_1);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(270, 475);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(295, 31);
            this.txtDiaChi.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 475);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Địa chỉ";
            // 
            // dtNgaySinh
            // 
            this.dtNgaySinh.Location = new System.Drawing.Point(270, 406);
            this.dtNgaySinh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.Size = new System.Drawing.Size(298, 31);
            this.dtNgaySinh.TabIndex = 16;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.Moccasin;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Location = new System.Drawing.Point(1516, 850);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(112, 36);
            this.btnLamMoi.TabIndex = 17;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // FormHoiVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1646, 900);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.dtNgaySinh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtGioiTinh);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvHoiVien);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormHoiVien";
            this.Text = "FormHoiVien";
            this.Load += new System.EventHandler(this.FormHoiVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoiVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHoiVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtGioiTinh;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtNgaySinh;
        private System.Windows.Forms.Button btnLamMoi;
    }
}