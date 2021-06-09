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
using System.Data.SqlClient;
using QLBH2._0.Model;
using QLBH2._0.Object;

namespace QLBH2._0
{
    public partial class Form1 : Form
    {

        string TenDangNhap = "", TenNhanVien = "", MatKhau = "", Quyen = "";
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(string TenDangNhap, string TenNhanVien, string MatKhau, string Quyen)
        {
            InitializeComponent();
            this.TenDangNhap = TenDangNhap;
            this.TenNhanVien = TenNhanVien;
            this.MatKhau = MatKhau;
            this.Quyen = Quyen;
        }
        private void ĐổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            FrmDoiMatKhau dmk = new FrmDoiMatKhau();
            dmk.ShowDialog();
            Form1_Load(sender, e);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ThêmTàiKhoảnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
            Themtaikhoan ftk = new Themtaikhoan();
            ftk.ShowDialog();
        }

        private void BảoHiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Quyen == "admin")
            {
                FrmBaoHiem fbh = new FrmBaoHiem();
               
                fbh.ShowDialog();
            }
            else if( Quyen == "employee")
            {
                FrmBaoHiem fbh = new FrmBaoHiem();

                fbh.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Bạn không có quyền xem");
            }    

        }

        private void ThaiSảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Quyen == "admin")
            {
                ThaiSan ts= new ThaiSan();

                ts.ShowDialog();
            }
            else if (Quyen == "employee")
            {
                ThaiSan ts = new ThaiSan();

                ts.ShowDialog();

            }
            else
            {
                MessageBox.Show("Bạn không có quyền xem");
            }
        }

        private void PhânCấpChứcNăngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void PhòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Quyen == "admin")
            {
                FrmPhongBan fn = new FrmPhongBan();
               
                fn.ShowDialog();
            }
             else
            {
                MessageBox.Show("Bạn không có quyền xem");
            }
        }

        private void ChếĐộBảoHiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void TìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DựÁnQuảnLíToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Quyen == "admin")
            {
                Dự_án_quản_lí  daql = new Dự_án_quản_lí();

                daql.ShowDialog();
            }
            else if (Quyen == "employee")
            {
                Dự_án_quản_lí daql = new Dự_án_quản_lí();

                daql.ShowDialog();

            }
            else
            {
                MessageBox.Show("Bạn không có quyền xem");
            }
        }

        private void GiớiThiệuCôngTiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gioithieucongti gt = new Gioithieucongti();
            gt.ShowDialog();
        }

        private void ChứcNăngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ykienphanhoi yk = new Ykienphanhoi();
            yk.ShowDialog();
        }

        private void ThôngTinNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lienhe lh = new Lienhe();
            lh.ShowDialog();
        }

        private void DựÁnQuảnLíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DuanNoibat danb = new DuanNoibat();
            danb.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
     
        private void QuảnLíNhânSựToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ( Quyen == "admin")
            {
                FrmNhanVien fnv = new FrmNhanVien();
               
                fnv.ShowDialog();
            }
           else if ( Quyen == "employee")
            {
                FrmNhanVien fnv = new FrmNhanVien();

                fnv.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Bạn không có quyền xem");
            }    
        }

        private void ThêmTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
             DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn đăng xuất?", "Xác nhận ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Hide();
                FormDangNhap ft = new FormDangNhap();
                ft.ShowDialog();

           
            }
        }
    }
}
