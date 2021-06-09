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



namespace QLBH2._0
{
    public partial class Dự_án_quản_lí : Form
    {
        private int flag = 0;
        DuanCtrl nvCtrl = new DuanCtrl();
        public Dự_án_quản_lí()
        {
            InitializeComponent();
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }
        void dis_en(bool e)
        {
            txtbophan.Enabled = e;
            dtngaybatdau.Enabled = e;
            dtdukien.Enabled = e;
            txtSDT.Enabled = e;
            txttenduan.Enabled = e;
            txttiendo.Enabled = e;
            btnhuy.Enabled = e;
            btnluu.Enabled = e;
            txttruongban.Enabled = e;
           
            btnthem.Enabled = !e;
            btnsua.Enabled = !e;
            btnxoa.Enabled = !e;


        }
        void ganData(DuanObj nvObj)
        {
            nvObj.BoPhanDamNhiem = txtbophan.Text.Trim();
            nvObj.DuKienHoanhThanh = dtdukien.Text.Trim();
            nvObj.NgayBatDau = dtngaybatdau.Text.Trim();
            nvObj.SDT = txtSDT.Text.Trim();
            nvObj.TenDuAn = txttenduan.Text.Trim();
            nvObj.TienDo = txttiendo.Text.Trim();
            nvObj.TruongBan = txttruongban.Text.Trim();
           


        }
        void loadcontrol()
        {
            dtngaybatdau.Text = DateTime.Now.Date.ToShortDateString();

            dtdukien.Text = DateTime.Now.Date.ToShortDateString();
        }
        void clearData()
        {
            txtbophan.Text = "";
            txtSDT.Text = "";
            txttenduan.Text = "";
            txttiendo.Text = "";
            dtdukien.Value = DateTime.Now.Date;
            txttruongban.Text = "";
            dtngaybatdau.Value = DateTime.Now.Date;
            loadcontrol();

        }

        private void Btnthem_Click(object sender, EventArgs e)
        {
            loadcontrol();
            flag = 0;
            clearData();
            dis_en(true);

        }

        private void Btnsua_Click(object sender, EventArgs e)
        {

            flag = 1;
            dis_en(true);
            loadcontrol();

        }

        private void Btnxoa_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa dự án này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (nvCtrl.DelData(txttenduan.Text.Trim()))
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xóa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Dự_án_quản_lí_Load(sender, e);

        }

        private void Btnluu_Click(object sender, EventArgs e)
        {
            DuanObj nvObj = new DuanObj();
            ganData(nvObj);
            if (flag == 0)
            {
                if (nvCtrl.AddData(nvObj))
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Thêm không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (nvCtrl.UpdData(nvObj))
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Sửa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Dự_án_quản_lí_Load(sender, e);
            dis_en(false);
        }

        private void Btnhuy_Click(object sender, EventArgs e)
        {

            Dự_án_quản_lí_Load(sender, e);
            dis_en(false);
        }

        private void Dự_án_quản_lí_Load(object sender, EventArgs e)
        {
            DataTable dtDs = new DataTable();
            dtDs = nvCtrl.GetData();
            dgvDanhSachDuan.DataSource = dtDs;
            bingding();
            dis_en(false);

        }
        private void bingding()
        {
            txtbophan.DataBindings.Clear();
            txtbophan.DataBindings.Add("Text", dgvDanhSachDuan.DataSource, "BoPhanDamNhiem");
            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("Text", dgvDanhSachDuan.DataSource, "SDT");
            txttenduan.DataBindings.Clear();
            txttenduan.DataBindings.Add("Text", dgvDanhSachDuan.DataSource, "TenDuAn");
            txttiendo.DataBindings.Clear();
            txttiendo.DataBindings.Add("Text", dgvDanhSachDuan.DataSource, "TienDo");
            txttruongban.DataBindings.Clear();
            txttruongban.DataBindings.Add("Text", dgvDanhSachDuan.DataSource, "TruongBan");
            dtdukien.DataBindings.Clear();
            dtdukien.DataBindings.Add("Text", dgvDanhSachDuan.DataSource, "DuKienHoanThanh");
            dtngaybatdau.DataBindings.Clear();
            dtngaybatdau.DataBindings.Add("Text", dgvDanhSachDuan.DataSource, "NgayBatDau");
          

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
