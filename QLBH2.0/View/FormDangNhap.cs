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



namespace QLBH2._0.View
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public class LuuThongTin
        {
            static public string tk1;
        }

        public void BtnLogin_Click(object sender, EventArgs e)
        {
          
            SqlConnection conn = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=QLNS2.0;Integrated Security=True");
            {
                
                conn.Open();
                string tk = txttk.Text;
                string mk = txtmk.Text;
                SqlDataAdapter da= new SqlDataAdapter(" select*from DangNhap where TenDangNhap = '" + tk + "' and MatKhau = '" + mk + "'",conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Well come HRM,bấm OK để vào");
                    this.Hide();
                   
                    Form1 f11 = new Form1(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString());
                    f11.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu");
                }
                
            }
        }

        private void FormDangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
           
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Themtaikhoan ttk = new Themtaikhoan();
            ttk.ShowDialog();

            this.Close();
        }
    }
}
        