namespace QuanLyDiem
{
    partial class cau2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GridViewLop1 = new System.Windows.Forms.DataGridView();
            this.clmMaKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTenLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmKhoaHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSiSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewLop1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã khoa";
            // 
            // GridViewLop1
            // 
            this.GridViewLop1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewLop1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmMaKhoa,
            this.clmMaLop,
            this.clmTenLop,
            this.clmKhoaHoc,
            this.clmSiSo});
            this.GridViewLop1.Location = new System.Drawing.Point(23, 188);
            this.GridViewLop1.Name = "GridViewLop1";
            this.GridViewLop1.RowHeadersWidth = 62;
            this.GridViewLop1.RowTemplate.Height = 28;
            this.GridViewLop1.Size = new System.Drawing.Size(765, 170);
            this.GridViewLop1.TabIndex = 2;
            // 
            // clmMaKhoa
            // 
            this.clmMaKhoa.DataPropertyName = "MaKhoa";
            this.clmMaKhoa.HeaderText = "Mã Khoa";
            this.clmMaKhoa.MinimumWidth = 8;
            this.clmMaKhoa.Name = "clmMaKhoa";
            this.clmMaKhoa.Width = 150;
            // 
            // clmMaLop
            // 
            this.clmMaLop.DataPropertyName = "MaLop";
            this.clmMaLop.HeaderText = "Mã Lớp";
            this.clmMaLop.MinimumWidth = 8;
            this.clmMaLop.Name = "clmMaLop";
            this.clmMaLop.Width = 150;
            // 
            // clmTenLop
            // 
            this.clmTenLop.DataPropertyName = "TenLop";
            this.clmTenLop.HeaderText = "Tên Lớp";
            this.clmTenLop.MinimumWidth = 8;
            this.clmTenLop.Name = "clmTenLop";
            this.clmTenLop.Width = 150;
            // 
            // clmKhoaHoc
            // 
            this.clmKhoaHoc.DataPropertyName = "KhoaHoc";
            this.clmKhoaHoc.HeaderText = "Khóa Học";
            this.clmKhoaHoc.MinimumWidth = 8;
            this.clmKhoaHoc.Name = "clmKhoaHoc";
            this.clmKhoaHoc.Width = 150;
            // 
            // clmSiSo
            // 
            this.clmSiSo.DataPropertyName = "SiSo";
            this.clmSiSo.HeaderText = "Sĩ Số";
            this.clmSiSo.MinimumWidth = 8;
            this.clmSiSo.Name = "clmSiSo";
            this.clmSiSo.Width = 150;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(189, 113);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(251, 28);
            this.comboBox1.TabIndex = 3;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(189, 38);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(251, 28);
            this.comboBox2.TabIndex = 4;
            // 
            // cau2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.GridViewLop1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "cau2";
            this.Text = "cau2";
            ((System.ComponentModel.ISupportInitialize)(this.GridViewLop1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView GridViewLop1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMaKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTenLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmKhoaHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSiSo;
    }
}