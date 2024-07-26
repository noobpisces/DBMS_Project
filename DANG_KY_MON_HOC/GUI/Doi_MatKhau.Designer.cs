namespace DANG_KY_MON_HOC.GUI
{
    partial class Doi_MatKhau
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
            this.SuspendLayout();
            // 
            // bt_Doi
            // 
            this.bt_Doi.Location = new System.Drawing.Point(487, 323);
            this.bt_Doi.Name = "bt_Doi";
            this.bt_Doi.Size = new System.Drawing.Size(102, 23);
            this.bt_Doi.TabIndex = 0;
            this.bt_Doi.Text = "Đổi mật khẩu";
            this.bt_Doi.UseVisualStyleBackColor = true;
            this.bt_Doi.Click += new System.EventHandler(this.bt_Doi_Click);
            // 
            // tb_TK
            // 
            this.tb_TK.Location = new System.Drawing.Point(205, 81);
            this.tb_TK.Name = "tb_TK";
            this.tb_TK.Size = new System.Drawing.Size(247, 22);
            this.tb_TK.TabIndex = 1;
            // 
            // tb_MK_Cu
            // 
            this.tb_MK_Cu.Location = new System.Drawing.Point(205, 151);
            this.tb_MK_Cu.Name = "tb_MK_Cu";
            this.tb_MK_Cu.Size = new System.Drawing.Size(247, 22);
            this.tb_MK_Cu.TabIndex = 2;
            // 
            // tb_MK_Moi
            // 
            this.tb_MK_Moi.Location = new System.Drawing.Point(205, 238);
            this.tb_MK_Moi.Name = "tb_MK_Moi";
            this.tb_MK_Moi.Size = new System.Drawing.Size(247, 22);
            this.tb_MK_Moi.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mật khẩu cũ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mật khẩu mới";
            // 
            // Doi_MatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_MK_Moi);
            this.Controls.Add(this.tb_MK_Cu);
            this.Controls.Add(this.tb_TK);
            this.Controls.Add(this.bt_Doi);
            this.Name = "Doi_MatKhau";
            this.Text = "Doi_MatKhau";
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
    }
}