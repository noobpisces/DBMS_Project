namespace DANG_KY_MON_HOC.GUI.Admin
{
    partial class Admin_LopHoc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaLopHoc = new System.Windows.Forms.TextBox();
            this.btnSearchLopHoc = new System.Windows.Forms.Button();
            this.btnDeleteLopHP = new System.Windows.Forms.Button();
            this.btnUpdateLop = new System.Windows.Forms.Button();
            this.Reload_Lop = new System.Windows.Forms.Button();
            this.dgvLopHoc = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopHoc)).BeginInit();
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
            this.label1.Text = "QUẢN LÝ THÔNG TIN LỚP HỌC";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(8, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập mã lớp học: ";
            // 
            // txtMaLopHoc
            // 
            this.txtMaLopHoc.Location = new System.Drawing.Point(154, 70);
            this.txtMaLopHoc.Margin = new System.Windows.Forms.Padding(1);
            this.txtMaLopHoc.Name = "txtMaLopHoc";
            this.txtMaLopHoc.Size = new System.Drawing.Size(174, 20);
            this.txtMaLopHoc.TabIndex = 2;
            // 
            // btnSearchLopHoc
            // 
            this.btnSearchLopHoc.AutoSize = true;
            this.btnSearchLopHoc.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearchLopHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchLopHoc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearchLopHoc.Location = new System.Drawing.Point(371, 62);
            this.btnSearchLopHoc.Margin = new System.Windows.Forms.Padding(1);
            this.btnSearchLopHoc.Name = "btnSearchLopHoc";
            this.btnSearchLopHoc.Size = new System.Drawing.Size(100, 32);
            this.btnSearchLopHoc.TabIndex = 3;
            this.btnSearchLopHoc.Text = "Tìm kiếm";
            this.btnSearchLopHoc.UseVisualStyleBackColor = false;
            this.btnSearchLopHoc.Click += new System.EventHandler(this.btnSearchLopHoc_Click);
            // 
            // btnDeleteLopHP
            // 
            this.btnDeleteLopHP.AutoSize = true;
            this.btnDeleteLopHP.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeleteLopHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteLopHP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDeleteLopHP.Location = new System.Drawing.Point(650, 62);
            this.btnDeleteLopHP.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteLopHP.Name = "btnDeleteLopHP";
            this.btnDeleteLopHP.Size = new System.Drawing.Size(78, 32);
            this.btnDeleteLopHP.TabIndex = 4;
            this.btnDeleteLopHP.Text = "Xóa";
            this.btnDeleteLopHP.UseVisualStyleBackColor = false;
            this.btnDeleteLopHP.Click += new System.EventHandler(this.btnDeleteLopHP_Click);
            // 
            // btnUpdateLop
            // 
            this.btnUpdateLop.AutoSize = true;
            this.btnUpdateLop.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdateLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateLop.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdateLop.Location = new System.Drawing.Point(515, 62);
            this.btnUpdateLop.Margin = new System.Windows.Forms.Padding(1);
            this.btnUpdateLop.Name = "btnUpdateLop";
            this.btnUpdateLop.Size = new System.Drawing.Size(89, 32);
            this.btnUpdateLop.TabIndex = 5;
            this.btnUpdateLop.Text = "Cập nhật";
            this.btnUpdateLop.UseVisualStyleBackColor = false;
            this.btnUpdateLop.Click += new System.EventHandler(this.btnUpdateLop_Click);
            // 
            // Reload_Lop
            // 
            this.Reload_Lop.AutoSize = true;
            this.Reload_Lop.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Reload_Lop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reload_Lop.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Reload_Lop.Location = new System.Drawing.Point(780, 62);
            this.Reload_Lop.Margin = new System.Windows.Forms.Padding(1);
            this.Reload_Lop.Name = "Reload_Lop";
            this.Reload_Lop.Size = new System.Drawing.Size(76, 32);
            this.Reload_Lop.TabIndex = 6;
            this.Reload_Lop.Text = "Reload";
            this.Reload_Lop.UseVisualStyleBackColor = false;
            this.Reload_Lop.Click += new System.EventHandler(this.Reload_Lop_Click);
            // 
            // dgvLopHoc
            // 
            this.dgvLopHoc.BackgroundColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLopHoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLopHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLopHoc.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLopHoc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvLopHoc.GridColor = System.Drawing.Color.Black;
            this.dgvLopHoc.Location = new System.Drawing.Point(0, 120);
            this.dgvLopHoc.Margin = new System.Windows.Forms.Padding(1);
            this.dgvLopHoc.Name = "dgvLopHoc";
            this.dgvLopHoc.RowHeadersWidth = 102;
            this.dgvLopHoc.RowTemplate.Height = 40;
            this.dgvLopHoc.Size = new System.Drawing.Size(1184, 341);
            this.dgvLopHoc.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 46);
            this.panel1.TabIndex = 8;
            // 
            // Admin_LopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1184, 461);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvLopHoc);
            this.Controls.Add(this.Reload_Lop);
            this.Controls.Add(this.btnUpdateLop);
            this.Controls.Add(this.btnDeleteLopHP);
            this.Controls.Add(this.btnSearchLopHoc);
            this.Controls.Add(this.txtMaLopHoc);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Admin_LopHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý thông tin lớp học";
            this.Load += new System.EventHandler(this.QuanLyLopHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopHoc)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaLopHoc;
        private System.Windows.Forms.Button btnSearchLopHoc;
        private System.Windows.Forms.Button btnDeleteLopHP;
        private System.Windows.Forms.Button btnUpdateLop;
        private System.Windows.Forms.Button Reload_Lop;
        private System.Windows.Forms.DataGridView dgvLopHoc;
        private System.Windows.Forms.Panel panel1;
    }
}