
namespace QLBH2._0
{
    partial class Ykienphanhoi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ykienphanhoi));
            this.txtnguoiphanhoi = new System.Windows.Forms.TextBox();
            this.txtnoidung = new System.Windows.Forms.TextBox();
            this.btnxacnhan = new System.Windows.Forms.Button();
            this.txtchude = new System.Windows.Forms.TextBox();
            this.btnhuy = new System.Windows.Forms.Button();
            this.dgvphanhoi = new System.Windows.Forms.DataGridView();
            this.btnviet = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvphanhoi)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnguoiphanhoi
            // 
            this.txtnguoiphanhoi.BackColor = System.Drawing.Color.White;
            this.txtnguoiphanhoi.Enabled = false;
            this.txtnguoiphanhoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnguoiphanhoi.ForeColor = System.Drawing.Color.Black;
            this.txtnguoiphanhoi.Location = new System.Drawing.Point(381, 161);
            this.txtnguoiphanhoi.Name = "txtnguoiphanhoi";
            this.txtnguoiphanhoi.Size = new System.Drawing.Size(444, 27);
            this.txtnguoiphanhoi.TabIndex = 1;
            // 
            // txtnoidung
            // 
            this.txtnoidung.BackColor = System.Drawing.Color.White;
            this.txtnoidung.Enabled = false;
            this.txtnoidung.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnoidung.ForeColor = System.Drawing.Color.Black;
            this.txtnoidung.Location = new System.Drawing.Point(381, 345);
            this.txtnoidung.Name = "txtnoidung";
            this.txtnoidung.Size = new System.Drawing.Size(506, 98);
            this.txtnoidung.TabIndex = 3;
            // 
            // btnxacnhan
            // 
            this.btnxacnhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnxacnhan.Enabled = false;
            this.btnxacnhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxacnhan.Location = new System.Drawing.Point(381, 503);
            this.btnxacnhan.Name = "btnxacnhan";
            this.btnxacnhan.Size = new System.Drawing.Size(96, 49);
            this.btnxacnhan.TabIndex = 4;
            this.btnxacnhan.Text = "Xác nhận";
            this.btnxacnhan.UseVisualStyleBackColor = false;
            this.btnxacnhan.Click += new System.EventHandler(this.Btnxacnhan_Click);
            // 
            // txtchude
            // 
            this.txtchude.BackColor = System.Drawing.Color.White;
            this.txtchude.Enabled = false;
            this.txtchude.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtchude.ForeColor = System.Drawing.Color.Black;
            this.txtchude.Location = new System.Drawing.Point(381, 257);
            this.txtchude.Name = "txtchude";
            this.txtchude.Size = new System.Drawing.Size(444, 27);
            this.txtchude.TabIndex = 2;
            this.txtchude.TextChanged += new System.EventHandler(this.TextBox4_TextChanged);
            // 
            // btnhuy
            // 
            this.btnhuy.BackColor = System.Drawing.Color.Red;
            this.btnhuy.Enabled = false;
            this.btnhuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhuy.Location = new System.Drawing.Point(683, 503);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(100, 49);
            this.btnhuy.TabIndex = 5;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.UseVisualStyleBackColor = false;
            this.btnhuy.Click += new System.EventHandler(this.Btnhuy_Click);
            // 
            // dgvphanhoi
            // 
            this.dgvphanhoi.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvphanhoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvphanhoi.GridColor = System.Drawing.SystemColors.Control;
            this.dgvphanhoi.Location = new System.Drawing.Point(579, 522);
            this.dgvphanhoi.Name = "dgvphanhoi";
            this.dgvphanhoi.RowHeadersWidth = 51;
            this.dgvphanhoi.RowTemplate.Height = 24;
            this.dgvphanhoi.Size = new System.Drawing.Size(15, 10);
            this.dgvphanhoi.TabIndex = 3;
            // 
            // btnviet
            // 
            this.btnviet.BackColor = System.Drawing.Color.Cyan;
            this.btnviet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnviet.Location = new System.Drawing.Point(463, 75);
            this.btnviet.Name = "btnviet";
            this.btnviet.Size = new System.Drawing.Size(131, 37);
            this.btnviet.TabIndex = 0;
            this.btnviet.Text = "Viết phản hồi";
            this.btnviet.UseVisualStyleBackColor = false;
            this.btnviet.Click += new System.EventHandler(this.Btnviet_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(908, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 44);
            this.button1.TabIndex = 5;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Ykienphanhoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1057, 583);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnviet);
            this.Controls.Add(this.dgvphanhoi);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btnxacnhan);
            this.Controls.Add(this.txtchude);
            this.Controls.Add(this.txtnoidung);
            this.Controls.Add(this.txtnguoiphanhoi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ykienphanhoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phản hồi";
            this.TransparencyKey = System.Drawing.Color.WhiteSmoke;
            this.Load += new System.EventHandler(this.Ykienphanhoi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvphanhoi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnguoiphanhoi;
        private System.Windows.Forms.TextBox txtnoidung;
        private System.Windows.Forms.Button btnxacnhan;
        private System.Windows.Forms.TextBox txtchude;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.DataGridView dgvphanhoi;
        private System.Windows.Forms.Button btnviet;
        private System.Windows.Forms.Button button1;
    }
}