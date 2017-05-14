namespace QLThuVien
{
    partial class Timkiemtheoten
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.searchTK = new DevExpress.XtraEditors.SearchControl();
            this.txtThanh = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchTK.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl3
            // 
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 53);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(731, 387);
            this.groupControl3.TabIndex = 56;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.groupControl2);
            this.groupControl1.Controls.Add(this.txtThanh);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(731, 53);
            this.groupControl1.TabIndex = 55;
            this.groupControl1.Text = "Chọn tìm kiếm tên";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.searchTK);
            this.groupControl2.Location = new System.Drawing.Point(301, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(195, 53);
            this.groupControl2.TabIndex = 53;
            this.groupControl2.Text = "Nhập từ khóa tìm kiếm";
            // 
            // searchTK
            // 
            this.searchTK.EditValue = "Mời gõ từ khóa....";
            this.searchTK.Location = new System.Drawing.Point(13, 24);
            this.searchTK.Name = "searchTK";
            this.searchTK.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchTK.Size = new System.Drawing.Size(167, 20);
            this.searchTK.TabIndex = 2;
            // 
            // txtThanh
            // 
            this.txtThanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtThanh.FormattingEnabled = true;
            this.txtThanh.Items.AddRange(new object[] {
            "TÊN ĐỘC GIẢ",
            "TÊN SÁCH",
            "TÊN NHÂN VIÊN"});
            this.txtThanh.Location = new System.Drawing.Point(12, 23);
            this.txtThanh.Name = "txtThanh";
            this.txtThanh.Size = new System.Drawing.Size(167, 21);
            this.txtThanh.TabIndex = 1;
            // 
            // Timkiemtheoten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 440);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl1);
            this.Name = "Timkiemtheoten";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TÌM KIẾM THEO TÊN";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchTK.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SearchControl searchTK;
        private System.Windows.Forms.ComboBox txtThanh;
    }
}