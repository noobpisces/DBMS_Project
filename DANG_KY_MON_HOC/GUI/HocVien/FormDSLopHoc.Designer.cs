namespace DANG_KY_MON_HOC.GUI
{
    partial class FormDSLopHoc
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
            this.dataGridView_DSLop = new System.Windows.Forms.DataGridView();
            this.Dangky = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bt_DangKy = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DSLop)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_DSLop
            // 
            this.dataGridView_DSLop.BackgroundColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_DSLop.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_DSLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DSLop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dangky});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_DSLop.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_DSLop.GridColor = System.Drawing.Color.Black;
            this.dataGridView_DSLop.Location = new System.Drawing.Point(9, 151);
            this.dataGridView_DSLop.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_DSLop.Name = "dataGridView_DSLop";
            this.dataGridView_DSLop.RowHeadersWidth = 51;
            this.dataGridView_DSLop.RowTemplate.Height = 24;
            this.dataGridView_DSLop.Size = new System.Drawing.Size(1147, 215);
            this.dataGridView_DSLop.TabIndex = 0;
            this.dataGridView_DSLop.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_DSLop_CellContentClick);
            // 
            // Dangky
            // 
            this.Dangky.HeaderText = "DangKy";
            this.Dangky.MinimumWidth = 6;
            this.Dangky.Name = "Dangky";
            this.Dangky.Width = 125;
            // 
            // bt_DangKy
            // 
            this.bt_DangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_DangKy.Location = new System.Drawing.Point(1031, 371);
            this.bt_DangKy.Margin = new System.Windows.Forms.Padding(2);
            this.bt_DangKy.Name = "bt_DangKy";
            this.bt_DangKy.Size = new System.Drawing.Size(124, 36);
            this.bt_DangKy.TabIndex = 1;
            this.bt_DangKy.Text = "Đăng ký";
            this.bt_DangKy.UseVisualStyleBackColor = true;
            this.bt_DangKy.Click += new System.EventHandler(this.bt_DangKy_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1165, 78);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1165, 78);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH LỚP HỌC";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Danh sách lớp học";
            // 
            // FormDSLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(1165, 417);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bt_DangKy);
            this.Controls.Add(this.dataGridView_DSLop);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormDSLopHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách lớp học";
            this.Load += new System.EventHandler(this.FormDSLopHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DSLop)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_DSLop;
        private System.Windows.Forms.Button bt_DangKy;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Dangki;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Dangky;
    }
}