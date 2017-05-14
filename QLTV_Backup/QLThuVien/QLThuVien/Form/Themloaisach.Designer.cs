namespace QLThuVien
{
    partial class Themloaisach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Themloaisach));
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.grcls = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtGiaSach = new DevExpress.XtraEditors.SpinEdit();
            this.btnxoa = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtNamXB = new DevExpress.XtraEditors.TextEdit();
            this.btnchuyen = new DevExpress.XtraEditors.SimpleButton();
            this.txtNXB = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.btnhoantat = new DevExpress.XtraEditors.SimpleButton();
            this.btnsua = new DevExpress.XtraEditors.SimpleButton();
            this.btnthem = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenS = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.bsahbs = new DevExpress.XtraEditors.LabelControl();
            this.txtMaL = new DevExpress.XtraEditors.TextEdit();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grcls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaSach.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNamXB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNXB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grcls
            // 
            this.grcls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcls.Location = new System.Drawing.Point(426, 0);
            this.grcls.MainView = this.gridView1;
            this.grcls.Name = "grcls";
            this.grcls.Size = new System.Drawing.Size(744, 397);
            this.grcls.TabIndex = 56;
            this.grcls.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.grcls.Load += new System.EventHandler(this.grcls_Load);
            this.grcls.Click += new System.EventHandler(this.grcls_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.gridView1.GridControl = this.grcls;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã loại sách";
            this.gridColumn1.FieldName = "MaL";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.FixedWidth = true;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 136;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên loại sách";
            this.gridColumn2.FieldName = "TenS";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.FixedWidth = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 176;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Nhà suất bản";
            this.gridColumn3.FieldName = "NXB";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.FixedWidth = true;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 179;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Năm xuất bản";
            this.gridColumn4.FieldName = "NamXB";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.OptionsColumn.FixedWidth = true;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 110;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Giá sách";
            this.gridColumn5.FieldName = "GiaSach";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 81;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtGiaSach);
            this.groupControl1.Controls.Add(this.btnxoa);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtNamXB);
            this.groupControl1.Controls.Add(this.btnchuyen);
            this.groupControl1.Controls.Add(this.txtNXB);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.btnhoantat);
            this.groupControl1.Controls.Add(this.btnsua);
            this.groupControl1.Controls.Add(this.btnthem);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.txtTenS);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.bsahbs);
            this.groupControl1.Controls.Add(this.txtMaL);
            this.groupControl1.Controls.Add(this.txtId);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(426, 397);
            this.groupControl1.TabIndex = 57;
            this.groupControl1.Text = "Thao tác";
            // 
            // txtGiaSach
            // 
            this.txtGiaSach.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtGiaSach.Location = new System.Drawing.Point(128, 187);
            this.txtGiaSach.Name = "txtGiaSach";
            this.txtGiaSach.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtGiaSach.Size = new System.Drawing.Size(72, 20);
            this.txtGiaSach.TabIndex = 38;
            // 
            // btnxoa
            // 
            this.btnxoa.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnxoa.Image = global::QLThuVien.Properties.Resources.close_32x32;
            this.btnxoa.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnxoa.Location = new System.Drawing.Point(112, 251);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(50, 56);
            this.btnxoa.TabIndex = 37;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(302, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "(*) Bắt buộc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(302, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "(*) Bắt buộc";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(234, 190);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(37, 13);
            this.labelControl3.TabIndex = 33;
            this.labelControl3.Text = "K - VNĐ";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(15, 186);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 13);
            this.labelControl1.TabIndex = 31;
            this.labelControl1.Text = "Giá sách";
            // 
            // txtNamXB
            // 
            this.txtNamXB.Location = new System.Drawing.Point(129, 159);
            this.txtNamXB.Name = "txtNamXB";
            this.txtNamXB.Size = new System.Drawing.Size(71, 20);
            this.txtNamXB.TabIndex = 3;
            // 
            // btnchuyen
            // 
            this.btnchuyen.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnchuyen.Image = ((System.Drawing.Image)(resources.GetObject("btnchuyen.Image")));
            this.btnchuyen.ImageIndex = 4;
            this.btnchuyen.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnchuyen.Location = new System.Drawing.Point(166, 251);
            this.btnchuyen.Name = "btnchuyen";
            this.btnchuyen.Size = new System.Drawing.Size(107, 56);
            this.btnchuyen.TabIndex = 8;
            this.btnchuyen.Text = "Chuyển chức năng";
            this.btnchuyen.Click += new System.EventHandler(this.btnchuyen_Click);
            // 
            // txtNXB
            // 
            this.txtNXB.Location = new System.Drawing.Point(129, 134);
            this.txtNXB.Name = "txtNXB";
            this.txtNXB.Size = new System.Drawing.Size(239, 20);
            this.txtNXB.TabIndex = 2;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(15, 136);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(65, 13);
            this.labelControl8.TabIndex = 27;
            this.labelControl8.Text = "Nhà xuất bản";
            // 
            // btnhoantat
            // 
            this.btnhoantat.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnhoantat.Image = ((System.Drawing.Image)(resources.GetObject("btnhoantat.Image")));
            this.btnhoantat.ImageIndex = 4;
            this.btnhoantat.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnhoantat.Location = new System.Drawing.Point(277, 251);
            this.btnhoantat.Name = "btnhoantat";
            this.btnhoantat.Size = new System.Drawing.Size(119, 56);
            this.btnhoantat.TabIndex = 9;
            this.btnhoantat.Text = "Hoàn tất";
            this.btnhoantat.Click += new System.EventHandler(this.btnhoantat_Click_1);
            // 
            // btnsua
            // 
            this.btnsua.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnsua.Image = ((System.Drawing.Image)(resources.GetObject("btnsua.Image")));
            this.btnsua.ImageIndex = 2;
            this.btnsua.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnsua.Location = new System.Drawing.Point(59, 251);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(50, 56);
            this.btnsua.TabIndex = 6;
            this.btnsua.Text = "Sửa";
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click_1);
            // 
            // btnthem
            // 
            this.btnthem.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnthem.Image = ((System.Drawing.Image)(resources.GetObject("btnthem.Image")));
            this.btnthem.ImageIndex = 3;
            this.btnthem.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnthem.Location = new System.Drawing.Point(6, 251);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(50, 56);
            this.btnthem.TabIndex = 5;
            this.btnthem.Text = "Thêm";
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click_1);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(15, 164);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(67, 13);
            this.labelControl6.TabIndex = 8;
            this.labelControl6.Text = "Năm xuất bản";
            // 
            // txtTenS
            // 
            this.txtTenS.Location = new System.Drawing.Point(129, 104);
            this.txtTenS.Name = "txtTenS";
            this.txtTenS.Size = new System.Drawing.Size(167, 20);
            this.txtTenS.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(15, 107);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(43, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Tên sách";
            // 
            // bsahbs
            // 
            this.bsahbs.Location = new System.Drawing.Point(16, 81);
            this.bsahbs.Name = "bsahbs";
            this.bsahbs.Size = new System.Drawing.Size(58, 13);
            this.bsahbs.TabIndex = 2;
            this.bsahbs.Text = "Mã loại sách";
            // 
            // txtMaL
            // 
            this.txtMaL.Location = new System.Drawing.Point(129, 79);
            this.txtMaL.Name = "txtMaL";
            this.txtMaL.Size = new System.Drawing.Size(167, 20);
            this.txtMaL.TabIndex = 0;
            // 
            // txtId
            // 
            this.txtId.EditValue = "0";
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(333, 134);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(30, 20);
            this.txtId.TabIndex = 36;
            // 
            // Themloaisach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 397);
            this.Controls.Add(this.grcls);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Themloaisach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THÊM LOẠI SÁCH";
            this.Load += new System.EventHandler(this.Themloaisach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grcls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaSach.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNamXB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNXB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraGrid.GridControl grcls;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtNamXB;
        private DevExpress.XtraEditors.SimpleButton btnchuyen;
        private DevExpress.XtraEditors.TextEdit txtNXB;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SimpleButton btnhoantat;
        private DevExpress.XtraEditors.SimpleButton btnsua;
        private DevExpress.XtraEditors.SimpleButton btnthem;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtTenS;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl bsahbs;
        private DevExpress.XtraEditors.TextEdit txtMaL;
        private DevExpress.XtraEditors.TextEdit txtId;
        private DevExpress.XtraEditors.SimpleButton btnxoa;
        private DevExpress.XtraEditors.SpinEdit txtGiaSach;
    }
}