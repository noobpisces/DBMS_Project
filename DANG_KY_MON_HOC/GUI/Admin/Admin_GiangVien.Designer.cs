namespace DANG_KY_MON_HOC.GUI.Admin
{
    partial class Admin_GiangVien
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
            this.txtMaGiangVien = new System.Windows.Forms.TextBox();
            this.Search_GiangVien = new System.Windows.Forms.Button();
            this.dgvGiangVien = new System.Windows.Forms.DataGridView();
            this.ThemTaiKhoan = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete_GiangVien = new System.Windows.Forms.Button();
            this.ReloadData = new System.Windows.Forms.Button();
            this.Capnhat_GiangVien = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiangVien)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1184, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ THÔNG TIN GIẢNG VIÊN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập mã giảng viên:";
            // 
            // txtMaGiangVien
            // 
            this.txtMaGiangVien.Location = new System.Drawing.Point(207, 78);
            this.txtMaGiangVien.Name = "txtMaGiangVien";
            this.txtMaGiangVien.Size = new System.Drawing.Size(320, 21);
            this.txtMaGiangVien.TabIndex = 2;
            // 
            // Search_GiangVien
            // 
            this.Search_GiangVien.AutoSize = true;
            this.Search_GiangVien.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Search_GiangVien.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Search_GiangVien.Location = new System.Drawing.Point(548, 68);
            this.Search_GiangVien.Name = "Search_GiangVien";
            this.Search_GiangVien.Size = new System.Drawing.Size(113, 34);
            this.Search_GiangVien.TabIndex = 3;
            this.Search_GiangVien.Text = "Tìm kiếm";
            this.Search_GiangVien.UseVisualStyleBackColor = false;
            this.Search_GiangVien.Click += new System.EventHandler(this.Search_GiangVien_Click);
            // 
            // dgvGiangVien
            // 
            this.dgvGiangVien.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.dgvGiangVien.ColumnHeadersHeight = 58;
            this.dgvGiangVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvGiangVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ThemTaiKhoan});
            this.dgvGiangVien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvGiangVien.GridColor = System.Drawing.Color.Black;
            this.dgvGiangVien.Location = new System.Drawing.Point(0, 121);
            this.dgvGiangVien.Name = "dgvGiangVien";
            this.dgvGiangVien.RowHeadersWidth = 102;
            this.dgvGiangVien.RowTemplate.Height = 40;
            this.dgvGiangVien.Size = new System.Drawing.Size(1184, 340);
            this.dgvGiangVien.TabIndex = 4;
            this.dgvGiangVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGiangVien_CellContentClick);
            // 
            // ThemTaiKhoan
            // 
            this.ThemTaiKhoan.HeaderText = "ThemTaiKhoan";
            this.ThemTaiKhoan.MinimumWidth = 6;
            this.ThemTaiKhoan.Name = "ThemTaiKhoan";
            this.ThemTaiKhoan.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ThemTaiKhoan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ThemTaiKhoan.Width = 125;
            // 
            // Delete_GiangVien
            // 
            this.Delete_GiangVien.AutoSize = true;
            this.Delete_GiangVien.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Delete_GiangVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_GiangVien.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Delete_GiangVien.Location = new System.Drawing.Point(805, 68);
            this.Delete_GiangVien.Name = "Delete_GiangVien";
            this.Delete_GiangVien.Size = new System.Drawing.Size(88, 34);
            this.Delete_GiangVien.TabIndex = 5;
            this.Delete_GiangVien.Text = "Xóa";
            this.Delete_GiangVien.UseVisualStyleBackColor = false;
            this.Delete_GiangVien.Click += new System.EventHandler(this.Delete_GiangVien_Click);
            // 
            // ReloadData
            // 
            this.ReloadData.AutoSize = true;
            this.ReloadData.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ReloadData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReloadData.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ReloadData.Location = new System.Drawing.Point(909, 68);
            this.ReloadData.Name = "ReloadData";
            this.ReloadData.Size = new System.Drawing.Size(107, 34);
            this.ReloadData.TabIndex = 6;
            this.ReloadData.Text = "Reload";
            this.ReloadData.UseVisualStyleBackColor = false;
            this.ReloadData.Click += new System.EventHandler(this.ReloadData_Click);
            // 
            // Capnhat_GiangVien
            // 
            this.Capnhat_GiangVien.AutoSize = true;
            this.Capnhat_GiangVien.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Capnhat_GiangVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Capnhat_GiangVien.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Capnhat_GiangVien.Location = new System.Drawing.Point(676, 68);
            this.Capnhat_GiangVien.Name = "Capnhat_GiangVien";
            this.Capnhat_GiangVien.Size = new System.Drawing.Size(111, 34);
            this.Capnhat_GiangVien.TabIndex = 7;
            this.Capnhat_GiangVien.Text = "Cập nhật";
            this.Capnhat_GiangVien.UseVisualStyleBackColor = false;
            this.Capnhat_GiangVien.Click += new System.EventHandler(this.Capnhat_GiangVien_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 53);
            this.panel1.TabIndex = 8;
            // 
            // Admin_GiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1184, 461);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Capnhat_GiangVien);
            this.Controls.Add(this.ReloadData);
            this.Controls.Add(this.Delete_GiangVien);
            this.Controls.Add(this.dgvGiangVien);
            this.Controls.Add(this.Search_GiangVien);
            this.Controls.Add(this.txtMaGiangVien);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Admin_GiangVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý thông tin giảng viên";
            this.Load += new System.EventHandler(this.Admin_GiangVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiangVien)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaGiangVien;
        private System.Windows.Forms.Button Search_GiangVien;
        private System.Windows.Forms.DataGridView dgvGiangVien;
        private System.Windows.Forms.Button Delete_GiangVien;
        private System.Windows.Forms.Button ReloadData;
        private System.Windows.Forms.Button Capnhat_GiangVien;
        private System.Windows.Forms.DataGridViewButtonColumn ThemTaiKhoan;
        private System.Windows.Forms.Panel panel1;
    }
}