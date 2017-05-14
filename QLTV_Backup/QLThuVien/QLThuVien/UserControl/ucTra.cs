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
    public partial class ucTra : UserControl
    {
        BLL.ClassBLL bll_Tra;
        DataTable dt;
        Entities.tblTra t;
        public ucTra(string s)
        {
            InitializeComponent();
            txtNgayT.Value = DateTime.Now;
            labNVGD.Text = s;
            Reset();
        }

        private void txtMaS_EditValueChanged(object sender, EventArgs e)
        {
            bll_Tra = new BLL.ClassBLL();
            dt = new DataTable();
            dt = bll_Tra.Getall_MaS(txtMaS.Text);
            gridTra.DataSource = dt;
            binding_Tra();
        }
        public void binding_Tra()
        {
            labTenS.DataBindings.Clear();
            labTenS.DataBindings.Add("Text", gridTra.DataSource, "TenS");
            labTenNV.DataBindings.Clear();
            labTenNV.DataBindings.Add("Text", gridTra.DataSource, "TenNV");
            labTenNM.DataBindings.Clear();
            labTenNM.DataBindings.Add("Text", gridTra.DataSource, "TenNM");
            labNgayM.DataBindings.Clear();
            labNgayM.DataBindings.Add("Text", gridTra.DataSource, "NgayM");
            labNXB.DataBindings.Clear();
            labNXB.DataBindings.Add("Text", gridTra.DataSource, "NXB");
            labNamXB.DataBindings.Clear();
            labNamXB.DataBindings.Add("Text", gridTra.DataSource, "NamXB");
            labGiaSach.DataBindings.Clear();
            labGiaSach.DataBindings.Add("Text", gridTra.DataSource, "GiaSach");
            labGhiChu.DataBindings.Clear();
            labGhiChu.DataBindings.Add("Text", gridTra.DataSource, "GhiChu");
        }

        private void btnHoanTat_Click(object sender, EventArgs e)
        {
            if(checktxt())
            {
                t = new Entities.tblTra();
                t.MaNV1 = labNVGD.Text;
                t.MaS1 = txtMaS.Text;
                t.NgayT1 = DateTime.Parse(txtNgayT.Value.ToString());
                t.GhiChu1 = txtGhiChu.Text;
                bool kt = bll_Tra.Insert_Tra(t);
                if(kt)
                {
                    MessageBox.Show("Bạn đã trả thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    txtGhiChu.Text = "";
                    txtMaS.Text = "";
                    txtNgayT.Value = DateTime.Now;
                    txtMaS.Focus();
                    reloadgrid();
                    Reset();
                }
                else
                {
                    
                    MessageBox.Show("Không thành công thành công!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMaS.Focus();
                    Reset();
                }
            }

        }
        public bool checktxt()
        {
            if (string.IsNullOrEmpty(txtMaS.Text))
            {
                MessageBox.Show("Bạn chư nhập Mã sách, xin vui lòng nhập!", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaS.Focus();
                return false;
            }           
            return true;
        }

        private void gridControl1_Load(object sender, EventArgs e)
        {

        }
        public void reloadgrid()
        {
            bll_Tra = new BLL.ClassBLL();
            dt = new DataTable();
            dt = bll_Tra.getallTra();
            gridControl1.DataSource = dt;
        }

        private void ucTra_Load(object sender, EventArgs e)
        {
            reloadgrid();
        }
        public void Reset()
        {
            labGhiChu.Text = "";
            labGiaSach.Text = "";
            labNamXB.Text = "";
            labNgayM.Text = "";
            labNXB.Text = "";
            labTenNM.Text = "";
            labTenNV.Text = "";
            labTenS.Text = "";
        }
    }
}
