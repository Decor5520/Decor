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
using QLBH2._0.View;

namespace QLBH2._0
{
    public partial class Themtaikhoan : Form
    {
        public Themtaikhoan()
        {
            InitializeComponent();
        }
        string chuoiketnoi = @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=QLNS2.0;Integrated Security=True";
        string sql;

        SqlConnection ketnoi;
        SqlCommand thuchien;
        SqlDataReader da1;
        int i = 0;

        private void BtnDangki_Click(object sender, EventArgs e)
        {
            if (txttk.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên đăng nhập");
                txttk.Focus();
            }
            else if (txtmk.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu");
                txtmk.Focus();
            }
            else if (txttennguoidung.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên người dùng");
                txttennguoidung.Focus();
            }
            else if (txtxnmk.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập xác nhận mật khẩu");
                txtxnmk.Focus();
            }
            else if (txtxnmk.Text != txtmk.Text)
            {
                MessageBox.Show("Mật khẩu chưa trùng khớp");
                txtxnmk.Focus();
                txtxnmk.SelectAll();
            }
            else
            {

                MessageBox.Show("Đăng kí tài khoản thành công" + "\n\nTên:" + txttennguoidung.Text + "\nTài Khoản:" + txttk.Text + "\nMật Khẩu:" + txtmk.Text);
            }
            list1.Items.Clear();
            ketnoi.Open();
            sql = @"Insert Into DangNhap(TenDangNhap,TenNVien,MatKhau)
     values            ('" + txttk.Text + @"','" + txttennguoidung.Text + @"','" + txtmk.Text + "')";
            thuchien = new SqlCommand(sql, ketnoi);
            thuchien.ExecuteNonQuery();
            ketnoi.Close();
        }

        private void Themtaikhoan_Load(object sender, EventArgs e)
        {
            ketnoi = new SqlConnection(chuoiketnoi);
        }
        public void hienthi()
        {
            list1.Items.Clear();
            ketnoi.Open();
            sql = @"Select TenDangNhap, TenNVien, MatKhau  from DangNhap";
            thuchien = new SqlCommand(sql, ketnoi);
            da1 = thuchien.ExecuteReader();
            i = 0;
            while (da1.Read())
            {
                list1.Items.Add(da1[0].ToString());
                list1.Items[i].SubItems.Add(da1[1].ToString());
                list1.Items[i].SubItems.Add(da1[2].ToString());

            }
            ketnoi.Close();

        }

        private void List1_SelectedIndexChanged(object sender, EventArgs e)
        {

            txttk.Text = list1.SelectedItems[0].SubItems[0].Text;
            txttennguoidung.Text = list1.SelectedItems[0].SubItems[1].Text;
            txtmk.Text = list1.SelectedItems[0].SubItems[2].Text;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FormDangNhap fdn = new FormDangNhap();
            fdn.ShowDialog();
            this.Close();
        }

        private void Txttk_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnEXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Txtxnmk_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txtmk_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Txttennguoidung_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
