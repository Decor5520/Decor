using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLBH2._0.Control;
using QLBH2._0.Object;
using System.Data.SqlClient;
using QLBH2._0.Model;



namespace QLBH2._0.View
{
    public partial class FrmNhanVien : Form
    {
        string TenDangNhap = "", TenNhanVien = "", MatKhau = "", Quyen = "";
        ConectToSQL con = new ConectToSQL();
        SqlCommand cmd = new SqlCommand();

        public  DataTable GetData(string sql)
        {
            DataTable dt = new DataTable();

            cmd.CommandText = "select * from   NhanVien";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return dt;
        }

        private int flag = 0;
          NhanVienCltr nvCtr = new NhanVienCltr();
       
        public FrmNhanVien()
        {
            InitializeComponent();
        }

        public FrmNhanVien(string TenDangNhap, string TenNhanVien, string MatKhau, string Quyen)
        {
            InitializeComponent();
            this.TenDangNhap = TenDangNhap;
            this.TenNhanVien = TenNhanVien;
            this.MatKhau = MatKhau;
            this.Quyen = Quyen;
        }

        public void Button3_Click(object sender, EventArgs e)
        {
            
                DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa nhân viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    if (nvCtr.DelData(txtma.Text.Trim()))
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Xóa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                FrmNhanVien_Load(sender, e);
            
        }

        public void Button2_Click(object sender, EventArgs e)
        {
            
            

                flag = 1;
                dis_en(true);
                loadcontrol();
           
            
            
            

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void DgvDanhSachNv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void dis_en(bool e)
        { 
            txtten.Enabled = e;
            txtma.Enabled = e;
            txtdiachi.Enabled = e;
            txtSDT.Enabled = e;
            dtNamSinh.Enabled = e;
            cmbgioitinh.Enabled = e;
            btnHuy.Enabled = e;
            btnLuu.Enabled = e;
            txtghichu.Enabled = e;
            txtemail.Enabled = e;
            txttongiao.Enabled = e;
            btnThem.Enabled = !e;
            btnSua.Enabled = !e;
            btnXoa.Enabled = !e;
           

        }
        void ganData(NhanVienObj nvObj)
        {
            nvObj.DiaChi = txtdiachi.Text.Trim();
            nvObj.DienThoai = txtSDT.Text.Trim();
            nvObj.TenNhanVien = txtten.Text.Trim();
            nvObj.NamSinh = dtNamSinh.Text.Trim();
            nvObj.MaNhanVien = txtma.Text.Trim();
            nvObj.GioiTinh = cmbgioitinh.Text.Trim();
            nvObj.Tongiao = txttongiao.Text.Trim();
            nvObj.Email = txtemail.Text.Trim();
            nvObj.Ghichu = txtghichu.Text.Trim();
     

        }
        void loadcontrol()
        {
            cmbgioitinh.Items.Clear();
            cmbgioitinh.Items.Add("Nam");
            cmbgioitinh.Items.Add("Nữ");
            dtNamSinh.Text = DateTime.Now.Date.ToShortDateString();
        }
        void clearData()
        {
            txtma.Text = "";
            txtten.Text = "";
            txtdiachi.Text = "";
            txtSDT.Text = "";
            dtNamSinh.Value = DateTime.Now.Date;
            txtghichu.Text = "";
            txtemail.Text = "";
            txttongiao.Text = "";
            loadcontrol();

        }


        private void BtnThem_Click(object sender, EventArgs e)
        {
            loadcontrol();
            flag = 0;
            clearData();
            dis_en(true);


        }

        private void Txtma_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txtten_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Btndangxuat_Click(object sender, EventArgs e)
        {

            this.Close();
            
            
        }

        private void ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            NhanVienObj nvObj = new NhanVienObj();
            ganData(nvObj);
            if (flag == 0)
            {
                if (nvCtr.AddData(nvObj))
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Thêm không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (nvCtr.UpdData(nvObj))
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Sửa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            FrmNhanVien_Load(sender, e);
            dis_en(false);

        }

        private void BtnHuy_Click(object sender, EventArgs e)
        {
            FrmNhanVien_Load(sender, e);
            dis_en(false);
        }

        public void FrmNhanVien_Load(object sender, EventArgs e)
        {
          
            DataTable dtDs = new DataTable();
            dtDs = nvCtr.GetData();
            dgvDanhSachNv.DataSource = dtDs;
            bingding();
            dis_en(false);

        }
        private void bingding()
        {
           txtma.DataBindings.Clear();
            txtma.DataBindings.Add("Text", dgvDanhSachNv.DataSource, "MaNV");
            txtten.DataBindings.Clear();
            txtten.DataBindings.Add("Text", dgvDanhSachNv.DataSource, "TenNV");
            cmbgioitinh.DataBindings.Clear();
            cmbgioitinh.DataBindings.Add("Text", dgvDanhSachNv.DataSource, "GioiTinh");
            txtdiachi.DataBindings.Clear();
            txtdiachi.DataBindings.Add("Text", dgvDanhSachNv.DataSource, "DiaChi");
            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("Text", dgvDanhSachNv.DataSource, "SDT");
            dtNamSinh.DataBindings.Clear();
            dtNamSinh.DataBindings.Add("Text", dgvDanhSachNv.DataSource, "NamSinh");
            txtghichu.DataBindings.Clear();
            txtghichu.DataBindings.Add("Text", dgvDanhSachNv.DataSource, "Ghichu");
            txtemail.DataBindings.Clear();
            txttongiao.DataBindings.Clear();
            txtemail.DataBindings.Add("Text", dgvDanhSachNv.DataSource, "Email");
           txttongiao.DataBindings.Add("Text", dgvDanhSachNv.DataSource, "Tongiao");

       }

        private void FrmNhanVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Txt123_TextChanged(object sender, EventArgs e)
        {
           
        }
    
     

        private void Button1_Click(object sender, EventArgs e)
        {

            
        }
    }
}
