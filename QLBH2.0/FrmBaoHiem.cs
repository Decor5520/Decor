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

namespace QLBH2._0
{
    public partial class FrmBaoHiem : Form
    {
        private int flag = 0;
       
        BaoHiemCtrl nvCtrl = new BaoHiemCtrl();
      
       

        public FrmBaoHiem()
        {
            InitializeComponent();
        }

        private void TabPage2_Click(object sender, EventArgs e)
        {

        }

        private void Label13_Click(object sender, EventArgs e)
        {

        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Txtnoicap_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txtghichu_TextChanged(object sender, EventArgs e)
        {

        }
        void dis_en(bool e)
        {
       
         
            txtmaluong.Enabled = e;
            txtbaohiem.Enabled = e;
            txtghichu.Enabled = e;
            txtnoicap.Enabled = e;
            txtnhanvien.Enabled = e;
            dtngaycap.Enabled = e;
            txttennv.Enabled = e;
            btnhuy.Enabled = e;
            btnluu.Enabled = e;
            btnthem.Enabled = !e;
            btnsua.Enabled = !e;
            btnxoa.Enabled = !e;
            txtcmt.Enabled = e;
       


           
        }


            private void FrmBaoHiem_Load(object sender, EventArgs e)
        {
            
            DataTable dtD = new DataTable();
            dtD = nvCtrl.GetData();
           
            dgvDanhSachdl.DataSource = dtD;
           
            
            binhding();
            dis_en(false);
        }
      
        private void binhding()
        {
            txttennv.DataBindings.Clear();
            txttennv.DataBindings.Add("Text", dgvDanhSachdl.DataSource, "TenNhanVien");
            txtbaohiem.DataBindings.Clear();
            txtbaohiem.DataBindings.Add("Text", dgvDanhSachdl.DataSource, "MaBH");
            dtngaycap.DataBindings.Clear();
            dtngaycap.DataBindings.Add("Text", dgvDanhSachdl.DataSource, "NgayCap");
            txtnoicap.DataBindings.Clear();
            txtnoicap.DataBindings.Add("Text", dgvDanhSachdl.DataSource, "NoiCap");
            txtmaluong.DataBindings.Clear();
            txtmaluong.DataBindings.Add("Text", dgvDanhSachdl.DataSource, "MaLuong");
            txtnhanvien.DataBindings.Clear();
            txtnhanvien.DataBindings.Add("Text", dgvDanhSachdl.DataSource, "MaNV");
            txtghichu.DataBindings.Clear();
            txtghichu.DataBindings.Add("Text", dgvDanhSachdl.DataSource, "GhiChu");
            txtcmt.DataBindings.Add("Text", dgvDanhSachdl.DataSource, "CMT");
            txtcmt.DataBindings.Clear();
            

        }
        void ganData(BaoHiemObj bhObj)
            {
                bhObj.MaBH = txtbaohiem.Text.Trim();
                bhObj.MaLuong = txtmaluong.Text.Trim();
                bhObj.TenNhanVien = txttennv.Text.Trim();
                bhObj.NgayCap = dtngaycap.Text.Trim();
                bhObj.NoiCap = txtnoicap.Text.Trim();
                bhObj.MaNV= txtnhanvien.Text.Trim();  
                bhObj.GhiChu = txtghichu.Text.Trim();
                bhObj.SoCMT = txtcmt.Text.Trim();


            }
       
        void loadcontrol()
        {
          
            dtngaycap.Text = DateTime.Now.Date.ToShortDateString();
        }
      
        void clearData()
        {
            txtnhanvien.Text = "";
            txtbaohiem.Text = "";
            txtghichu.Text = "";
            txtnoicap.Text = "";
            dtngaycap.Value = DateTime.Now.Date;
            txtghichu.Text = "";
            txtmaluong.Text = "";
            txttennv.Text = "";
            txtcmt.Text = "";

                 
        

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa nhân viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (nvCtrl.DelData(txtnhanvien.Text.Trim()))
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xóa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            FrmBaoHiem_Load(sender, e);
        }

        private void Btnthem_Click(object sender, EventArgs e)
        {
           
            flag = 0;
            clearData();
            dis_en(true);
            loadcontrol();

        }

        private void Btnsua_Click(object sender, EventArgs e)
        {


            flag = 1;
            dis_en(true);
            loadcontrol();


        }

        private void Btnluu_Click(object sender, EventArgs e)
        {

            {
                BaoHiemObj bhh = new BaoHiemObj();
                ganData(bhh);
                if (flag == 0)
                {
                    if (nvCtrl.AddData(bhh))
                        MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Thêm không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (nvCtrl.UpdData(bhh))
                        MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Sửa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                FrmBaoHiem_Load(sender, e);
                dis_en(false);
            }
           

        }

        private void Btnhuy_Click(object sender, EventArgs e)
        {
            FrmBaoHiem_Load(sender, e);
            dis_en(false);
        }

        private void Btnsua1_Click(object sender, EventArgs e)
        {
          

        }

        private void Btnthem1_Click(object sender, EventArgs e)
        {

        }

        private void Btnluu1_Click(object sender, EventArgs e)
        {
            
          
            

        }

        private void Btnxoa1_Click(object sender, EventArgs e)
        {
            
        }

        private void Btnhuy1_Click(object sender, EventArgs e)
        {

           
        }

        private void GroupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
