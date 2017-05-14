namespace QLThuVien
{
    partial class ThongTinNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongTinNhanVien));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridTT = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labDiaChi = new System.Windows.Forms.Label();
            this.labMaNV = new System.Windows.Forms.Label();
            this.labSDT = new System.Windows.Forms.Label();
            this.labTenNV = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Tag = "Tên:";
            this.label2.Text = "Tên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "SĐT:";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridTT);
            this.groupControl1.Controls.Add(this.pictureBox1);
            this.groupControl1.Controls.Add(this.labDiaChi);
            this.groupControl1.Controls.Add(this.labMaNV);
            this.groupControl1.Controls.Add(this.labSDT);
            this.groupControl1.Controls.Add(this.labTenNV);
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(283, 202);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Thông Tin Tài Khoản";
            // 
            // gridTT
            // 
            this.gridTT.Location = new System.Drawing.Point(15, 138);
            this.gridTT.MainView = this.gridView1;
            this.gridTT.Name = "gridTT";
            this.gridTT.Size = new System.Drawing.Size(10, 10);
            this.gridTT.TabIndex = 10;
            this.gridTT.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridTT.Load += new System.EventHandler(this.gridTT_Load);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gridView1.GridControl = this.gridTT;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "gridColumn1";
            this.gridColumn1.FieldName = "MaNV";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "gridColumn2";
            this.gridColumn2.FieldName = "TenNV";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "gridColumn3";
            this.gridColumn3.FieldName = "SDT";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "gridColumn4";
            this.gridColumn4.FieldName = "DiaChi";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(167, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 97);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // labDiaChi
            // 
            this.labDiaChi.AutoSize = true;
            this.labDiaChi.Location = new System.Drawing.Point(59, 108);
            this.labDiaChi.Name = "labDiaChi";
            this.labDiaChi.Size = new System.Drawing.Size(45, 13);
            this.labDiaChi.TabIndex = 8;
            this.labDiaChi.Tag = "Tên:";
            this.labDiaChi.Text = "Địa Chỉ:";
            // 
            // labMaNV
            // 
            this.labMaNV.AutoSize = true;
            this.labMaNV.Location = new System.Drawing.Point(61, 32);
            this.labMaNV.Name = "labMaNV";
            this.labMaNV.Size = new System.Drawing.Size(33, 13);
            this.labMaNV.TabIndex = 5;
            this.labMaNV.Text = "User:";
            // 
            // labSDT
            // 
            this.labSDT.AutoSize = true;
            this.labSDT.Location = new System.Drawing.Point(59, 82);
            this.labSDT.Name = "labSDT";
            this.labSDT.Size = new System.Drawing.Size(31, 13);
            this.labSDT.TabIndex = 7;
            this.labSDT.Text = "SĐT:";
            // 
            // labTenNV
            // 
            this.labTenNV.AutoSize = true;
            this.labTenNV.Location = new System.Drawing.Point(59, 56);
            this.labTenNV.Name = "labTenNV";
            this.labTenNV.Size = new System.Drawing.Size(29, 13);
            this.labTenNV.TabIndex = 6;
            this.labTenNV.Tag = "Tên:";
            this.labTenNV.Text = "Tên:";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(192, 159);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "Cancel";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Tag = "Tên:";
            this.label4.Text = "Địa Chỉ:";
            // 
            // ThongTinNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 202);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ThongTinNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Information User";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labDiaChi;
        private System.Windows.Forms.Label labMaNV;
        private System.Windows.Forms.Label labSDT;
        private System.Windows.Forms.Label labTenNV;
        private DevExpress.XtraGrid.GridControl gridTT;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
    }
}