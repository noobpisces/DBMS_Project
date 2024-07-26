namespace DANG_KY_MON_HOC.GUI.Admin
{
    partial class Admin_TaoTaiKhoan
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
            this.tb_TaiKhoan = new System.Windows.Forms.TextBox();
            this.tb_MatKhau = new System.Windows.Forms.TextBox();
            this.bt_Create_ACC = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_TaiKhoan
            // 
            this.tb_TaiKhoan.Location = new System.Drawing.Point(202, 228);
            this.tb_TaiKhoan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_TaiKhoan.Name = "tb_TaiKhoan";
            this.tb_TaiKhoan.Size = new System.Drawing.Size(226, 20);
            this.tb_TaiKhoan.TabIndex = 0;
            // 
            // tb_MatKhau
            // 
            this.tb_MatKhau.Location = new System.Drawing.Point(202, 276);
            this.tb_MatKhau.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_MatKhau.Name = "tb_MatKhau";
            this.tb_MatKhau.Size = new System.Drawing.Size(226, 20);
            this.tb_MatKhau.TabIndex = 1;
            // 
            // bt_Create_ACC
            // 
            this.bt_Create_ACC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Create_ACC.Location = new System.Drawing.Point(239, 330);
            this.bt_Create_ACC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_Create_ACC.Name = "bt_Create_ACC";
            this.bt_Create_ACC.Size = new System.Drawing.Size(129, 26);
            this.bt_Create_ACC.TabIndex = 2;
            this.bt_Create_ACC.Text = "Tạo tài khoản";
            this.bt_Create_ACC.UseVisualStyleBackColor = true;
            this.bt_Create_ACC.Click += new System.EventHandler(this.bt_Create_ACC_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 228);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(111, 276);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mật khẩu";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 81);
            this.panel1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(600, 81);
            this.label3.TabIndex = 0;
            this.label3.Text = "TẠO TÀI KHOẢN";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::DANG_KY_MON_HOC.Properties.Resources.add_user;
            this.pictureBox1.Location = new System.Drawing.Point(0, 81);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Admin_TaoTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_Create_ACC);
            this.Controls.Add(this.tb_MatKhau);
            this.Controls.Add(this.tb_TaiKhoan);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Admin_TaoTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tạo tài khoản";
            this.Load += new System.EventHandler(this.Admin_Create_ACCcs_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_TaiKhoan;
        private System.Windows.Forms.TextBox tb_MatKhau;
        private System.Windows.Forms.Button bt_Create_ACC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}