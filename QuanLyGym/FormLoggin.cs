using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuanLyGym
{
    public partial class FormLoggin : Form
    {
        string connectionString = "Data Source=LAPTOP-BHRC5KJN\\SQLEXPRESS;Initial Catalog=QuanLyGym;Integrated Security=True";
        public FormLoggin()
        {
            InitializeComponent();
        }

        private void FormLoggin_Load(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            // lấy ra user và pass từ database để so sánh
            string Username = txtUser.Text;
            string Password = txtPass.Text;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT TenDangNhap, MatKhau FROM TaiKhoan WHERE TenDangNhap=@user AND MatKhau=@pass";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@user", txtUser.Text);
                cmd.Parameters.AddWithValue("@pass", txtPass.Text);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();


                if (dr.Read())
                {
                    MessageBox.Show("Đăng nhập thành công!", "✅");
                    this.Hide();
                    new FormMain().ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "❌");
                }


            }

        }

        // Hiển thị mật khẩu
        // Bình ngu ngốc
        // Trí đẹp trai vãi cả lòn

        private void chkShowpass_CheckedChanged(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = !chkShowpass.Checked;
        }

        private void btnDangNhap_Click_1(object sender, EventArgs e)
        {
            // lấy ra user và pass từ database để so sánh
            string Username = txtUser.Text;
            string Password = txtPass.Text;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM TaiKhoan WHERE TenDangNhap=@user AND MatKhau=@pass";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@user", txtUser.Text);
                cmd.Parameters.AddWithValue("@pass", txtPass.Text);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();


                if (dr.Read())
                {
                    MessageBox.Show("Đăng nhập thành công!", "✅");
                    this.Hide();
                    new FormMain().ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "❌");
                }


            }
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
