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
    public partial class Ykienphanhoi : Form
    {
        

        PhanHoiCtrl nvCtrl = new PhanHoiCtrl();
        public Ykienphanhoi()
        {
            InitializeComponent();
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btnxacnhan_Click(object sender, EventArgs e)
        {

            {
                PhanHoiObj hh = new PhanHoiObj();
                ganData(hh);
               
                {
                    if (nvCtrl.AddData(hh))
                        MessageBox.Show("Cảm ơn đóng góp của bạn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Phản hồi thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                Ykienphanhoi_Load(sender, e);
                
            }


        }
        void dis_en(bool e)
        {


            txtchude.Enabled = e;
            txtnguoiphanhoi.Enabled = e;
            txtnoidung.Enabled = e;
            btnhuy.Enabled = e;
            btnviet.Enabled = !e;
            btnxacnhan.Enabled = e;
            btnhuy.Enabled = e;
            
            




        }
        void ganData(PhanHoiObj bhObj)
        {
            bhObj.Chude = txtchude.Text.Trim();
            bhObj.NguoiPhanHoi = txtnguoiphanhoi.Text.Trim();
            bhObj.NoiDung = txtnoidung.Text.Trim();
          


        }

        private void Ykienphanhoi_Load(object sender, EventArgs e)
        {
            DataTable dtD = new DataTable();
            dtD = nvCtrl.GetData();

            dgvphanhoi.DataSource = dtD;


        }

        private void Btnviet_Click(object sender, EventArgs e)
        {
            dis_en(true);
           
        }

        private void Btnhuy_Click(object sender, EventArgs e)
        {
            Ykienphanhoi_Load(sender, e);
            dis_en(false);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Đóng giao diện phản hồi?", "HTMC", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
