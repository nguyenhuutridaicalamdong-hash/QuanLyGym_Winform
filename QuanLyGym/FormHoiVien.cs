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
    public partial class FormHoiVien : Form
    {
        string connectionString = "Data Source=LAPTOP-BHRC5KJN\\SQLEXPRESS;Initial Catalog=QuanLyGym;Integrated Security=True";

        public FormHoiVien()
        {
            InitializeComponent();
        }

        private void FormHoiVien_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT MaHV, HoTen, GioiTinh, NgaySinh, SDT, DiaChi FROM HoiVien";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvHoiVien.DataSource = dt;
            }
        }

        

        

        

      

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtHoTen.Clear();
            txtGioiTinh.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
            txtSearch.Clear();
            dtNgaySinh.Value = DateTime.Now;
            LoadData();
        }

        private void dgvHoiVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignore header / out-of-range clicks
            if (e.RowIndex < 0 || e.RowIndex >= dgvHoiVien.Rows.Count)
                return;

            try
            {
                DataGridViewRow row = dgvHoiVien.Rows[e.RowIndex];

                // Use column names returned by your SELECT in LoadData()
                txtHoTen.Text = row.Cells["HoTen"].Value?.ToString() ?? string.Empty;
                txtGioiTinh.Text = row.Cells["GioiTinh"].Value?.ToString() ?? string.Empty;
                txtSDT.Text = row.Cells["SDT"].Value?.ToString() ?? string.Empty;
                txtDiaChi.Text = row.Cells["DiaChi"].Value?.ToString() ?? string.Empty;

                object ngaySinhObj = row.Cells["NgaySinh"].Value;
                if (ngaySinhObj != null && ngaySinhObj != DBNull.Value)
                {
                    if (DateTime.TryParse(ngaySinhObj.ToString(), out DateTime ngaySinh))
                        dtNgaySinh.Value = ngaySinh;
                }
            }
            catch (Exception)
            {
                // Fail silently or log if you prefer; keep UI responsive.
            }
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO HoiVien (HoTen, GioiTinh, NgaySinh, SDT, DiaChi, NgayDangKy) " +
                                   "VALUES (@HoTen, @GioiTinh, @NgaySinh, @SDT, @DiaChi, GETDATE())";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text);
                    cmd.Parameters.AddWithValue("@GioiTinh", txtGioiTinh.Text);
                    cmd.Parameters.AddWithValue("@NgaySinh", dtNgaySinh.Value);
                    cmd.Parameters.AddWithValue("@SDT", txtSDT.Text);
                    cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                LoadData();
                MessageBox.Show("Thêm hội viên thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm hội viên: " + ex.Message);
            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (dgvHoiVien.CurrentRow != null)
            {
                int maHV = Convert.ToInt32(dgvHoiVien.CurrentRow.Cells["MaHV"].Value);
                if (MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        string query = "DELETE FROM HoiVien WHERE MaHV=@MaHV";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@MaHV", maHV);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    LoadData();
                    MessageBox.Show(" Xóa thành công!");
                }
            }
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            if (dgvHoiVien.CurrentRow != null)
            {
                int maHV = Convert.ToInt32(dgvHoiVien.CurrentRow.Cells["MaHV"].Value);
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    // Fix update
                    string query = "UPDATE HoiVien SET HoTen=@HoTen, GioiTinh=@GioiTinh, NgaySinh=@NgaySinh, SDT=@SDT, DiaChi=@DiaChi WHERE MaHV=@MaHV";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaHV", maHV);
                    cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text);
                    cmd.Parameters.AddWithValue("@GioiTinh", txtGioiTinh.Text);
                    cmd.Parameters.AddWithValue("@NgaySinh", dtNgaySinh.Value);
                    cmd.Parameters.AddWithValue("@SDT", txtSDT.Text);
                    cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                LoadData();
                MessageBox.Show(" Cập nhật thành công!");
            }
        }

        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            string q = txtSearch.Text?.Trim();

            // Nếu ô tìm kiếm rỗng, load lại toàn bộ dữ liệu
            if (string.IsNullOrEmpty(q))
            {
                LoadData();
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query =
                    "SELECT MaHV, HoTen, GioiTinh, NgaySinh, SDT, DiaChi FROM HoiVien " +
                    "WHERE CAST(MaHV AS NVARCHAR(50)) LIKE @q " +
                    "OR HoTen LIKE @q " +
                    "OR SDT LIKE @q " +
                    "OR GioiTinh LIKE @q " +
                    "OR DiaChi LIKE @q";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@q", "%" + q + "%");
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvHoiVien.DataSource = dt;
            }
        }
    }
}
