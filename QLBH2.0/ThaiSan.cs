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
    public partial class ThaiSan : Form
    {
        private int flag = 0;
        ThaiSanCtrl nvCtr = new ThaiSanCtrl();
        public ThaiSan()
        {
            InitializeComponent();
        }

        private void ThaiSan_Load(object sender, EventArgs e)
        {
            DataTable dtDs = new DataTable();
            dtDs = nvCtr.GetData();
            dgvThaiSan.DataSource = dtDs;
            bingding();
            dis_en(false);
        }
        void dis_en(bool e)
        {
            txtGhiChu.Enabled = e;
            txtHoTen.Enabled = e;
            txtMaBP.Enabled = e;
            txtMaNV.Enabled = e;
            dtNgayBack.Enabled = e;
            dtngaybd.Enabled = e;
            btnHuy.Enabled = e;
            btnLuu.Enabled = e;
            dtngaysinh.Enabled = e;
            
            txtMaPhong.Enabled = e;
            btnThem.Enabled = !e;
            btnSua.Enabled = !e;
            btnXoa.Enabled = !e;
            txtTroCap.Enabled = e;
            


        }
        void ganData(ThaiSanObj nvObj)
        {
            nvObj.Hoten = txtHoTen.Text.Trim();
            nvObj.GhiChu = txtGhiChu.Text.Trim();
            nvObj.MaBoPhan = txtMaBP.Text.Trim();
            nvObj.MaNV = txtMaNV.Text.Trim();
            nvObj.MaPhong = txtMaPhong.Text.Trim();
            nvObj.TroCap = txtTroCap.Text.Trim();
            nvObj.NgaySinh = dtngaysinh.Text.Trim();
            nvObj.NgayBatDauNghi = dtngaybd.Text.Trim();
            nvObj.NgayQuayLai = dtNgayBack.Text.Trim();


        }
        void loadcontrol()
        {
            dtngaysinh.Text = DateTime.Now.Date.ToShortDateString();
            dtngaybd.Text = DateTime.Now.Date.ToShortDateString();
            dtNgayBack.Text = DateTime.Now.Date.ToShortDateString();
        }
        void clearData()
        {
            txtGhiChu.Text = "";
            txtHoTen.Text = "";
            txtMaBP.Text = "";
            txtMaNV.Text = "";
            dtNgayBack.Value = DateTime.Now.Date;
            dtngaybd.Text = "";
            dtngaysinh.Text = "";
            txtMaPhong.Text = "";
            txtTroCap.Text = "";
            loadcontrol();

        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            loadcontrol();
            flag = 0;
            clearData();
            dis_en(true);
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {

            flag = 1;
            dis_en(true);
            loadcontrol();

        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa nhân viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (nvCtr.DelData(txtMaNV.Text.Trim()))
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xóa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ThaiSan_Load(sender, e);
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {

            ThaiSanObj nvObj = new ThaiSanObj();
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
            ThaiSan_Load(sender, e);
            dis_en(false);

        }

        private void BtnHuy_Click(object sender, EventArgs e)
        {

            ThaiSan_Load(sender, e);
            dis_en(false);
        }
        private void bingding()
        {
            txtGhiChu.DataBindings.Clear();
            txtGhiChu.DataBindings.Add("Text", dgvThaiSan.DataSource, "GhiChu");
            txtHoTen.DataBindings.Clear();
            txtHoTen.DataBindings.Add("Text", dgvThaiSan.DataSource, "Hoten");
            txtMaBP.DataBindings.Clear();
            txtMaBP.DataBindings.Add("Text", dgvThaiSan.DataSource, "MaBoPhan");
            txtMaNV.DataBindings.Clear();
            txtMaNV.DataBindings.Add("Text", dgvThaiSan.DataSource, "MaNV");
            txtMaPhong.DataBindings.Clear();
            txtMaPhong.DataBindings.Add("Text", dgvThaiSan.DataSource, "MaPhong");
            txtTroCap.DataBindings.Clear();
            txtTroCap.DataBindings.Add("Text", dgvThaiSan.DataSource, "TroCap");
            dtngaysinh.DataBindings.Clear();
            dtngaysinh.DataBindings.Add("Text", dgvThaiSan.DataSource, "NgaySinh");
            dtngaybd.DataBindings.Clear();
            dtNgayBack.DataBindings.Clear();
            dtNgayBack.DataBindings.Add("Text", dgvThaiSan.DataSource, "NgayQuayLai");
            dtngaybd.DataBindings.Add("Text", dgvThaiSan.DataSource, "NgayBatDauNghi");

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
