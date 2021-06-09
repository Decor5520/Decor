using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLBH2._0.View;

namespace QLBH2._0
{
    public partial class FormDau : Form
    {
        public FormDau()
        {
            InitializeComponent();
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void ĐăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            FormDangNhap dn = new FormDangNhap();
            dn.ShowDialog();
        }

        private void ThêmTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Themtaikhoan ftk = new Themtaikhoan();
            ftk.ShowDialog();
        }

        private void ĐổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmDoiMatKhau dmk = new FrmDoiMatKhau();
            dmk.ShowDialog();
           
        }

        private void ThôngTinNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn chưa đăng nhập tài khoản");
        }

        private void PhânCấpChứcNăngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn chưa đăng nhập tài khoản");
        }

        private void TìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn chưa đăng nhập tài khoản");
        }
    }
}
