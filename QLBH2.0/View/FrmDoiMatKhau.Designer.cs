
namespace QLBH2._0
{
    partial class FrmDoiMatKhau
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoiMatKhau));
            this.txttendangnhap = new System.Windows.Forms.TextBox();
            this.txtmatkhaucu = new System.Windows.Forms.TextBox();
            this.txtmatkhaumoi = new System.Windows.Forms.TextBox();
            this.txtxacnhan = new System.Windows.Forms.TextBox();
            this.lable1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnhoantat = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txttendangnhap
            // 
            this.txttendangnhap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txttendangnhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttendangnhap.Location = new System.Drawing.Point(253, 144);
            this.txttendangnhap.Name = "txttendangnhap";
            this.txttendangnhap.Size = new System.Drawing.Size(303, 30);
            this.txttendangnhap.TabIndex = 0;
            this.txttendangnhap.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // txtmatkhaucu
            // 
            this.txtmatkhaucu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtmatkhaucu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmatkhaucu.Location = new System.Drawing.Point(253, 197);
            this.txtmatkhaucu.Name = "txtmatkhaucu";
            this.txtmatkhaucu.Size = new System.Drawing.Size(303, 30);
            this.txtmatkhaucu.TabIndex = 1;
            this.txtmatkhaucu.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // txtmatkhaumoi
            // 
            this.txtmatkhaumoi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtmatkhaumoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmatkhaumoi.Location = new System.Drawing.Point(253, 251);
            this.txtmatkhaumoi.Name = "txtmatkhaumoi";
            this.txtmatkhaumoi.Size = new System.Drawing.Size(303, 30);
            this.txtmatkhaumoi.TabIndex = 2;
            this.txtmatkhaumoi.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // txtxacnhan
            // 
            this.txtxacnhan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtxacnhan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtxacnhan.Location = new System.Drawing.Point(253, 305);
            this.txtxacnhan.Name = "txtxacnhan";
            this.txtxacnhan.Size = new System.Drawing.Size(303, 30);
            this.txtxacnhan.TabIndex = 3;
            this.txtxacnhan.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // lable1
            // 
            this.lable1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lable1.AutoSize = true;
            this.lable1.BackColor = System.Drawing.Color.Transparent;
            this.lable1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable1.ForeColor = System.Drawing.Color.Black;
            this.lable1.Location = new System.Drawing.Point(66, 144);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(114, 19);
            this.lable1.TabIndex = 1;
            this.lable1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(78, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu cũ";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(66, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mật khẩu mới";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(36, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Xác nhận mật khẩu mới";
            // 
            // btnexit
            // 
            this.btnexit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnexit.BackColor = System.Drawing.Color.Red;
            this.btnexit.Location = new System.Drawing.Point(481, 376);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 40);
            this.btnexit.TabIndex = 5;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.Btnexit_Click);
            // 
            // btnhoantat
            // 
            this.btnhoantat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnhoantat.BackColor = System.Drawing.Color.Lime;
            this.btnhoantat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhoantat.Location = new System.Drawing.Point(253, 376);
            this.btnhoantat.Name = "btnhoantat";
            this.btnhoantat.Size = new System.Drawing.Size(75, 40);
            this.btnhoantat.TabIndex = 4;
            this.btnhoantat.Text = "Hoàn tất";
            this.btnhoantat.UseVisualStyleBackColor = false;
            this.btnhoantat.Click += new System.EventHandler(this.Button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(726, 461);
            this.Controls.Add(this.txttendangnhap);
            this.Controls.Add(this.btnhoantat);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtmatkhaucu);
            this.Controls.Add(this.lable1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtxacnhan);
            this.Controls.Add(this.txtmatkhaumoi);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDoiMatKhau";
            this.TransparencyKey = System.Drawing.Color.WhiteSmoke;
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txttendangnhap;
        private System.Windows.Forms.TextBox txtmatkhaucu;
        private System.Windows.Forms.TextBox txtmatkhaumoi;
        private System.Windows.Forms.TextBox txtxacnhan;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnhoantat;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}