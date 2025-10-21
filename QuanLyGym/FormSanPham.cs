using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyGym
{
    public partial class FormSanPham : Form
    {
        string connectionString = "Data Source=LAPTOP-BHRC5KJN\\SQLEXPRESS;Initial Catalog=QuanLyGym;Integrated Security=True";
        public FormSanPham()
        {
            InitializeComponent();
        }

        private void FormSanPham_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM SanPham";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvSanPham.DataSource = dt;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO SanPham (TenSP, Gia, SoLuong, Loai) VALUES (@TenSP, @Gia, @SoLuong, @Loai)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TenSP", txtTenSP.Text);
                cmd.Parameters.AddWithValue("@Gia", Convert.ToDecimal(txtGia.Text));
                cmd.Parameters.AddWithValue("@SoLuong", Convert.ToInt32(txtSoLuong.Text));
                cmd.Parameters.AddWithValue("@Loai", txtLoai.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            LoadData();
            MessageBox.Show(" Thêm sản phẩm thành công!");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvSanPham.CurrentRow != null)
            {
                int maSP = Convert.ToInt32(dgvSanPham.CurrentRow.Cells["MaSP"].Value);
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "UPDATE SanPham SET TenSP=@TenSP, Gia=@Gia, SoLuong=@SoLuong, Loai=@Loai WHERE MaSP=@MaSP";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaSP", maSP);
                    cmd.Parameters.AddWithValue("@TenSP", txtTenSP.Text);
                    cmd.Parameters.AddWithValue("@Gia", Convert.ToDecimal(txtGia.Text));
                    cmd.Parameters.AddWithValue("@SoLuong", Convert.ToInt32(txtSoLuong.Text));
                    cmd.Parameters.AddWithValue("@Loai", txtLoai.Text);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                LoadData();
                MessageBox.Show("✅ Cập nhật sản phẩm thành công!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvSanPham.CurrentRow != null)
            {
                int maSP = Convert.ToInt32(dgvSanPham.CurrentRow.Cells["MaSP"].Value);
                if (MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        string query = "DELETE FROM SanPham WHERE MaSP=@MaSP";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@MaSP", maSP);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    LoadData();
                    MessageBox.Show(" Xóa thành công!");
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM SanPham WHERE TenSP LIKE @TenSP";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@TenSP", "%" + txtSearch.Text + "%");
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvSanPham.DataSource = dt;
            }
        }

    }
}
