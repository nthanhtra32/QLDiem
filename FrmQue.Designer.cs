namespace QuanLyDiem
{
    partial class FrmQue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQue));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenQue = new System.Windows.Forms.TextBox();
            this.GridViewQue = new System.Windows.Forms.DataGridView();
            this.clmMaQue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTenQue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtMaQue = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewQue)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(288, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách quê";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã quê";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên quê";
            // 
            // txtTenQue
            // 
            this.txtTenQue.Location = new System.Drawing.Point(182, 176);
            this.txtTenQue.Name = "txtTenQue";
            this.txtTenQue.Size = new System.Drawing.Size(288, 26);
            this.txtTenQue.TabIndex = 4;
            // 
            // GridViewQue
            // 
            this.GridViewQue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewQue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmMaQue,
            this.clmTenQue});
            this.GridViewQue.Location = new System.Drawing.Point(71, 226);
            this.GridViewQue.Name = "GridViewQue";
            this.GridViewQue.RowHeadersWidth = 62;
            this.GridViewQue.RowTemplate.Height = 28;
            this.GridViewQue.Size = new System.Drawing.Size(635, 162);
            this.GridViewQue.TabIndex = 5;
            this.GridViewQue.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewQue_CellClick);
            // 
            // clmMaQue
            // 
            this.clmMaQue.DataPropertyName = "MaQue";
            this.clmMaQue.HeaderText = "Mã quê";
            this.clmMaQue.MinimumWidth = 8;
            this.clmMaQue.Name = "clmMaQue";
            this.clmMaQue.Width = 150;
            // 
            // clmTenQue
            // 
            this.clmTenQue.DataPropertyName = "TenQue";
            this.clmTenQue.HeaderText = "Tên quê";
            this.clmTenQue.MinimumWidth = 8;
            this.clmTenQue.Name = "clmTenQue";
            this.clmTenQue.Width = 150;
            // 
            // btnThoat
            // 
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(667, 419);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(96, 46);
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
            this.btnHuy.Location = new System.Drawing.Point(541, 419);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(93, 46);
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
            this.btnLuu.Location = new System.Drawing.Point(417, 419);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(93, 46);
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
            this.btnXoa.Location = new System.Drawing.Point(293, 419);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 46);
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
            this.btnSua.Location = new System.Drawing.Point(170, 419);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(94, 46);
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
            this.btnThem.Location = new System.Drawing.Point(47, 419);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(96, 46);
            this.btnThem.TabIndex = 67;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtMaQue
            // 
            this.txtMaQue.Location = new System.Drawing.Point(182, 107);
            this.txtMaQue.Name = "txtMaQue";
            this.txtMaQue.Size = new System.Drawing.Size(288, 26);
            this.txtMaQue.TabIndex = 68;
            // 
            // FrmQue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 477);
            this.Controls.Add(this.txtMaQue);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.GridViewQue);
            this.Controls.Add(this.txtTenQue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmQue";
            this.Text = "FrmQue";
            this.Load += new System.EventHandler(this.FrmQue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewQue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenQue;
        private System.Windows.Forms.DataGridView GridViewQue;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMaQue;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTenQue;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtMaQue;
    }
}