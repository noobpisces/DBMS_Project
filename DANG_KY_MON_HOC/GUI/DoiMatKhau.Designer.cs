namespace DANG_KY_MON_HOC.GUI
{
    partial class DoiMatKhau
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
            this.bt_Doi = new System.Windows.Forms.Button();
            this.tb_TK = new System.Windows.Forms.TextBox();
            this.tb_MK_Cu = new System.Windows.Forms.TextBox();
            this.tb_MK_Moi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_Doi
            // 
            this.bt_Doi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Doi.Location = new System.Drawing.Point(471, 331);
            this.bt_Doi.Margin = new System.Windows.Forms.Padding(2);
            this.bt_Doi.Name = "bt_Doi";
            this.bt_Doi.Size = new System.Drawing.Size(118, 24);
            this.bt_Doi.TabIndex = 0;
            this.bt_Doi.Text = "Đổi mật khẩu";
            this.bt_Doi.UseVisualStyleBackColor = true;
            this.bt_Doi.Click += new System.EventHandler(this.bt_Doi_Click);
            // 
            // tb_TK
            // 
            this.tb_TK.Location = new System.Drawing.Point(177, 197);
            this.tb_TK.Margin = new System.Windows.Forms.Padding(2);
            this.tb_TK.Name = "tb_TK";
            this.tb_TK.Size = new System.Drawing.Size(243, 20);
            this.tb_TK.TabIndex = 1;
            // 
            // tb_MK_Cu
            // 
            this.tb_MK_Cu.Location = new System.Drawing.Point(177, 250);
            this.tb_MK_Cu.Margin = new System.Windows.Forms.Padding(2);
            this.tb_MK_Cu.Name = "tb_MK_Cu";
            this.tb_MK_Cu.Size = new System.Drawing.Size(243, 20);
            this.tb_MK_Cu.TabIndex = 2;
            // 
            // tb_MK_Moi
            // 
            this.tb_MK_Moi.Location = new System.Drawing.Point(177, 299);
            this.tb_MK_Moi.Margin = new System.Windows.Forms.Padding(2);
            this.tb_MK_Moi.Name = "tb_MK_Moi";
            this.tb_MK_Moi.Size = new System.Drawing.Size(243, 20);
            this.tb_MK_Moi.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 197);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 252);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mật khẩu cũ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 299);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mật khẩu mới";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 70);
            this.panel1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(600, 70);
            this.label4.TabIndex = 0;
            this.label4.Text = "ĐỔI MẬT KHẨU";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::DANG_KY_MON_HOC.Properties.Resources.reset_password;
            this.pictureBox1.Location = new System.Drawing.Point(0, 70);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Doi_MatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_MK_Moi);
            this.Controls.Add(this.tb_MK_Cu);
            this.Controls.Add(this.tb_TK);
            this.Controls.Add(this.bt_Doi);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Doi_MatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Doi;
        private System.Windows.Forms.TextBox tb_TK;
        private System.Windows.Forms.TextBox tb_MK_Cu;
        private System.Windows.Forms.TextBox tb_MK_Moi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}