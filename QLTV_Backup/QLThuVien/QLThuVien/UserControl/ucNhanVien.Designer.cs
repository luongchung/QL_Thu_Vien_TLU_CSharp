namespace QLThuVien.GUI
{
    partial class ucNhanVien
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucNhanVien));
            this.grcNV = new DevExpress.XtraGrid.GridControl();
            this.gridview = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.btnhoantat = new DevExpress.XtraEditors.SimpleButton();
            this.imagebutton = new DevExpress.Utils.ImageCollection(this.components);
            this.btnxoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnsua = new DevExpress.XtraEditors.SimpleButton();
            this.btnthem = new DevExpress.XtraEditors.SimpleButton();
            this.txtDiaChi = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnchuyen = new DevExpress.XtraEditors.SimpleButton();
            this.txtSDT = new DevExpress.XtraEditors.TextEdit();
            this.txtTenNV = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.bsahbs = new DevExpress.XtraEditors.LabelControl();
            this.txtMaNV = new DevExpress.XtraEditors.TextEdit();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.btnEXCEL = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.grcNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagebutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grcNV
            // 
            this.grcNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcNV.Location = new System.Drawing.Point(348, 0);
            this.grcNV.MainView = this.gridview;
            this.grcNV.Name = "grcNV";
            this.grcNV.Size = new System.Drawing.Size(522, 497);
            this.grcNV.TabIndex = 5;
            this.grcNV.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridview});
            // 
            // gridview
            // 
            this.gridview.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn9,
            this.gridColumn4});
            this.gridview.GridControl = this.grcNV;
            this.gridview.Name = "gridview";
            this.gridview.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Id";
            this.gridColumn1.FieldName = "Id";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Mã nhân viên";
            this.gridColumn2.FieldName = "MaNV";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.FixedWidth = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 82;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Tên nhân viên";
            this.gridColumn3.FieldName = "TenNV";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 60;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Số điện thoại";
            this.gridColumn9.FieldName = "SDT";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.OptionsColumn.AllowEdit = false;
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Địa chỉ";
            this.gridColumn4.FieldName = "DiaChi";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(14, 118);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(62, 13);
            this.labelControl8.TabIndex = 27;
            this.labelControl8.Text = "Số điện thoại";
            // 
            // btnhoantat
            // 
            this.btnhoantat.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnhoantat.Image = ((System.Drawing.Image)(resources.GetObject("btnhoantat.Image")));
            this.btnhoantat.ImageIndex = 4;
            this.btnhoantat.ImageList = this.imagebutton;
            this.btnhoantat.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnhoantat.Location = new System.Drawing.Point(166, 259);
            this.btnhoantat.Name = "btnhoantat";
            this.btnhoantat.Size = new System.Drawing.Size(102, 56);
            this.btnhoantat.TabIndex = 8;
            this.btnhoantat.Text = "Hoàn tất";
            this.btnhoantat.Click += new System.EventHandler(this.btnhoantat_Click);
            // 
            // imagebutton
            // 
            this.imagebutton.ImageSize = new System.Drawing.Size(32, 32);
            this.imagebutton.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imagebutton.ImageStream")));
            this.imagebutton.Images.SetKeyName(0, "18122009519_11954453151817762013molumen_red_square_error_warning_icon.svg.hi1.png" +
        "");
            this.imagebutton.Images.SetKeyName(1, "delete-xxl.png");
            this.imagebutton.Images.SetKeyName(2, "edit.png");
            this.imagebutton.Images.SetKeyName(3, "icon_tintuc.png");
            this.imagebutton.Images.SetKeyName(4, "luu_hang_loat_nhieu_anh.png");
            this.imagebutton.Images.SetKeyName(5, "unnamed.png");
            // 
            // btnxoa
            // 
            this.btnxoa.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnxoa.ImageIndex = 1;
            this.btnxoa.ImageList = this.imagebutton;
            this.btnxoa.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnxoa.Location = new System.Drawing.Point(115, 197);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(50, 56);
            this.btnxoa.TabIndex = 6;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnsua.Image = ((System.Drawing.Image)(resources.GetObject("btnsua.Image")));
            this.btnsua.ImageIndex = 2;
            this.btnsua.ImageList = this.imagebutton;
            this.btnsua.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnsua.Location = new System.Drawing.Point(62, 197);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(50, 56);
            this.btnsua.TabIndex = 5;
            this.btnsua.Text = "Sửa";
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnthem.Image = ((System.Drawing.Image)(resources.GetObject("btnthem.Image")));
            this.btnthem.ImageIndex = 3;
            this.btnthem.ImageList = this.imagebutton;
            this.btnthem.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnthem.Location = new System.Drawing.Point(9, 197);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(50, 56);
            this.btnthem.TabIndex = 4;
            this.btnthem.Text = "Thêm";
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(95, 141);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(173, 44);
            this.txtDiaChi.TabIndex = 3;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(15, 154);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(32, 13);
            this.labelControl6.TabIndex = 8;
            this.labelControl6.Text = "Địa chỉ";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.btnEXCEL);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.btnchuyen);
            this.groupControl1.Controls.Add(this.txtSDT);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.btnhoantat);
            this.groupControl1.Controls.Add(this.btnxoa);
            this.groupControl1.Controls.Add(this.btnsua);
            this.groupControl1.Controls.Add(this.btnthem);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.txtTenNV);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.bsahbs);
            this.groupControl1.Controls.Add(this.txtMaNV);
            this.groupControl1.Controls.Add(this.txtDiaChi);
            this.groupControl1.Controls.Add(this.txtId);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(348, 497);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Thao tác";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(272, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "(*) Bắt buộc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(272, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "(*) Bắt buộc";
            // 
            // btnchuyen
            // 
            this.btnchuyen.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnchuyen.Image = ((System.Drawing.Image)(resources.GetObject("btnchuyen.Image")));
            this.btnchuyen.ImageIndex = 4;
            this.btnchuyen.ImageList = this.imagebutton;
            this.btnchuyen.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnchuyen.Location = new System.Drawing.Point(166, 197);
            this.btnchuyen.Name = "btnchuyen";
            this.btnchuyen.Size = new System.Drawing.Size(101, 56);
            this.btnchuyen.TabIndex = 7;
            this.btnchuyen.Text = "Chuyển chức năng";
            this.btnchuyen.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(95, 115);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(172, 20);
            this.txtSDT.TabIndex = 2;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(95, 91);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(172, 20);
            this.txtTenNV.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(14, 92);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(68, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Tên nhân viên";
            // 
            // bsahbs
            // 
            this.bsahbs.Location = new System.Drawing.Point(15, 66);
            this.bsahbs.Name = "bsahbs";
            this.bsahbs.Size = new System.Drawing.Size(64, 13);
            this.bsahbs.TabIndex = 2;
            this.bsahbs.Text = "Mã nhân viên";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(95, 66);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(172, 20);
            this.txtMaNV.TabIndex = 0;
            // 
            // txtId
            // 
            this.txtId.EditValue = "0";
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(237, 150);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(10, 20);
            this.txtId.TabIndex = 37;
            // 
            // btnEXCEL
            // 
            this.btnEXCEL.ImageIndex = 5;
            this.btnEXCEL.ImageList = this.imagebutton;
            this.btnEXCEL.ImageLocation = DevExpress.XtraEditors.ImageLocation.BottomCenter;
            this.btnEXCEL.Location = new System.Drawing.Point(229, 335);
            this.btnEXCEL.Name = "btnEXCEL";
            this.btnEXCEL.Size = new System.Drawing.Size(38, 37);
            this.btnEXCEL.TabIndex = 43;
            this.btnEXCEL.Click += new System.EventHandler(this.btnEXCEL_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(166, 347);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(57, 13);
            this.labelControl1.TabIndex = 44;
            this.labelControl1.Text = "Xuất Excel :";
            // 
            // ucNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grcNV);
            this.Controls.Add(this.groupControl1);
            this.Name = "ucNhanVien";
            this.Size = new System.Drawing.Size(870, 497);
            this.Load += new System.EventHandler(this.ucNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grcNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagebutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grcNV;
        private DevExpress.XtraGrid.Views.Grid.GridView gridview;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SimpleButton btnhoantat;
        private DevExpress.Utils.ImageCollection imagebutton;
        private DevExpress.XtraEditors.SimpleButton btnxoa;
        private DevExpress.XtraEditors.SimpleButton btnsua;
        private DevExpress.XtraEditors.SimpleButton btnthem;
        private DevExpress.XtraEditors.MemoEdit txtDiaChi;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtSDT;
        private DevExpress.XtraEditors.TextEdit txtTenNV;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl bsahbs;
        private DevExpress.XtraEditors.TextEdit txtMaNV;
        private DevExpress.XtraEditors.SimpleButton btnchuyen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtId;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnEXCEL;
    }
}
