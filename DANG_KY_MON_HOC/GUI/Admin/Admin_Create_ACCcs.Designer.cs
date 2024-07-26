namespace DANG_KY_MON_HOC.GUI.Admin
{
    partial class Admin_TaoTaiKhoancs
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
            this.bt_TaoTaiKhoan = new System.Windows.Forms.Button();
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
            this.tb_TaiKhoan.Location = new System.Drawing.Point(269, 280);
            this.tb_TaiKhoan.Name = "tb_TaiKhoan";
            this.tb_TaiKhoan.Size = new System.Drawing.Size(300, 22);
            this.tb_TaiKhoan.TabIndex = 0;
            // 
            // tb_MatKhau
            // 
            this.tb_MatKhau.Location = new System.Drawing.Point(269, 340);
            this.tb_MatKhau.Name = "tb_MatKhau";
            this.tb_MatKhau.Size = new System.Drawing.Size(300, 22);
            this.tb_MatKhau.TabIndex = 1;
            // 
            // bt_TaoTaiKhoan
            // 
            this.bt_TaoTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_TaoTaiKhoan.Location = new System.Drawing.Point(319, 406);
            this.bt_TaoTaiKhoan.Name = "bt_TaoTaiKhoan";
            this.bt_TaoTaiKhoan.Size = new System.Drawing.Size(172, 32);
            this.bt_TaoTaiKhoan.TabIndex = 2;
            this.bt_TaoTaiKhoan.Text = "Tạo tài khoản";
            this.bt_TaoTaiKhoan.UseVisualStyleBackColor = true;
            this.bt_TaoTaiKhoan.Click += new System.EventHandler(this.bt_TaoTaiKhoan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(148, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mật khẩu";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(800, 100);
            this.label3.TabIndex = 0;
            this.label3.Text = "TẠO TÀI KHOẢN";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::DANG_KY_MON_HOC.Properties.Resources.add_user;
            this.pictureBox1.Location = new System.Drawing.Point(0, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Admin_TaoTaiKhoancs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_TaoTaiKhoan);
            this.Controls.Add(this.tb_MatKhau);
            this.Controls.Add(this.tb_TaiKhoan);
            this.Name = "Admin_TaoTaiKhoancs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_TaoTaiKhoancs";
            this.Load += new System.EventHandler(this.Admin_TaoTaiKhoancs_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_TaiKhoan;
        private System.Windows.Forms.TextBox tb_MatKhau;
        private System.Windows.Forms.Button bt_TaoTaiKhoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}