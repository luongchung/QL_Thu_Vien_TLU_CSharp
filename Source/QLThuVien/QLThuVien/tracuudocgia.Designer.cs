namespace QLThuVien
{
    partial class tracuudocgia
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
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.grid_tracuudocgia = new DevExpress.XtraGrid.GridControl();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn19 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn20 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn21 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn22 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn23 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.txt_docgia = new System.Windows.Forms.Label();
            this.searchTK_DG = new DevExpress.XtraEditors.SearchControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_tracuudocgia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchTK_DG.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.grid_tracuudocgia);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 53);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(635, 382);
            this.groupControl3.TabIndex = 58;
            // 
            // grid_tracuudocgia
            // 
            this.grid_tracuudocgia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_tracuudocgia.Location = new System.Drawing.Point(2, 20);
            this.grid_tracuudocgia.MainView = this.gridView4;
            this.grid_tracuudocgia.Name = "grid_tracuudocgia";
            this.grid_tracuudocgia.Size = new System.Drawing.Size(631, 360);
            this.grid_tracuudocgia.TabIndex = 4;
            this.grid_tracuudocgia.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn18,
            this.gridColumn19,
            this.gridColumn20,
            this.gridColumn21,
            this.gridColumn22,
            this.gridColumn23,
            this.gridColumn1});
            this.gridView4.GridControl = this.grid_tracuudocgia;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn18
            // 
            this.gridColumn18.Caption = "Mã sách";
            this.gridColumn18.FieldName = "MaS";
            this.gridColumn18.Name = "gridColumn18";
            this.gridColumn18.Visible = true;
            this.gridColumn18.VisibleIndex = 0;
            // 
            // gridColumn19
            // 
            this.gridColumn19.Caption = "Mã loại";
            this.gridColumn19.FieldName = "MaL";
            this.gridColumn19.Name = "gridColumn19";
            this.gridColumn19.Visible = true;
            this.gridColumn19.VisibleIndex = 1;
            // 
            // gridColumn20
            // 
            this.gridColumn20.Caption = "Tên sách";
            this.gridColumn20.FieldName = "TenS";
            this.gridColumn20.Name = "gridColumn20";
            this.gridColumn20.Visible = true;
            this.gridColumn20.VisibleIndex = 2;
            // 
            // gridColumn21
            // 
            this.gridColumn21.Caption = "Nhà xuất bản";
            this.gridColumn21.FieldName = "NXB";
            this.gridColumn21.Name = "gridColumn21";
            this.gridColumn21.Visible = true;
            this.gridColumn21.VisibleIndex = 3;
            // 
            // gridColumn22
            // 
            this.gridColumn22.Caption = "Năm xuất bản";
            this.gridColumn22.FieldName = "NamXB";
            this.gridColumn22.Name = "gridColumn22";
            this.gridColumn22.Visible = true;
            this.gridColumn22.VisibleIndex = 4;
            // 
            // gridColumn23
            // 
            this.gridColumn23.Caption = "Giá sách";
            this.gridColumn23.FieldName = "GiaSach";
            this.gridColumn23.Name = "gridColumn23";
            this.gridColumn23.Visible = true;
            this.gridColumn23.VisibleIndex = 5;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Tên người mươn";
            this.gridColumn1.FieldName = "TenNM";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.txt_docgia);
            this.groupControl2.Controls.Add(this.searchTK_DG);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(635, 53);
            this.groupControl2.TabIndex = 53;
            this.groupControl2.Text = "Nhập tên đọc giả cần tra cứu";
            // 
            // txt_docgia
            // 
            this.txt_docgia.AutoSize = true;
            this.txt_docgia.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_docgia.Location = new System.Drawing.Point(196, 25);
            this.txt_docgia.Name = "txt_docgia";
            this.txt_docgia.Size = new System.Drawing.Size(0, 19);
            this.txt_docgia.TabIndex = 3;
            // 
            // searchTK_DG
            // 
            this.searchTK_DG.EditValue = "Mời nhập tên đọc giả....";
            this.searchTK_DG.Location = new System.Drawing.Point(13, 24);
            this.searchTK_DG.Name = "searchTK_DG";
            this.searchTK_DG.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchTK_DG.Properties.Items.AddRange(new object[] {
            "Mời nhập tên đọc giả...."});
            this.searchTK_DG.Size = new System.Drawing.Size(167, 20);
            this.searchTK_DG.TabIndex = 2;
            this.searchTK_DG.EditValueChanged += new System.EventHandler(this.searchTK_DG_EditValueChanged);
            // 
            // tracuudocgia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 435);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Name = "tracuudocgia";
            this.Text = "Tra cứu đọc giả";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_tracuudocgia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchTK_DG.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SearchControl searchTK_DG;
        private DevExpress.XtraGrid.GridControl grid_tracuudocgia;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn18;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn19;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn20;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn21;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn22;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn23;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private System.Windows.Forms.Label txt_docgia;
    }
}