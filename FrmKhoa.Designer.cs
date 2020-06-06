namespace QuanLyDiem
{
    partial class FrmKhoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKhoa));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTenKhoa = new System.Windows.Forms.TextBox();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtWebsite = new System.Windows.Forms.TextBox();
            this.GridViewKhoa = new System.Windows.Forms.DataGridView();
            this.clmMaKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTenKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmWebsite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaKhoa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewKhoa)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(281, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách Khoa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên khoa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Điện thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(397, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Địa chỉ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(397, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Website";
            // 
            // txtTenKhoa
            // 
            this.txtTenKhoa.Location = new System.Drawing.Point(170, 123);
            this.txtTenKhoa.Name = "txtTenKhoa";
            this.txtTenKhoa.Size = new System.Drawing.Size(153, 26);
            this.txtTenKhoa.TabIndex = 7;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(170, 172);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(153, 26);
            this.txtDienThoai.TabIndex = 8;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(499, 82);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(166, 26);
            this.txtDiaChi.TabIndex = 9;
            // 
            // txtWebsite
            // 
            this.txtWebsite.Location = new System.Drawing.Point(499, 138);
            this.txtWebsite.Name = "txtWebsite";
            this.txtWebsite.Size = new System.Drawing.Size(166, 26);
            this.txtWebsite.TabIndex = 10;
            // 
            // GridViewKhoa
            // 
            this.GridViewKhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewKhoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmMaKhoa,
            this.clmTenKhoa,
            this.clmDienThoai,
            this.clmDiaChi,
            this.clmWebsite});
            this.GridViewKhoa.Location = new System.Drawing.Point(31, 218);
            this.GridViewKhoa.Name = "GridViewKhoa";
            this.GridViewKhoa.RowHeadersWidth = 62;
            this.GridViewKhoa.RowTemplate.Height = 28;
            this.GridViewKhoa.Size = new System.Drawing.Size(726, 161);
            this.GridViewKhoa.TabIndex = 11;
            this.GridViewKhoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewKhoa_CellClick_1);
            // 
            // clmMaKhoa
            // 
            this.clmMaKhoa.DataPropertyName = "MaKhoa";
            this.clmMaKhoa.HeaderText = "Mã khoa";
            this.clmMaKhoa.MinimumWidth = 8;
            this.clmMaKhoa.Name = "clmMaKhoa";
            this.clmMaKhoa.Width = 150;
            // 
            // clmTenKhoa
            // 
            this.clmTenKhoa.DataPropertyName = "TenKhoa";
            this.clmTenKhoa.HeaderText = "Tên khoa";
            this.clmTenKhoa.MinimumWidth = 8;
            this.clmTenKhoa.Name = "clmTenKhoa";
            this.clmTenKhoa.Width = 150;
            // 
            // clmDienThoai
            // 
            this.clmDienThoai.DataPropertyName = "DienThoai";
            this.clmDienThoai.HeaderText = "Điện thoại";
            this.clmDienThoai.MinimumWidth = 8;
            this.clmDienThoai.Name = "clmDienThoai";
            this.clmDienThoai.Width = 150;
            // 
            // clmDiaChi
            // 
            this.clmDiaChi.DataPropertyName = "DiaChi";
            this.clmDiaChi.HeaderText = "Địa chỉ";
            this.clmDiaChi.MinimumWidth = 8;
            this.clmDiaChi.Name = "clmDiaChi";
            this.clmDiaChi.Width = 150;
            // 
            // clmWebsite
            // 
            this.clmWebsite.DataPropertyName = "Website";
            this.clmWebsite.HeaderText = "Website";
            this.clmWebsite.MinimumWidth = 8;
            this.clmWebsite.Name = "clmWebsite";
            this.clmWebsite.Width = 150;
            // 
            // btnThoat
            // 
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(651, 428);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(96, 45);
            this.btnThoat.TabIndex = 62;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(525, 428);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(93, 45);
            this.btnHuy.TabIndex = 63;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(401, 428);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(93, 45);
            this.btnLuu.TabIndex = 64;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(277, 428);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 45);
            this.btnXoa.TabIndex = 65;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(154, 428);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(94, 45);
            this.btnSua.TabIndex = 66;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(31, 428);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(96, 45);
            this.btnThem.TabIndex = 67;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã khoa";
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.Location = new System.Drawing.Point(170, 84);
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Size = new System.Drawing.Size(153, 26);
            this.txtMaKhoa.TabIndex = 68;
            // 
            // FrmKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 494);
            this.Controls.Add(this.txtMaKhoa);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.GridViewKhoa);
            this.Controls.Add(this.txtWebsite);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtDienThoai);
            this.Controls.Add(this.txtTenKhoa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmKhoa";
            this.Text = "FrmKhoa";
            this.Load += new System.EventHandler(this.FrmKhoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewKhoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTenKhoa;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtWebsite;
        private System.Windows.Forms.DataGridView GridViewKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMaKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTenKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmWebsite;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaKhoa;
    }
}