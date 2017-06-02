using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLThuVien.GUI
{
    public partial class ucMuonTra : UserControl
    {

        Entities.tblHDMuon hdm;
        Entities.tblChiTietMuon ctm;
        int ktra;
        DataTable dt;
        BLL.ClassBLL bll_MT;
        int dem = 1;
        bool kiemtra = false;

        public ucMuonTra(string s)
        {
            InitializeComponent();
            labNVGD.Text = s;
            Locknut();
            txtNgayM.Value = DateTime.Now;
            LayMax();
            Reset_K();
            txt_shd.Enabled = false;



        }
        public bool check_MaS()
        {
            if (string.IsNullOrEmpty(txtTK_MaS.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã sách, vui lòng nhập !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (check_MaNM())
            {
                bll_MT = new BLL.ClassBLL();
                dt = new DataTable();
                dt = bll_MT.getMaNM(txtMaT.Text);
                grc1.DataSource = dt;
                binding_MaT();
            }
        }
        public bool check_MaNM()
        {
            if (string.IsNullOrEmpty(txtMaT.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã thẻ, vui lòng nhập !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        public void binding_MaT()
        {
            labMaT.DataBindings.Clear();
            labMaT.DataBindings.Add("Text", grc1.DataSource, "MaNM");
            labTen.DataBindings.Clear();
            labTen.DataBindings.Add("Text", grc1.DataSource, "TenNM");
            labNgaysinh.DataBindings.Clear();
            labNgaysinh.DataBindings.Add("Text", grc1.DataSource, "NgaySinh");
            labghichu.DataBindings.Clear();
            labghichu.DataBindings.Add("Text", grc1.DataSource, "GhiChu");
            labkhoa.DataBindings.Clear();
            labkhoa.DataBindings.Add("Text", grc1.DataSource, "Khoa");
            labgioitinh.DataBindings.Clear();
            labgioitinh.DataBindings.Add("Text", grc1.DataSource, "GioiTinh");
            labdongphi.DataBindings.Clear();
            labdongphi.DataBindings.Add("Text", grc1.DataSource, "DongPhi");
            labdiachi.DataBindings.Clear();
            labdiachi.DataBindings.Add("Text", grc1.DataSource, "DiaChi");
        }
        private void txtMaT_EditValueChanged(object sender, EventArgs e)
        {

            bll_MT = new BLL.ClassBLL();
            dt = new DataTable();
            dt = bll_MT.getMaNM(txtMaT.Text);
            grc1.DataSource = dt;
            binding_MaT();

        }
        public void binding_MaS()
        {
            labMaS.DataBindings.Clear();
            labMaS.DataBindings.Add("Text", gridControl2.DataSource, "MaS");
            labTenS.DataBindings.Clear();
            labTenS.DataBindings.Add("Text", gridControl2.DataSource, "TenS");
            labNXB.DataBindings.Clear();
            labNXB.DataBindings.Add("Text", gridControl2.DataSource, "NXB");
            labNamXB.DataBindings.Clear();
            labNamXB.DataBindings.Add("Text", gridControl2.DataSource, "NamXB");
            labGiaS.DataBindings.Clear();
            labGiaS.DataBindings.Add("Text", gridControl2.DataSource, "GiaSach");

        }
        private void txtTK_MaS_EditValueChanged(object sender, EventArgs e)
        {
            Selectall(txtTK_MaS.Text);
        }
        public void Selectall(string s)
        {
            bll_MT = new BLL.ClassBLL();
            dt = new DataTable();
            dt = bll_MT.GetSelectMaS(s);
            gridControl2.DataSource = dt;
            binding_MaS();

        }
        public void Locknut()
        {
            txtMaT.Enabled = true;
            txtNgayM.Enabled = true;
            txtGhiChu.Enabled = true;
            //btnTaoHD.Enabled = true;
            btnHuyHD.Enabled = false;
            btnHuyS.Enabled = false;
            BtnThemS.Enabled = true;

            txtTK_MaS.Enabled = true;
            btnHoanTat.Enabled = false;

        }
        public void unLocknut()
        {
            txtMaT.Enabled = false;
            txtNgayM.Enabled = false;
            txtGhiChu.Enabled = false;
            // btnTaoHD.Enabled = false;
            btnHuyHD.Enabled = true;
            btnHuyS.Enabled = true;
            txtTK_MaS.Enabled = true;


        }
        public bool checknut()
        {
            if (string.IsNullOrEmpty(labMaT.Text))
            {

                MessageBox.Show("Bạn chưa quét mã thẻ !", "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaT.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txt_shd.Text))
            {

                MessageBox.Show("Bạn chưa có số hóa đơn !", "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaT.Focus();
                return false;
            }
            return true;
        }
        private void BtnThemS_Click(object sender, EventArgs e)
        {
            if (checknut() && checknut1())
            {

                if (dem == 1)
                {
                    hdm = new Entities.tblHDMuon();
                    hdm.MaNM1 = labMaT.Text;
                    hdm.ManNV1 = labNVGD.Text;
                    hdm.SoHDMuon1 = int.Parse(txt_shd.Text);
                    hdm.NgayM1 = DateTime.Parse(txtNgayM.Value.ToString());
                    hdm.GhiChu1 = txtGhiChu.Text;
                    kiemtra = bll_MT.Insert_MuonS(hdm);
                }

                ctm = new Entities.tblChiTietMuon();
                ctm.MaS1 = labMaS.Text;
                ctm.SoHD1 = int.Parse(txt_shd.Text);
                bool kiemtra1 = bll_MT.Insert_ChiTietM(ctm);
                if (kiemtra1 && kiemtra)
                {
                    dem++;
                    ktra = 0;
                    ktra++;
                    MessageBox.Show("Thêm thành công !", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Reset_K();
                    unLocknut();
                    btnHoanTat.Enabled = true;
                    Reload_M(int.Parse(txt_shd.Text));
                    MoNut();
                }
                else
                {
                    MessageBox.Show("Không thêm được! kiểm tra lại. ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public bool checknut1()
        {
            if (string.IsNullOrEmpty(labMaS.Text))
            {
                MessageBox.Show("Bạn chưa quét mã sách !", "Tạo thành công", MessageBoxButtons.OK);
                labMaS.Focus();
                return false;

            }
            return true;
        }
        public void Reload_M(int s)
        {

            bll_MT = new BLL.ClassBLL();
            dt = new DataTable();
            dt = bll_MT.GetMaHD(s);
            gridControl1.DataSource = dt;
        }
        private void btnHuyS_Click(object sender, EventArgs e)
        {
            bool kiemtraxoa = bll_MT.Delete_MaS(textMS.Text);
            if (kiemtraxoa)
            {
                ktra--;
                MessageBox.Show("Bạn vừa xóa thành công !", "xóa thành công", MessageBoxButtons.OK);
                binding_K();
                Reload_M(int.Parse(txt_shd.Text));
                MoNut();
            }
            else
                MessageBox.Show("Không xóa được, kiểm tra lỗi !", "Lỗi", MessageBoxButtons.OK);
        }
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            binding_K();
        }
        public void binding_K()
        {
            textMS.DataBindings.Clear();
            textMS.DataBindings.Add("Text", gridControl1.DataSource, "MaS");
        }
        private void Reset_K()
        {
            txtTK_MaS.Text = null;
            labMaS.Text = null;
            labTenS.Text = null;
            labNXB.Text = null;
            labNamXB.Text = null;
            labGiaS.Text = null;
        }
        private void btnHuyHD_Click(object sender, EventArgs e)
        {
            bool kiemtraxoa = bll_MT.Delete_HDAll(int.Parse(txt_shd.Text));
            if (kiemtraxoa)
            {
                dem = 1;
                MessageBox.Show("Bạn vừa xóa thành công !", "xóa thành công", MessageBoxButtons.OK);
                Locknut();
                Reset_K();
                Reset_S();
                LayMax();
                Reload_M(int.Parse(txt_shd.Text));

            }
            else
                MessageBox.Show("Không xóa được, kiểm tra lỗi !", "Lỗi", MessageBoxButtons.OK);
        }
        public void Reset_S()
        {
            txtMaT.Text = null;
            txtGhiChu.Text = null;
            labTen.Text = null;
            labMaT.Text = null;
            labkhoa.Text = null;
            labgioitinh.Text = null;
            labghichu.Text = null;
            labNgaysinh.Text = null;
            labdiachi.Text = null;
            labdongphi.Text = null;

        }
        private void btnHoanTat_Click(object sender, EventArgs e)
        {
            dem = 1;
            Locknut();
            Reset_S();
            Reset_K();
            LayMax();
        }
        private void txtSoHD_EditValueChanged(object sender, EventArgs e)
        {
            Reload_M(int.Parse(txt_shd.Text));
        }
        public bool kiemtra1()
        {
            if (ktra >= 1)
                return true;
            return false;
        }
        public void MoNut()
        {
            if (kiemtra1())
                btnHoanTat.Enabled = true;
            else
                btnHoanTat.Enabled = false;
        }
        public void binding_SoHD()
        {
            txt_shd.DataBindings.Clear();
            txt_shd.DataBindings.Add("Text", gridControl3.DataSource, "SoHD");
        }
        public void LayMax()
        {
            bll_MT = new BLL.ClassBLL();
            dt = new DataTable();
            dt = bll_MT.SoHDMax();
            gridControl3.DataSource = dt;
            binding_SoHD();
        }

        private void txt_shd_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Reload_M(int.Parse(txt_shd.Text));
            }
            catch
            {

            }


        }

        private void txt_shd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
