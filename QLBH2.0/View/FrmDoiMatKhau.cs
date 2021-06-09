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

namespace QLBH2._0
{
    public partial class FrmDoiMatKhau : Form
    {

        public FrmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=QLNS2.0;Integrated Security=True");
            SqlDataAdapter da2 = new SqlDataAdapter("select count(*) from Dangnhap where TenDangNhap = N'" + txttendangnhap.Text + "' and MatKhau = N'" + txtmatkhaucu.Text + "'", cn);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            errorProvider1.Clear();
            if (dt2.Rows[0][0].ToString() == "1")
            {
                if (txtmatkhaumoi.Text == txtxacnhan.Text)
                {
                    SqlDataAdapter da1 = new SqlDataAdapter("update Dangnhap set MatKhau = N'" + txtmatkhaumoi.Text + "' where TenDangNhap = N'" + txttendangnhap.Text + "'", cn);
                    DataTable dt1 = new DataTable();
                    da1.Fill(dt1);
                    MessageBox.Show("Đổi mật khẩu thành công");
                    
                }
                else
                {
                    errorProvider1.SetError(txtmatkhaumoi, "Bạn chưa điền mật khẩu");
                    errorProvider1.SetError(txtxacnhan, "Mật khẩu chưa trùng khớp");
                }
            }
            else
            {
                errorProvider1.SetError(txttendangnhap, "Tên người dùng không đúng");
                errorProvider1.SetError(txtmatkhaucu, "Mật khẩu cũ chưa chính xác");
            }
        }

        private void Btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
            

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}

  

