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
    public partial class FrmPhongBan : Form
    {
        private int flag = 0;
        PhongBanCtrl nvCtr = new PhongBanCtrl();

        public FrmPhongBan()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmPhongBan_Load(object sender, EventArgs e)
        {
            DataTable dtDs = new DataTable();
            dtDs = nvCtr.GetData();
            dgvPhongBan.DataSource = dtDs;
            bingding();
            dis_en(false);
        }
        void dis_en(bool e)
        {
            txtChamCong.Enabled = e;
            txtChucVu.Enabled = e;
            txtEmail.Enabled = e;
            txtGhiChu.Enabled = e;
            txtLuongNhanDuoc.Enabled = e;
            txtMaBoPhan.Enabled = e;
            btnHuy.Enabled = e;
            btnLuu.Enabled = e;
            txtMaLuong.Enabled = e;
            txtMaNV.Enabled = e;
            txtMucLuong.Enabled = e;
            btnThem.Enabled = !e;
            btnSua.Enabled = !e;
            btnXoa.Enabled = !e;
            txtTenBP.Enabled = e;
            txtTenNV.Enabled = e;
            txtTongKetThang.Enabled = e;



        }
        void ganData(PhogBanObj nvObj)
        {
            nvObj.Chamcong = txtChamCong.Text.Trim();
            nvObj.Email = txtEmail.Text.Trim();
            nvObj.ChucVu = txtChucVu.Text.Trim();
            nvObj.GhiChu = txtGhiChu.Text.Trim();
            nvObj.MaLuong = txtMaLuong.Text.Trim();
            nvObj.MaNV = txtMaNV.Text.Trim();
            nvObj.MaPB = txtMaBoPhan.Text.Trim();
            nvObj.MucLuong = txtMucLuong.Text.Trim();
            nvObj.TenNV = txtTenNV.Text.Trim();
            nvObj.ThangTongKet = txtTongKetThang.Text.Trim();
            nvObj.TienLuongNhanDuoc = txtLuongNhanDuoc.Text.Trim();
            nvObj.TenPB = txtTenBP.Text.Trim();
          


        }
        void loadcontrol()
        {
          
        }
        void clearData()
        {
            txtTongKetThang.Text = "";
            txtTenNV.Text = "";
            txtTenBP.Text = "";
            txtMucLuong.Text = "";
            txtMaNV.Text = "";
            txtMaLuong.Text = "";
            txtMaBoPhan.Text = "";
            txtLuongNhanDuoc.Text = "";
            txtGhiChu.Text = "";
            txtEmail.Text = "";
            txtChucVu.Text = "";
            txtChamCong.Text = "";
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
                if (nvCtr.DelData(txtMaBoPhan.Text.Trim()))
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xóa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            FrmPhongBan_Load(sender, e);
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            PhogBanObj nvObj = new PhogBanObj();
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
            FrmPhongBan_Load(sender, e);
            dis_en(false);

        }

        private void BtnHuy_Click(object sender, EventArgs e)
        {

            FrmPhongBan_Load(sender, e);
            dis_en(false);
        }
        private void bingding()
        {
            txtTenBP.DataBindings.Clear();
            txtTenBP.DataBindings.Add("Text", dgvPhongBan.DataSource, "TenPB");
            txtTenNV.DataBindings.Clear();
            txtTenNV.DataBindings.Add("Text", dgvPhongBan.DataSource, "TenNV");
            txtTongKetThang.DataBindings.Clear();
            txtTongKetThang.DataBindings.Add("Text", dgvPhongBan.DataSource, "ThangTongKet");
            txtMucLuong.DataBindings.Clear();
            txtMucLuong.DataBindings.Add("Text", dgvPhongBan.DataSource, "MucLuong");
            txtMaNV.DataBindings.Clear();
            txtMaNV.DataBindings.Add("Text", dgvPhongBan.DataSource, "MaNV");
            txtMaLuong.DataBindings.Clear();
            txtMaLuong.DataBindings.Add("Text", dgvPhongBan.DataSource, "MaLuong");
            txtMaBoPhan.DataBindings.Clear();
            txtMaBoPhan.DataBindings.Add("Text", dgvPhongBan.DataSource, "MaPB");
            txtLuongNhanDuoc.DataBindings.Clear();
            txtGhiChu.DataBindings.Clear();
            txtLuongNhanDuoc.DataBindings.Add("Text", dgvPhongBan.DataSource, "TienLuongNhanDuoc");
            txtGhiChu.DataBindings.Add("Text", dgvPhongBan.DataSource, "GhiChu");
            txtEmail.DataBindings.Add("Text", dgvPhongBan.DataSource, "Email");
            txtEmail.DataBindings.Clear();
            txtChucVu.DataBindings.Add("Text", dgvPhongBan.DataSource, "ChucVu");
            txtChucVu.DataBindings.Clear();
            txtChamCong.DataBindings.Add("Text", dgvPhongBan.DataSource, "ChamCong");
            txtChamCong.DataBindings.Clear();

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
