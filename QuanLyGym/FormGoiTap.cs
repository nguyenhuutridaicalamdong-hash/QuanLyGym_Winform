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
using System.Globalization;
using System.Text.RegularExpressions;

namespace QuanLyGym
{
    public partial class FormGoiTap : Form
    {
        string connectionString = "Data Source=LAPTOP-BHRC5KJN\\SQLEXPRESS;Initial Catalog=QuanLyGym;Integrated Security=True";
        public FormGoiTap()
        {
            InitializeComponent();
        }

        private void FormGoiTap_Load(object sender, EventArgs e)
        {
            
            cmbThoiHan.Items.AddRange(new object[] { "1 tháng", "2 tháng", "3 tháng", "4 tháng", "5 tháng", "6 tháng", "7 tháng", "8 tháng", "9 tháng", "10 tháng", "12 tháng" });
            LoadData();

        }

        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM GoiTap";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvGoiTap.DataSource = dt;
            }
        }

        

        

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            string txt = cmbThoiHan.Text ?? "";
            var m = Regex.Match(txt, @"\d+");
            if (!m.Success)
            {
                MessageBox.Show("Chọn thời hạn hợp lệ.");
                return;
            }
            int thoiHanMonths = int.Parse(m.Value, CultureInfo.InvariantCulture);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO GoiTap (TenGoi, Gia, ThoiHan, MoTa) VALUES (@TenGoi, @Gia, @ThoiHan, @MoTa)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@TenGoi", SqlDbType.NVarChar, 200).Value = txtTenGoi.Text;
                cmd.Parameters.Add("@Gia", SqlDbType.Decimal).Value = decimal.Parse(txtGia.Text, CultureInfo.CurrentCulture);
                cmd.Parameters.Add("@ThoiHan", SqlDbType.Int).Value = thoiHanMonths;
                cmd.Parameters.Add("@MoTa", SqlDbType.NVarChar, 500).Value = txtMoTa.Text;
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            LoadData();
            MessageBox.Show(" Thêm gói tập thành công!");
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (dgvGoiTap.CurrentRow != null)
            {
                int maGoi = Convert.ToInt32(dgvGoiTap.CurrentRow.Cells["MaGoi"].Value);
                if (MessageBox.Show("Xóa gói tập này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        string query = "DELETE FROM GoiTap WHERE MaGoi=@MaGoi";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@MaGoi", maGoi);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    LoadData();
                    MessageBox.Show(" Xóa thành công!");
                }
            }
        }
    }
}
