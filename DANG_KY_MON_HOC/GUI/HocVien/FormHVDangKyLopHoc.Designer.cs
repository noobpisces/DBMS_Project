namespace DANG_KY_MON_HOC.GUI
{
    partial class FormHVDangKyLopHoc
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lb_TenHV = new System.Windows.Forms.Label();
            this.lb_MaHV = new System.Windows.Forms.Label();
            this.lb_Khoa = new System.Windows.Forms.Label();
            this.dataGridView_DSMon = new System.Windows.Forms.DataGridView();
            this.Dangki = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dANG_KY_MON_HOCDataSet = new DANG_KY_MON_HOC.DANG_KY_MON_HOCDataSet();
            this.vDSDaDangKiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_DSDaDangKiTableAdapter = new DANG_KY_MON_HOC.DANG_KY_MON_HOCDataSetTableAdapters.v_DSDaDangKiTableAdapter();
            this.vDSLopHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_DSLopHocTableAdapter = new DANG_KY_MON_HOC.DANG_KY_MON_HOCDataSetTableAdapters.v_DSLopHocTableAdapter();
            this.dataGridView_DSDaDK = new System.Windows.Forms.DataGridView();
            this.Xoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ChuyenLop = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_TKB = new System.Windows.Forms.Button();
            this.bt_Phieu = new System.Windows.Forms.Button();
            this.bt_ChiTiet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_HocPhi = new System.Windows.Forms.TextBox();
            this.tb_TimKiem = new System.Windows.Forms.TextBox();
            this.bt_TimKiem = new System.Windows.Forms.Button();
            this.cb_MaHocKi = new System.Windows.Forms.ComboBox();
            this.bt_Reload = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bt_DangXuat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DSMon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dANG_KY_MON_HOCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDSDaDangKiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDSLopHocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DSDaDK)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_TenHV
            // 
            this.lb_TenHV.AutoSize = true;
            this.lb_TenHV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TenHV.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_TenHV.Location = new System.Drawing.Point(171, 119);
            this.lb_TenHV.Name = "lb_TenHV";
            this.lb_TenHV.Size = new System.Drawing.Size(55, 20);
            this.lb_TenHV.TabIndex = 0;
            this.lb_TenHV.Text = "hoten";
            // 
            // lb_MaHV
            // 
            this.lb_MaHV.AutoSize = true;
            this.lb_MaHV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MaHV.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_MaHV.Location = new System.Drawing.Point(171, 155);
            this.lb_MaHV.Name = "lb_MaHV";
            this.lb_MaHV.Size = new System.Drawing.Size(98, 20);
            this.lb_MaHV.TabIndex = 1;
            this.lb_MaHV.Text = "mahocvien";
            // 
            // lb_Khoa
            // 
            this.lb_Khoa.AutoSize = true;
            this.lb_Khoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Khoa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_Khoa.Location = new System.Drawing.Point(171, 193);
            this.lb_Khoa.Name = "lb_Khoa";
            this.lb_Khoa.Size = new System.Drawing.Size(73, 20);
            this.lb_Khoa.TabIndex = 2;
            this.lb_Khoa.Text = "makhoa";
            // 
            // dataGridView_DSMon
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView_DSMon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_DSMon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_DSMon.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_DSMon.BackgroundColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_DSMon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_DSMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DSMon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dangki});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_DSMon.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_DSMon.GridColor = System.Drawing.Color.Black;
            this.dataGridView_DSMon.Location = new System.Drawing.Point(12, 236);
            this.dataGridView_DSMon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_DSMon.Name = "dataGridView_DSMon";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_DSMon.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_DSMon.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView_DSMon.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView_DSMon.RowTemplate.Height = 24;
            this.dataGridView_DSMon.Size = new System.Drawing.Size(1859, 244);
            this.dataGridView_DSMon.TabIndex = 3;
            this.dataGridView_DSMon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_DSMon_CellContentClick);
            // 
            // Dangki
            // 
            this.Dangki.HeaderText = "Dangki";
            this.Dangki.MinimumWidth = 6;
            this.Dangki.Name = "Dangki";
            this.Dangki.Text = "Dangki";
            // 
            // dANG_KY_MON_HOCDataSet
            // 
            this.dANG_KY_MON_HOCDataSet.DataSetName = "DANG_KY_MON_HOCDataSet";
            this.dANG_KY_MON_HOCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vDSDaDangKiBindingSource
            // 
            this.vDSDaDangKiBindingSource.DataMember = "v_DSDaDangKi";
            this.vDSDaDangKiBindingSource.DataSource = this.dANG_KY_MON_HOCDataSet;
            // 
            // v_DSDaDangKiTableAdapter
            // 
            this.v_DSDaDangKiTableAdapter.ClearBeforeFill = true;
            // 
            // vDSLopHocBindingSource
            // 
            this.vDSLopHocBindingSource.DataMember = "v_DSLopHoc";
            this.vDSLopHocBindingSource.DataSource = this.dANG_KY_MON_HOCDataSet;
            // 
            // v_DSLopHocTableAdapter
            // 
            this.v_DSLopHocTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView_DSDaDK
            // 
            this.dataGridView_DSDaDK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_DSDaDK.BackgroundColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_DSDaDK.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView_DSDaDK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DSDaDK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Xoa,
            this.ChuyenLop});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_DSDaDK.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView_DSDaDK.GridColor = System.Drawing.Color.Black;
            this.dataGridView_DSDaDK.Location = new System.Drawing.Point(5, 529);
            this.dataGridView_DSDaDK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_DSDaDK.Name = "dataGridView_DSDaDK";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_DSDaDK.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView_DSDaDK.RowHeadersWidth = 51;
            this.dataGridView_DSDaDK.RowTemplate.Height = 24;
            this.dataGridView_DSDaDK.Size = new System.Drawing.Size(1867, 199);
            this.dataGridView_DSDaDK.TabIndex = 4;
            this.dataGridView_DSDaDK.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_DSDaDK_CellContentClick);
            // 
            // Xoa
            // 
            this.Xoa.HeaderText = "Xoa";
            this.Xoa.MinimumWidth = 6;
            this.Xoa.Name = "Xoa";
            this.Xoa.Text = "Xoa";
            // 
            // ChuyenLop
            // 
            this.ChuyenLop.HeaderText = "ChuyenLop";
            this.ChuyenLop.MinimumWidth = 6;
            this.ChuyenLop.Name = "ChuyenLop";
            this.ChuyenLop.Text = "ChuyenLop";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(20, 507);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Danh sách các môn đã đăng ký";
            // 
            // bt_TKB
            // 
            this.bt_TKB.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_TKB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_TKB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_TKB.Location = new System.Drawing.Point(15, 774);
            this.bt_TKB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_TKB.Name = "bt_TKB";
            this.bt_TKB.Size = new System.Drawing.Size(75, 34);
            this.bt_TKB.TabIndex = 7;
            this.bt_TKB.Text = "TKB";
            this.bt_TKB.UseVisualStyleBackColor = false;
            this.bt_TKB.Click += new System.EventHandler(this.bt_TKB_Click);
            // 
            // bt_Phieu
            // 
            this.bt_Phieu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_Phieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Phieu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_Phieu.Location = new System.Drawing.Point(116, 774);
            this.bt_Phieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Phieu.Name = "bt_Phieu";
            this.bt_Phieu.Size = new System.Drawing.Size(175, 34);
            this.bt_Phieu.TabIndex = 8;
            this.bt_Phieu.Text = "Xuất phiếu đăng kí";
            this.bt_Phieu.UseVisualStyleBackColor = false;
            this.bt_Phieu.Click += new System.EventHandler(this.bt_Phieu_Click);
            // 
            // bt_ChiTiet
            // 
            this.bt_ChiTiet.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_ChiTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ChiTiet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_ChiTiet.Location = new System.Drawing.Point(1740, 768);
            this.bt_ChiTiet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_ChiTiet.Name = "bt_ChiTiet";
            this.bt_ChiTiet.Size = new System.Drawing.Size(131, 28);
            this.bt_ChiTiet.TabIndex = 9;
            this.bt_ChiTiet.Text = "Chi tiết";
            this.bt_ChiTiet.UseVisualStyleBackColor = false;
            this.bt_ChiTiet.Click += new System.EventHandler(this.bt_ChiTiet_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(1404, 774);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Học Phí:";
            // 
            // tb_HocPhi
            // 
            this.tb_HocPhi.Location = new System.Drawing.Point(1513, 772);
            this.tb_HocPhi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_HocPhi.Name = "tb_HocPhi";
            this.tb_HocPhi.Size = new System.Drawing.Size(221, 22);
            this.tb_HocPhi.TabIndex = 11;
            // 
            // tb_TimKiem
            // 
            this.tb_TimKiem.Location = new System.Drawing.Point(1421, 198);
            this.tb_TimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_TimKiem.Name = "tb_TimKiem";
            this.tb_TimKiem.Size = new System.Drawing.Size(247, 22);
            this.tb_TimKiem.TabIndex = 12;
            // 
            // bt_TimKiem
            // 
            this.bt_TimKiem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_TimKiem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_TimKiem.Location = new System.Drawing.Point(1688, 193);
            this.bt_TimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_TimKiem.Name = "bt_TimKiem";
            this.bt_TimKiem.Size = new System.Drawing.Size(181, 37);
            this.bt_TimKiem.TabIndex = 13;
            this.bt_TimKiem.Text = "Tìm kiếm";
            this.bt_TimKiem.UseVisualStyleBackColor = false;
            this.bt_TimKiem.Click += new System.EventHandler(this.bt_TimKiem_Click);
            // 
            // cb_MaHocKi
            // 
            this.cb_MaHocKi.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cb_MaHocKi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_MaHocKi.ForeColor = System.Drawing.Color.Blue;
            this.cb_MaHocKi.FormattingEnabled = true;
            this.cb_MaHocKi.Items.AddRange(new object[] {
            "HK1_22-23",
            "HK2_22-23",
            "HK3_22-23"});
            this.cb_MaHocKi.Location = new System.Drawing.Point(1208, 194);
            this.cb_MaHocKi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_MaHocKi.Name = "cb_MaHocKi";
            this.cb_MaHocKi.Size = new System.Drawing.Size(188, 28);
            this.cb_MaHocKi.TabIndex = 14;
            this.cb_MaHocKi.Text = "HK1_22-23";
            this.cb_MaHocKi.SelectedValueChanged += new System.EventHandler(this.cb_MaHocKi_SelectedValueChanged);
            // 
            // bt_Reload
            // 
            this.bt_Reload.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_Reload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Reload.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_Reload.Location = new System.Drawing.Point(321, 774);
            this.bt_Reload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Reload.Name = "bt_Reload";
            this.bt_Reload.Size = new System.Drawing.Size(99, 37);
            this.bt_Reload.TabIndex = 6;
            this.bt_Reload.Text = "Reload";
            this.bt_Reload.UseVisualStyleBackColor = false;
            this.bt_Reload.Click += new System.EventHandler(this.bt_Reload_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1884, 95);
            this.panel1.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1884, 95);
            this.label3.TabIndex = 0;
            this.label3.Text = "HỌC VIÊN ĐĂNG KÝ MÔN HỌC";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.SandyBrown;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Họ tên:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Mã Học viên:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Mã Khoa:";
            // 
            // bt_DangXuat
            // 
            this.bt_DangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_DangXuat.Location = new System.Drawing.Point(457, 774);
            this.bt_DangXuat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_DangXuat.Name = "bt_DangXuat";
            this.bt_DangXuat.Size = new System.Drawing.Size(169, 34);
            this.bt_DangXuat.TabIndex = 1;
            this.bt_DangXuat.Text = "Đăng xuất";
            this.bt_DangXuat.UseVisualStyleBackColor = true;
            this.bt_DangXuat.Click += new System.EventHandler(this.bt_DangXuat_Click);
            // 
            // FormHVDangKyLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(1884, 843);
            this.Controls.Add(this.bt_DangXuat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cb_MaHocKi);
            this.Controls.Add(this.bt_TimKiem);
            this.Controls.Add(this.tb_TimKiem);
            this.Controls.Add(this.tb_HocPhi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_ChiTiet);
            this.Controls.Add(this.bt_Phieu);
            this.Controls.Add(this.bt_TKB);
            this.Controls.Add(this.bt_Reload);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_DSDaDK);
            this.Controls.Add(this.dataGridView_DSMon);
            this.Controls.Add(this.lb_Khoa);
            this.Controls.Add(this.lb_MaHV);
            this.Controls.Add(this.lb_TenHV);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormHVDangKyLopHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký môn học";
            this.Load += new System.EventHandler(this.FormHVDangKyLopHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DSMon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dANG_KY_MON_HOCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDSDaDangKiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDSLopHocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DSDaDK)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_TenHV;
        private System.Windows.Forms.Label lb_MaHV;
        private System.Windows.Forms.Label lb_Khoa;
        private System.Windows.Forms.DataGridView dataGridView_DSMon;
        private DANG_KY_MON_HOCDataSet dANG_KY_MON_HOCDataSet;
        private System.Windows.Forms.BindingSource vDSDaDangKiBindingSource;
        private DANG_KY_MON_HOCDataSetTableAdapters.v_DSDaDangKiTableAdapter v_DSDaDangKiTableAdapter;
        private System.Windows.Forms.BindingSource vDSLopHocBindingSource;
        private DANG_KY_MON_HOCDataSetTableAdapters.v_DSLopHocTableAdapter v_DSLopHocTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView_DSDaDK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_Reload;
        private System.Windows.Forms.Button bt_TKB;
        private System.Windows.Forms.Button bt_Phieu;
        private System.Windows.Forms.Button bt_ChiTiet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_HocPhi;
        private System.Windows.Forms.TextBox tb_TimKiem;
        private System.Windows.Forms.Button bt_TimKiem;
        private System.Windows.Forms.ComboBox cb_MaHocKi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewButtonColumn Dangki;
        private System.Windows.Forms.DataGridViewButtonColumn Xoa;
        private System.Windows.Forms.DataGridViewButtonColumn ChuyenLop;
        private System.Windows.Forms.Button bt_DangXuat;
    }
}