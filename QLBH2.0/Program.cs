using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using QLBH2._0.View;

namespace QLBH2._0.View
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FormDangNhap());
            //Application.Run(new FrmDoiMatKhau());
            //Application.Run(new Form1());
            //Application.Run(new FrmNhanVien());
            //Application.Run(new FrmBaoHiem());
            //Application.Run(new ThSan());
            //Application.Run(new FrmPhongBan());
            //Application.Run(new ThaiSan());
            //Application.Run(new Dự_án_quản_lí());
            //Application.Run(new Ykienphanhoi());
            Application.Run(new FormDau());
            //Application.Run(new Ykienphanhoi());
            //Application.Run(new FrmThemTaiKhoan());
            //Application.Run(new Themtaikhoan());
        }
    }
}
