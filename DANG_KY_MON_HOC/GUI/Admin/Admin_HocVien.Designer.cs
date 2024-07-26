namespace DANG_KY_MON_HOC.GUI.Admin
{
    partial class Admin_HocVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaHocVien = new System.Windows.Forms.TextBox();
            this.btnSearchHocVien = new System.Windows.Forms.Button();
            this.btnDeleteHocVien = new System.Windows.Forms.Button();
            this.btnUpdateHocVien = new System.Windows.Forms.Button();
            this.Reload_HocVien = new System.Windows.Forms.Button();
            this.dgvHocVien = new System.Windows.Forms.DataGridView();
            this.ThemTaiKhoan = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocVien)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1184, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ THÔNG TIN HỌC VIÊN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(7, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập mã học viên:";
            // 
            // txtMaHocVien
            // 
            this.txtMaHocVien.Location = new System.Drawing.Point(165, 72);
            this.txtMaHocVien.Margin = new System.Windows.Forms.Padding(1);
            this.txtMaHocVien.Name = "txtMaHocVien";
            this.txtMaHocVien.Size = new System.Drawing.Size(168, 20);
            this.txtMaHocVien.TabIndex = 2;
            // 
            // btnSearchHocVien
            // 
            this.btnSearchHocVien.AutoSize = true;
            this.btnSearchHocVien.BackColor = System.Drawing.Color.White;
            this.btnSearchHocVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchHocVien.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearchHocVien.Location = new System.Drawing.Point(382, 64);
            this.btnSearchHocVien.Margin = new System.Windows.Forms.Padding(1);
            this.btnSearchHocVien.Name = "btnSearchHocVien";
            this.btnSearchHocVien.Size = new System.Drawing.Size(117, 33);
            this.btnSearchHocVien.TabIndex = 3;
            this.btnSearchHocVien.Text = "Tìm Kiếm";
            this.btnSearchHocVien.UseVisualStyleBackColor = false;
            this.btnSearchHocVien.Click += new System.EventHandler(this.btnSearchHocVien_Click);
            // 
            // btnDeleteHocVien
            // 
            this.btnDeleteHocVien.AutoSize = true;
            this.btnDeleteHocVien.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeleteHocVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteHocVien.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDeleteHocVien.Location = new System.Drawing.Point(628, 64);
            this.btnDeleteHocVien.Margin = new System.Windows.Forms.Padding(1);
            this.btnDeleteHocVien.Name = "btnDeleteHocVien";
            this.btnDeleteHocVien.Size = new System.Drawing.Size(88, 33);
            this.btnDeleteHocVien.TabIndex = 4;
            this.btnDeleteHocVien.Text = "Xóa";
            this.btnDeleteHocVien.UseVisualStyleBackColor = false;
            this.btnDeleteHocVien.Click += new System.EventHandler(this.btnDeleteHocVien_Click);
            // 
            // btnUpdateHocVien
            // 
            this.btnUpdateHocVien.AutoSize = true;
            this.btnUpdateHocVien.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdateHocVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateHocVien.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdateHocVien.Location = new System.Drawing.Point(515, 64);
            this.btnUpdateHocVien.Margin = new System.Windows.Forms.Padding(1);
            this.btnUpdateHocVien.Name = "btnUpdateHocVien";
            this.btnUpdateHocVien.Size = new System.Drawing.Size(95, 33);
            this.btnUpdateHocVien.TabIndex = 5;
            this.btnUpdateHocVien.Text = "Cập nhật";
            this.btnUpdateHocVien.UseVisualStyleBackColor = false;
            this.btnUpdateHocVien.Click += new System.EventHandler(this.btnUpdateHocVien_Click);
            // 
            // Reload_HocVien
            // 
            this.Reload_HocVien.AutoSize = true;
            this.Reload_HocVien.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Reload_HocVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reload_HocVien.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Reload_HocVien.Location = new System.Drawing.Point(742, 64);
            this.Reload_HocVien.Margin = new System.Windows.Forms.Padding(1);
            this.Reload_HocVien.Name = "Reload_HocVien";
            this.Reload_HocVien.Size = new System.Drawing.Size(80, 33);
            this.Reload_HocVien.TabIndex = 6;
            this.Reload_HocVien.Text = "Reload";
            this.Reload_HocVien.UseVisualStyleBackColor = false;
            this.Reload_HocVien.Click += new System.EventHandler(this.Reload_HocVien_Click);
            // 
            // dgvHocVien
            // 
            this.dgvHocVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvHocVien.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvHocVien.BackgroundColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHocVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHocVien.ColumnHeadersHeight = 58;
            this.dgvHocVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvHocVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ThemTaiKhoan});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHocVien.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvHocVien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvHocVien.GridColor = System.Drawing.Color.Black;
            this.dgvHocVien.Location = new System.Drawing.Point(0, 121);
            this.dgvHocVien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvHocVien.Name = "dgvHocVien";
            this.dgvHocVien.RowHeadersWidth = 102;
            this.dgvHocVien.RowTemplate.Height = 40;
            this.dgvHocVien.Size = new System.Drawing.Size(1184, 340);
            this.dgvHocVien.TabIndex = 4;
            this.dgvHocVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHocVien_CellContentClick);
            // 
            // ThemTaiKhoan
            // 
            this.ThemTaiKhoan.HeaderText = "ThemTaiKhoan";
            this.ThemTaiKhoan.MinimumWidth = 6;
            this.ThemTaiKhoan.Name = "ThemTaiKhoan";
            this.ThemTaiKhoan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ThemTaiKhoan.Width = 129;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 42);
            this.panel1.TabIndex = 8;
            // 
            // Admin_HocVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1184, 461);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvHocVien);
            this.Controls.Add(this.Reload_HocVien);
            this.Controls.Add(this.btnUpdateHocVien);
            this.Controls.Add(this.btnDeleteHocVien);
            this.Controls.Add(this.btnSearchHocVien);
            this.Controls.Add(this.txtMaHocVien);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Admin_HocVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý thông tin học viên";
            this.Load += new System.EventHandler(this.Admin_HocVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocVien)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaHocVien;
        private System.Windows.Forms.Button btnSearchHocVien;
        private System.Windows.Forms.Button btnDeleteHocVien;
        private System.Windows.Forms.Button btnUpdateHocVien;
        private System.Windows.Forms.Button Reload_HocVien;
        private System.Windows.Forms.DataGridView dgvHocVien;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewButtonColumn ThemTaiKhoan;
    }
}